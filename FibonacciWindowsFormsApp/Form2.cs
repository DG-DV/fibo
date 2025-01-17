﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciWindowsFormsApp
{
    public partial class Form2 : Form
    {
        //Use of Action Worker to automaticaly close the Form1
        public Action Worker { get; set; }

        public Form2(Action worker = null)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //use of lambda expression : t => this.Close()
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
