namespace FibonacciWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.directComputeBtn = new System.Windows.Forms.Button();
            this.computeTb = new System.Windows.Forms.TextBox();
            this.computeUerNumber = new System.Windows.Forms.Button();
            this.xmlToJsonBtn = new System.Windows.Forms.Button();
            this.xmlTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directComputeBtn
            // 
            this.directComputeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directComputeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directComputeBtn.Location = new System.Drawing.Point(75, 80);
            this.directComputeBtn.Name = "directComputeBtn";
            this.directComputeBtn.Size = new System.Drawing.Size(182, 55);
            this.directComputeBtn.TabIndex = 0;
            this.directComputeBtn.Text = "\"Compute Fibonancci(10)\"";
            this.directComputeBtn.UseVisualStyleBackColor = true;
            this.directComputeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // computeTb
            // 
            this.computeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeTb.Location = new System.Drawing.Point(651, 36);
            this.computeTb.Name = "computeTb";
            this.computeTb.Size = new System.Drawing.Size(79, 22);
            this.computeTb.TabIndex = 2;
            this.computeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computeUerNumber
            // 
            this.computeUerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeUerNumber.Location = new System.Drawing.Point(548, 80);
            this.computeUerNumber.Name = "computeUerNumber";
            this.computeUerNumber.Size = new System.Drawing.Size(182, 55);
            this.computeUerNumber.TabIndex = 3;
            this.computeUerNumber.Text = "Compute Fibonaccci \r\nfor your number";
            this.computeUerNumber.UseVisualStyleBackColor = true;
            this.computeUerNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // xmlToJsonBtn
            // 
            this.xmlToJsonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlToJsonBtn.Location = new System.Drawing.Point(325, 281);
            this.xmlToJsonBtn.Name = "xmlToJsonBtn";
            this.xmlToJsonBtn.Size = new System.Drawing.Size(145, 47);
            this.xmlToJsonBtn.TabIndex = 5;
            this.xmlToJsonBtn.Text = "XML TO JSON";
            this.xmlToJsonBtn.UseVisualStyleBackColor = true;
            this.xmlToJsonBtn.Click += new System.EventHandler(this.xmlToJsonBtn_Click);
            // 
            // xmlTb
            // 
            this.xmlTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlTb.Location = new System.Drawing.Point(36, 188);
            this.xmlTb.Multiline = true;
            this.xmlTb.Name = "xmlTb";
            this.xmlTb.Size = new System.Drawing.Size(250, 250);
            this.xmlTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Put XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Get JSON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Number : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(514, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 250);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 241);
            this.textBox1.TabIndex = 12;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(4, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(240, 238);
            this.webBrowser1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xmlToJsonBtn);
            this.Controls.Add(this.xmlTb);
            this.Controls.Add(this.computeUerNumber);
            this.Controls.Add(this.computeTb);
            this.Controls.Add(this.directComputeBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci APP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directComputeBtn;
        private System.Windows.Forms.TextBox computeTb;
        private System.Windows.Forms.Button computeUerNumber;
        private System.Windows.Forms.Button xmlToJsonBtn;
        private System.Windows.Forms.TextBox xmlTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

