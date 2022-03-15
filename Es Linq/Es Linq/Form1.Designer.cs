
namespace Es_Linq
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.RichTextBox();
            this.txb2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb4 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Get1 = new System.Windows.Forms.Button();
            this.Get2 = new System.Windows.Forms.Button();
            this.Get3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome e Cognome";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(15, 25);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(192, 169);
            this.txb1.TabIndex = 1;
            this.txb1.Text = "";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(216, 25);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(192, 169);
            this.txb2.TabIndex = 3;
            this.txb2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eleco insegnanti che iniziano con  a o c";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(443, 25);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(192, 169);
            this.txb3.TabIndex = 5;
            this.txb3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome e Cognome <16 lettere";
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(660, 25);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(192, 169);
            this.txb4.TabIndex = 7;
            this.txb4.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome e Cognome <14 lettere";
            // 
            // Get1
            // 
            this.Get1.Location = new System.Drawing.Point(216, 200);
            this.Get1.Name = "Get1";
            this.Get1.Size = new System.Drawing.Size(192, 23);
            this.Get1.TabIndex = 8;
            this.Get1.Text = "Get";
            this.Get1.UseVisualStyleBackColor = true;
            this.Get1.Click += new System.EventHandler(this.Get1_Click);
            // 
            // Get2
            // 
            this.Get2.Location = new System.Drawing.Point(443, 200);
            this.Get2.Name = "Get2";
            this.Get2.Size = new System.Drawing.Size(192, 23);
            this.Get2.TabIndex = 9;
            this.Get2.Text = "Get";
            this.Get2.UseVisualStyleBackColor = true;
            this.Get2.Click += new System.EventHandler(this.Get2_Click);
            // 
            // Get3
            // 
            this.Get3.Location = new System.Drawing.Point(660, 200);
            this.Get3.Name = "Get3";
            this.Get3.Size = new System.Drawing.Size(192, 23);
            this.Get3.TabIndex = 10;
            this.Get3.Text = "Get";
            this.Get3.UseVisualStyleBackColor = true;
            this.Get3.Click += new System.EventHandler(this.Get3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.Get3);
            this.Controls.Add(this.Get2);
            this.Controls.Add(this.Get1);
            this.Controls.Add(this.txb4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txb1;
        private System.Windows.Forms.RichTextBox txb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Get1;
        private System.Windows.Forms.Button Get2;
        private System.Windows.Forms.Button Get3;
    }
}

