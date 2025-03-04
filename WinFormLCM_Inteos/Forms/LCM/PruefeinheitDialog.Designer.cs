namespace WinFormLCM_Inteos.Forms.LCM
{
    partial class PruefeinheitDialog
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
            this.speicherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BezeichnungTxb = new System.Windows.Forms.TextBox();
            this.SymbolTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // speicherBtn
            // 
            this.speicherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speicherBtn.Location = new System.Drawing.Point(106, 171);
            this.speicherBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speicherBtn.Name = "speicherBtn";
            this.speicherBtn.Size = new System.Drawing.Size(130, 35);
            this.speicherBtn.TabIndex = 0;
            this.speicherBtn.Text = "Speichern";
            this.speicherBtn.UseVisualStyleBackColor = true;
            this.speicherBtn.Click += new System.EventHandler(this.speicherBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bezeichnung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbol";
            // 
            // BezeichnungTxb
            // 
            this.BezeichnungTxb.Location = new System.Drawing.Point(34, 49);
            this.BezeichnungTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BezeichnungTxb.Name = "BezeichnungTxb";
            this.BezeichnungTxb.Size = new System.Drawing.Size(301, 28);
            this.BezeichnungTxb.TabIndex = 3;
            // 
            // SymbolTxb
            // 
            this.SymbolTxb.Location = new System.Drawing.Point(34, 125);
            this.SymbolTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SymbolTxb.Name = "SymbolTxb";
            this.SymbolTxb.Size = new System.Drawing.Size(301, 28);
            this.SymbolTxb.TabIndex = 4;
            // 
            // PruefeinheitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 218);
            this.Controls.Add(this.SymbolTxb);
            this.Controls.Add(this.BezeichnungTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speicherBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PruefeinheitDialog";
            this.Text = "Prüfeinheit Dialog";
            this.Load += new System.EventHandler(this.PruefeinheitDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speicherBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BezeichnungTxb;
        private System.Windows.Forms.TextBox SymbolTxb;
    }
}