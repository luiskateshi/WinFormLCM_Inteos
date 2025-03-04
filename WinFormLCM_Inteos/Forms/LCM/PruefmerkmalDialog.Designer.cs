namespace WinFormLCM_Inteos.Forms.LCM
{
    partial class PruefmerkmalDialog
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
            this.PruefmethodeTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speicherBtn = new System.Windows.Forms.Button();
            this.VerknuepfungTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AnweisungenTxb = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.uploadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PruefmethodeTxb
            // 
            this.PruefmethodeTxb.Location = new System.Drawing.Point(57, 58);
            this.PruefmethodeTxb.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.PruefmethodeTxb.Name = "PruefmethodeTxb";
            this.PruefmethodeTxb.Size = new System.Drawing.Size(282, 28);
            this.PruefmethodeTxb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prüfmethode";
            // 
            // speicherBtn
            // 
            this.speicherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speicherBtn.Location = new System.Drawing.Point(168, 372);
            this.speicherBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.speicherBtn.Name = "speicherBtn";
            this.speicherBtn.Size = new System.Drawing.Size(163, 39);
            this.speicherBtn.TabIndex = 5;
            this.speicherBtn.Text = "Speichern";
            this.speicherBtn.UseVisualStyleBackColor = true;
            this.speicherBtn.Click += new System.EventHandler(this.speicherBtn_Click);
            // 
            // VerknuepfungTxb
            // 
            this.VerknuepfungTxb.Enabled = false;
            this.VerknuepfungTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerknuepfungTxb.Location = new System.Drawing.Point(57, 142);
            this.VerknuepfungTxb.Margin = new System.Windows.Forms.Padding(2);
            this.VerknuepfungTxb.Name = "VerknuepfungTxb";
            this.VerknuepfungTxb.Size = new System.Drawing.Size(282, 28);
            this.VerknuepfungTxb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verknüpfung";
            // 
            // AnweisungenTxb
            // 
            this.AnweisungenTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnweisungenTxb.Location = new System.Drawing.Point(57, 232);
            this.AnweisungenTxb.Name = "AnweisungenTxb";
            this.AnweisungenTxb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnweisungenTxb.Size = new System.Drawing.Size(390, 130);
            this.AnweisungenTxb.TabIndex = 13;
            this.AnweisungenTxb.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Anweisungen";
            // 
            // openFile
            // 
            this.openFile.BackgroundImage = global::WinFormLCM_Inteos.Properties.Resources.icons8_open_64;
            this.openFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFile.Location = new System.Drawing.Point(397, 133);
            this.openFile.Name = "openFile";
            this.openFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openFile.Size = new System.Drawing.Size(50, 46);
            this.openFile.TabIndex = 15;
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // uploadFile
            // 
            this.uploadFile.BackgroundImage = global::WinFormLCM_Inteos.Properties.Resources.icons8_upload_64;
            this.uploadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadFile.Location = new System.Drawing.Point(344, 133);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uploadFile.Size = new System.Drawing.Size(47, 46);
            this.uploadFile.TabIndex = 14;
            this.uploadFile.UseVisualStyleBackColor = true;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PruefmerkmalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 438);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.uploadFile);
            this.Controls.Add(this.AnweisungenTxb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VerknuepfungTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PruefmethodeTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speicherBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PruefmerkmalDialog";
            this.Text = "PruefmerkmalDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PruefmethodeTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button speicherBtn;
        private System.Windows.Forms.TextBox VerknuepfungTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox AnweisungenTxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}