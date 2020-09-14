using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FibonacciWindowsFormsApp;
using FibonacciClassLibrary;
using System.IO;
using Newtonsoft.Json;

namespace FibonacciWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private const string ServiceErrorMessage = "Service Inaccessible ";
        private const string AdminErrorMessage = "Veuillez nous excuser, une erreur inattendue s'est produite. Veuillez vous rapprocher de l'administrateur.";

        private Tuple<string, int, string> btnValue2;

        protected Tuple<string, int, string> GetbtnValue2()
        {
            return btnValue2;
        }

        protected void SetbtnValue2(Tuple<string, int, string> value)
        {
            btnValue2 = value;
        }

        public Form1()
        {
            InitializeComponent();
        }
 
        public async void CloseBusyWaintingForm()
        {
            Program.log.Info("Close Busy");
            Tuple<string, string, Object> FiboParams = CallFiboServices();
            Program.log.Info("Paramètres du service " + FiboParams.Item1 + ", " + FiboParams.Item2 + ", " + FiboParams.Item3);
            if (FiboParams != null)
                switch (FiboParams.Item2)
                {
                    case "int":
                        switch (FiboParams.Item1)
                        {
                            case "directComputeBtn":
                            case "computeUerNumber":
                                try
                                {
                                    var fiboResponse = await ((Task<int>)FiboParams.Item3);
                                    Program.log.Info("Réponse du service " + fiboResponse.ToString());
                                    ShowMessage(fiboResponse.ToString());
                                }
                                catch (Exception e)
                                {
                                    ErrorLog(e);
                                    ShowMessage(AdminErrorMessage);
                                }
                                break;
                        }
                        break;
                    case "string":
                        try
                        {
                            var response = await ((Task<FibonacciServiceReference.XmlToJsonResponse>)FiboParams.Item3);
                            Program.log.Info("Réponse du service " + response.Body);
                            ShowMessage(response.Body.XmlToJsonResult);

                            var jsonByte = Encoding.UTF8.GetBytes(response.Body.XmlToJsonResult);
                            webBrowser1.DocumentStream = new MemoryStream(jsonByte);
                        }
                        catch (Exception e)
                        {
                            ErrorLog(e);
                            ShowMessage(AdminErrorMessage);
                        }
                        break;
                }
        }

        private static void ErrorLog(Exception e)
        {
            Program.log.Error("*********START ERROR******************" + "\n" + e.Source + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e.Data + "********END ERROR*******************");
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);            
        }

        protected Tuple<string, string, Object> CallFiboServices()
        {
            switch (GetbtnValue2().Item1)
            {
                case "directComputeBtn":
                    return new Tuple<string,string,Object>("directComputeBtn","int",Fibo());
                    break;
                case "computeUerNumber":
                    return new Tuple<string, string, Object>("computeUerNumber", "int", Fibo(GetbtnValue2().Item2));
                    break;
                case "xmlToJsonBtn":
                    return new Tuple<string, string, Object>("xmlToJsonBtn", "string", Fibo(GetbtnValue2().Item3));
                    break;
            }
            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ControlLog(sender);
            FormWaitingAsync();
            SetbtnValue2(new Tuple<string, int, string>(((Control)sender).Name, int.MinValue, null));

        }

        private static void ControlLog(object sender)
        {
            Program.log.Info(((Control)sender).Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlLog(sender);
            int fiboNumber = default;
            bool isInteger = int.TryParse(computeTb.Text, out fiboNumber);
            if (isInteger)
            {
                SetbtnValue2(new Tuple<string, int, string>(((Control)sender).Name, fiboNumber ,null));
                FormWaitingAsync();
            }
            else
            {
                ShowMessage("Saisie incorrecte, merci de saisir un nombre");
            }
        }

        private void xmlToJsonBtn_Click(object sender, EventArgs e)
        {
            ControlLog(sender);
            if (!string.IsNullOrEmpty(xmlTb.Text))
            {
                SetbtnValue2(new Tuple<string, int, string>(((Control)sender).Name, default, xmlTb.Text));
                FormWaitingAsync();
            }
            else
            {
                ShowMessage("Saisie incorrecte, merci de vérifier votre saisie xml");
            }
        }

        public void FormWaitingAsync()
        {
            Program.log.Info("Form Waiting");
            BeginInvoke(new Action(() =>
             {
                 using (
                             Form2 Form4 = new Form2(CloseBusyWaintingForm)
                             {
                                 Name = "FiboDialogWindow",
                                 Size = new Size(300, 100),
                                 ControlBox = true,
                                 StartPosition = FormStartPosition.CenterParent,
                                 FormBorderStyle = FormBorderStyle.FixedToolWindow,
                                 Text = "Busy Waiting Form",
                                 BackColor = SystemColors.ButtonHighlight
                             }
                   )
                 {
                     Label textLabel1 = new Label() { Left = 25, Top = 25, Text = "Please wait processing..." };
                     Form4.Controls.Add(textLabel1);
                     ProgressBar fiboLoading1 = FiboProgressBarLoadingA();
                     Form4.Controls.Add(fiboLoading1);

                     DialogResult dialogResult1 = new DialogResult();
                     Form4.Owner = this;
                     dialogResult1 = Form4.ShowDialog(this);
                     Program.log.Info("Dialog close");
                 }

             }));
        }

        private ProgressBar FiboProgressBarLoadingA()
        {
            ProgressBar FibonacciLoadingBar = new ProgressBar()
            {
                Name = "FibonacciLoadingBar",
                Visible = true,
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Step = 10,
                Anchor = AnchorStyles.None,
                Style = ProgressBarStyle.Blocks,
                Size = new Size(200, 25)
            };

            while (FibonacciLoadingBar.Value < 100)
            {
                FibonacciLoadingBar.Increment(90);
                FibonacciLoadingBar.PerformStep();
            }
            return FibonacciLoadingBar;
        }

        public async Task<int> Fibo(int fiboNumber = 10)
        {
            FibonacciServiceReference.FiboWebServiceSoapClient fibonacciServiceReference = new FibonacciServiceReference.FiboWebServiceSoapClient();
            Task<int> retour = fibonacciServiceReference.fibonacci2switchAsync(fiboNumber);
            return await retour;
        }
        public async Task<FibonacciServiceReference.XmlToJsonResponse> Fibo(string xmlToConvert)
        {
            FibonacciServiceReference.FiboWebServiceSoapClient fibonacciServiceReference = new FibonacciServiceReference.FiboWebServiceSoapClient();
            Task<FibonacciServiceReference.XmlToJsonResponse> retour = fibonacciServiceReference.XmlToJsonAsync(xmlToConvert);
            return await retour;
        }
    }
}
