
namespace Joey_Gheller_4CII_Esercizi_Delegates_e_Eventi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbN2 = new System.Windows.Forms.NumericUpDown();
            this.txbN1 = new System.Windows.Forms.NumericUpDown();
            this.btnMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnicast = new System.Windows.Forms.Button();
            this.btnMulticast = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGET = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(50, 47);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(120, 20);
            this.txbN2.TabIndex = 13;
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(50, 24);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(120, 20);
            this.txbN1.TabIndex = 12;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(12, 140);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(158, 23);
            this.btnMessage.TabIndex = 11;
            this.btnMessage.Text = "Messaggio";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Num 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Num 1";
            // 
            // btnUnicast
            // 
            this.btnUnicast.Location = new System.Drawing.Point(12, 82);
            this.btnUnicast.Name = "btnUnicast";
            this.btnUnicast.Size = new System.Drawing.Size(158, 23);
            this.btnUnicast.TabIndex = 7;
            this.btnUnicast.Text = "Unicast";
            this.btnUnicast.UseVisualStyleBackColor = true;
            this.btnUnicast.Click += new System.EventHandler(this.btnUnicast_Click);
            // 
            // btnMulticast
            // 
            this.btnMulticast.Location = new System.Drawing.Point(12, 111);
            this.btnMulticast.Name = "btnMulticast";
            this.btnMulticast.Size = new System.Drawing.Size(158, 23);
            this.btnMulticast.TabIndex = 8;
            this.btnMulticast.Text = "Multicast";
            this.btnMulticast.UseVisualStyleBackColor = true;
            this.btnMulticast.Click += new System.EventHandler(this.btnMulticast_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 105);
            this.button1.TabIndex = 14;
            this.button1.Text = "Esercizio 6 eventi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Eta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome";
            // 
            // btnGET
            // 
            this.btnGET.Location = new System.Drawing.Point(540, 80);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(158, 23);
            this.btnGET.TabIndex = 15;
            this.btnGET.Text = "Persona";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(578, 21);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(120, 20);
            this.txb1.TabIndex = 18;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(578, 44);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(120, 20);
            this.txb2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnicast);
            this.Controls.Add(this.btnMulticast);
            this.Name = "Form1";
            this.Text = "Esercizio 4";
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txbN2;
        private System.Windows.Forms.NumericUpDown txbN1;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnicast;
        private System.Windows.Forms.Button btnMulticast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
    }
}

