namespace WinFormLCM_Inteos.Forms.LCM
{
    partial class LCMTypDialog
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
            this.PruefmethodeCmb = new System.Windows.Forms.ComboBox();
            this.PruefeinheitCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BemerkungInternTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypBeschreibungTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.speicherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PruefmethodeCmb
            // 
            this.PruefmethodeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PruefmethodeCmb.FormattingEnabled = true;
            this.PruefmethodeCmb.Location = new System.Drawing.Point(38, 269);
            this.PruefmethodeCmb.Name = "PruefmethodeCmb";
            this.PruefmethodeCmb.Size = new System.Drawing.Size(309, 30);
            this.PruefmethodeCmb.TabIndex = 19;
            // 
            // PruefeinheitCmb
            // 
            this.PruefeinheitCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PruefeinheitCmb.FormattingEnabled = true;
            this.PruefeinheitCmb.Location = new System.Drawing.Point(38, 196);
            this.PruefeinheitCmb.Name = "PruefeinheitCmb";
            this.PruefeinheitCmb.Size = new System.Drawing.Size(309, 30);
            this.PruefeinheitCmb.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(34, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Prüfmethode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(34, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Prüfeinheit";
            // 
            // BemerkungInternTxb
            // 
            this.BemerkungInternTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemerkungInternTxb.Location = new System.Drawing.Point(38, 126);
            this.BemerkungInternTxb.Margin = new System.Windows.Forms.Padding(2);
            this.BemerkungInternTxb.Name = "BemerkungInternTxb";
            this.BemerkungInternTxb.Size = new System.Drawing.Size(309, 28);
            this.BemerkungInternTxb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(34, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bemerkung Intern";
            // 
            // TypBeschreibungTxb
            // 
            this.TypBeschreibungTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypBeschreibungTxb.Location = new System.Drawing.Point(38, 54);
            this.TypBeschreibungTxb.Margin = new System.Windows.Forms.Padding(2);
            this.TypBeschreibungTxb.Name = "TypBeschreibungTxb";
            this.TypBeschreibungTxb.Size = new System.Drawing.Size(309, 28);
            this.TypBeschreibungTxb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(34, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Typ Beschreibung";
            // 
            // speicherBtn
            // 
            this.speicherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speicherBtn.Location = new System.Drawing.Point(119, 322);
            this.speicherBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speicherBtn.Name = "speicherBtn";
            this.speicherBtn.Size = new System.Drawing.Size(130, 35);
            this.speicherBtn.TabIndex = 20;
            this.speicherBtn.Text = "Speichern";
            this.speicherBtn.UseVisualStyleBackColor = true;
            this.speicherBtn.Click += new System.EventHandler(this.speicherBtn_Click);
            // 
            // LCMTypDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 385);
            this.Controls.Add(this.speicherBtn);
            this.Controls.Add(this.PruefmethodeCmb);
            this.Controls.Add(this.PruefeinheitCmb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BemerkungInternTxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TypBeschreibungTxb);
            this.Controls.Add(this.label6);
            this.Name = "LCMTypDialog";
            this.Text = "LCMTypDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PruefmethodeCmb;
        private System.Windows.Forms.ComboBox PruefeinheitCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BemerkungInternTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TypBeschreibungTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button speicherBtn;
    }
}