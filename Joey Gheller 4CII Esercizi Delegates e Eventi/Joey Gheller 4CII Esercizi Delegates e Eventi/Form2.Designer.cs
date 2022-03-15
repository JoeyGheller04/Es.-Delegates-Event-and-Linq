
namespace Joey_Gheller_4CII_Esercizi_Delegates_e_Eventi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbcognome = new System.Windows.Forms.TextBox();
            this.txbnoem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGETCLIENT = new System.Windows.Forms.Button();
            this.txbindirizzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbImporto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVers = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txbSaldo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txbSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbcognome
            // 
            this.txbcognome.Location = new System.Drawing.Point(198, 142);
            this.txbcognome.Name = "txbcognome";
            this.txbcognome.Size = new System.Drawing.Size(120, 20);
            this.txbcognome.TabIndex = 24;
            this.txbcognome.Text = "Moccia";
            // 
            // txbnoem
            // 
            this.txbnoem.Location = new System.Drawing.Point(198, 119);
            this.txbnoem.Name = "txbnoem";
            this.txbnoem.Size = new System.Drawing.Size(120, 20);
            this.txbnoem.TabIndex = 23;
            this.txbnoem.Text = "Dario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome";
            // 
            // btnGETCLIENT
            // 
            this.btnGETCLIENT.Location = new System.Drawing.Point(339, 129);
            this.btnGETCLIENT.Name = "btnGETCLIENT";
            this.btnGETCLIENT.Size = new System.Drawing.Size(77, 44);
            this.btnGETCLIENT.TabIndex = 20;
            this.btnGETCLIENT.Text = "Nuovo Cliente";
            this.btnGETCLIENT.UseVisualStyleBackColor = true;
            this.btnGETCLIENT.Click += new System.EventHandler(this.btnGETCLIENT_Click);
            // 
            // txbindirizzo
            // 
            this.txbindirizzo.Location = new System.Drawing.Point(198, 168);
            this.txbindirizzo.Name = "txbindirizzo";
            this.txbindirizzo.Size = new System.Drawing.Size(120, 20);
            this.txbindirizzo.TabIndex = 26;
            this.txbindirizzo.Text = "Collesalvetti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Indirizzo";
            // 
            // txbImporto
            // 
            this.txbImporto.Location = new System.Drawing.Point(198, 269);
            this.txbImporto.Name = "txbImporto";
            this.txbImporto.Size = new System.Drawing.Size(120, 20);
            this.txbImporto.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Importo";
            // 
            // btnVers
            // 
            this.btnVers.Location = new System.Drawing.Point(339, 238);
            this.btnVers.Name = "btnVers";
            this.btnVers.Size = new System.Drawing.Size(123, 44);
            this.btnVers.TabIndex = 29;
            this.btnVers.Text = "Versamento";
            this.btnVers.UseVisualStyleBackColor = true;
            this.btnVers.Click += new System.EventHandler(this.btnVers_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(339, 288);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(123, 44);
            this.btnPrev.TabIndex = 30;
            this.btnPrev.Text = "Prelevamento";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Saldo Disponibile";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(422, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 44);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txbSaldo
            // 
            this.txbSaldo.Location = new System.Drawing.Point(252, 388);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(120, 20);
            this.txbSaldo.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnVers);
            this.Controls.Add(this.txbImporto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbindirizzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbcognome);
            this.Controls.Add(this.txbnoem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGETCLIENT);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.txbSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbcognome;
        private System.Windows.Forms.TextBox txbnoem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGETCLIENT;
        private System.Windows.Forms.TextBox txbindirizzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbImporto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVers;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown txbSaldo;
    }
}