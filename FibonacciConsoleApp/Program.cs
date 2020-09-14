using FibonacciConsoleApp.FibonacciServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciConsoleApp
{
    class Program
    {
        internal static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string ErrorMessage = "Merci de faire attention à votre saisie. Seule la saisie d'un nombre de 9 chiffres au maximum est acceptée.";

        private const string ConsoleErrorMessage = "Erreur innattendue, merci de prévenir votre administrateur";
        static void Main(string[] args)
        {
            log.Info("Start");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title="Suite de Fibonacci - Saisir`\"q\" puis \"Entrée\" pour quitter";
            Console.WriteLine("Bienvenu au calcul de la suite de Fibonacci - Un premier test aura lieu avec le nombre 10 \n");
            Console.Beep();
            FibonacciServiceReference.FiboWebServiceSoapClient fiboWebServiceSoapClient = new FibonacciServiceReference.FiboWebServiceSoapClient();

               SaisirNouvelleValeur(fiboWebServiceSoapClient, "10", true);

        }

        private static void SaisirNouvelleValeur(FiboWebServiceSoapClient fiboWebServiceSoapClient, string userText, bool firstTime = false)
        {
            KeyValuePair<bool, int> fiboNumber = IsIntegerValue(userText);

            
            if (userText == "q")
            {
                log.Info("user choice : " + userText);
                Console.WriteLine("Vous avez choisi de quitter. Appuyer sur une touche et la fenêtre se fermera.");
                alerteSonore(2);
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (fiboNumber.Key == true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                    var message = "Le résultat pour " + userText + " est : " + fiboWebServiceSoapClient.fibonacci2switch(fiboNumber.Value);
                    alerteSonore(1);
                    if (firstTime)
                        Console.Write(message);
                    else
                        Console.WriteLine(message);
                    log.Info(message);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                alerteSonore(3);
                Console.WriteLine(ErrorMessage);
            }
            alerteSonore(1);
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Entrer un autre nombre de 9 chiffres au maximum, afin de calculer son résultat selon la suite de Fibonnacci");

            userText = Console.ReadLine();
            log.Info(userText);

                SaisirNouvelleValeur(fiboWebServiceSoapClient, userText);
        }

        private static void alerteSonore(int nbAlert)
        {
            for (int i = 0; i < nbAlert; i++)
            {
                Console.Beep();
            }
        }

        private static KeyValuePair<bool,int> IsIntegerValue(string userText)
        {
            int number;
            bool isAnInteger = int.TryParse(userText, out number);
            return new KeyValuePair<bool, int>(isAnInteger,number);
        }
        private static void ErrorLog(Exception e)
        {
            Program.log.Error("*********START ERROR******************" + "\n" + e.Source + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e.Data + "********END ERROR*******************");
        }
    }
}