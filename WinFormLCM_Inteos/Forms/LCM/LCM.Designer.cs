namespace WinFormLCM_Inteos
{
    partial class LCM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCM));
            this.tab = new System.Windows.Forms.TabControl();
            this.tab0 = new System.Windows.Forms.TabPage();
            this.PruefmethodeCmb = new System.Windows.Forms.ComboBox();
            this.PruefeinheitCmb0 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BemerkungInternTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypBeschreibungTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LCMTypenDataGridVw = new System.Windows.Forms.DataGridView();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.SymbolTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BezeichnungTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PruefeinheitDataGridVw = new System.Windows.Forms.DataGridView();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.AnweisungenTxb = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VerknuepfungTxb = new System.Windows.Forms.TextBox();
            this.PruefmethodeTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PruefmerkmalDataGridVw = new System.Windows.Forms.DataGridView();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.editBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCMTypenDataGridVw)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PruefeinheitDataGridVw)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PruefmerkmalDataGridVw)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab0);
            this.tab.Controls.Add(this.tab1);
            this.tab.Controls.Add(this.tab2);
            this.tab.Location = new System.Drawing.Point(6, 65);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(753, 469);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.PruefmethodeCmb);
            this.tab0.Controls.Add(this.PruefeinheitCmb0);
            this.tab0.Controls.Add(this.label9);
            this.tab0.Controls.Add(this.label8);
            this.tab0.Controls.Add(this.BemerkungInternTxb);
            this.tab0.Controls.Add(this.label7);
            this.tab0.Controls.Add(this.TypBeschreibungTxb);
            this.tab0.Controls.Add(this.label6);
            this.tab0.Controls.Add(this.LCMTypenDataGridVw);
            this.tab0.Location = new System.Drawing.Point(4, 22);
            this.tab0.Margin = new System.Windows.Forms.Padding(2);
            this.tab0.Name = "tab0";
            this.tab0.Padding = new System.Windows.Forms.Padding(2);
            this.tab0.Size = new System.Drawing.Size(745, 443);
            this.tab0.TabIndex = 1;
            this.tab0.Text = "LCM Typen";
            this.tab0.UseVisualStyleBackColor = true;
            // 
            // PruefmethodeCmb
            // 
            this.PruefmethodeCmb.Enabled = false;
            this.PruefmethodeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PruefmethodeCmb.FormattingEnabled = true;
            this.PruefmethodeCmb.Location = new System.Drawing.Point(428, 365);
            this.PruefmethodeCmb.Name = "PruefmethodeCmb";
            this.PruefmethodeCmb.Size = new System.Drawing.Size(296, 30);
            this.PruefmethodeCmb.TabIndex = 11;
            // 
            // PruefeinheitCmb0
            // 
            this.PruefeinheitCmb0.Enabled = false;
            this.PruefeinheitCmb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PruefeinheitCmb0.FormattingEnabled = true;
            this.PruefeinheitCmb0.Location = new System.Drawing.Point(428, 292);
            this.PruefeinheitCmb0.Name = "PruefeinheitCmb0";
            this.PruefeinheitCmb0.Size = new System.Drawing.Size(296, 30);
            this.PruefeinheitCmb0.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(424, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Prüfmethode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(424, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prüfeinheit";
            // 
            // BemerkungInternTxb
            // 
            this.BemerkungInternTxb.Enabled = false;
            this.BemerkungInternTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemerkungInternTxb.Location = new System.Drawing.Point(32, 364);
            this.BemerkungInternTxb.Margin = new System.Windows.Forms.Padding(2);
            this.BemerkungInternTxb.Name = "BemerkungInternTxb";
            this.BemerkungInternTxb.Size = new System.Drawing.Size(346, 28);
            this.BemerkungInternTxb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(28, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bemerkung Intern";
            // 
            // TypBeschreibungTxb
            // 
            this.TypBeschreibungTxb.Enabled = false;
            this.TypBeschreibungTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypBeschreibungTxb.Location = new System.Drawing.Point(32, 292);
            this.TypBeschreibungTxb.Margin = new System.Windows.Forms.Padding(2);
            this.TypBeschreibungTxb.Name = "TypBeschreibungTxb";
            this.TypBeschreibungTxb.Size = new System.Drawing.Size(346, 28);
            this.TypBeschreibungTxb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(28, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Typ Beschreibung";
            // 
            // LCMTypenDataGridVw
            // 
            this.LCMTypenDataGridVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LCMTypenDataGridVw.Location = new System.Drawing.Point(4, 5);
            this.LCMTypenDataGridVw.Margin = new System.Windows.Forms.Padding(2);
            this.LCMTypenDataGridVw.Name = "LCMTypenDataGridVw";
            this.LCMTypenDataGridVw.RowHeadersWidth = 51;
            this.LCMTypenDataGridVw.RowTemplate.Height = 24;
            this.LCMTypenDataGridVw.Size = new System.Drawing.Size(738, 214);
            this.LCMTypenDataGridVw.TabIndex = 0;
            this.LCMTypenDataGridVw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LCMTypenDataGridVw_CellClick);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.SymbolTxb);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.BezeichnungTxb);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.PruefeinheitDataGridVw);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Margin = new System.Windows.Forms.Padding(2);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(2);
            this.tab1.Size = new System.Drawing.Size(745, 443);
            this.tab1.TabIndex = 3;
            this.tab1.Text = "Prüfeinheiten";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // SymbolTxb
            // 
            this.SymbolTxb.Enabled = false;
            this.SymbolTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolTxb.Location = new System.Drawing.Point(30, 288);
            this.SymbolTxb.Margin = new System.Windows.Forms.Padding(2);
            this.SymbolTxb.Name = "SymbolTxb";
            this.SymbolTxb.Size = new System.Drawing.Size(138, 28);
            this.SymbolTxb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Symbol";
            // 
            // BezeichnungTxb
            // 
            this.BezeichnungTxb.Enabled = false;
            this.BezeichnungTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BezeichnungTxb.Location = new System.Drawing.Point(30, 364);
            this.BezeichnungTxb.Margin = new System.Windows.Forms.Padding(2);
            this.BezeichnungTxb.Name = "BezeichnungTxb";
            this.BezeichnungTxb.Size = new System.Drawing.Size(296, 28);
            this.BezeichnungTxb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bezeichnung";
            // 
            // PruefeinheitDataGridVw
            // 
            this.PruefeinheitDataGridVw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PruefeinheitDataGridVw.CausesValidation = false;
            this.PruefeinheitDataGridVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PruefeinheitDataGridVw.Location = new System.Drawing.Point(4, 5);
            this.PruefeinheitDataGridVw.Margin = new System.Windows.Forms.Padding(2);
            this.PruefeinheitDataGridVw.Name = "PruefeinheitDataGridVw";
            this.PruefeinheitDataGridVw.ReadOnly = true;
            this.PruefeinheitDataGridVw.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PruefeinheitDataGridVw.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PruefeinheitDataGridVw.RowTemplate.Height = 24;
            this.PruefeinheitDataGridVw.Size = new System.Drawing.Size(738, 214);
            this.PruefeinheitDataGridVw.TabIndex = 0;
            this.PruefeinheitDataGridVw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PruefeinheitDataGridVw_CellClick);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.AnweisungenTxb);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.VerknuepfungTxb);
            this.tab2.Controls.Add(this.PruefmethodeTxb);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.PruefmerkmalDataGridVw);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Margin = new System.Windows.Forms.Padding(2);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(2);
            this.tab2.Size = new System.Drawing.Size(745, 443);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Prüfmerkmale";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // AnweisungenTxb
            // 
            this.AnweisungenTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnweisungenTxb.Enabled = false;
            this.AnweisungenTxb.Location = new System.Drawing.Point(372, 292);
            this.AnweisungenTxb.Name = "AnweisungenTxb";
            this.AnweisungenTxb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnweisungenTxb.Size = new System.Drawing.Size(340, 98);
            this.AnweisungenTxb.TabIndex = 11;
            this.AnweisungenTxb.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Anweisungen";
            // 
            // VerknuepfungTxb
            // 
            this.VerknuepfungTxb.Enabled = false;
            this.VerknuepfungTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerknuepfungTxb.Location = new System.Drawing.Point(32, 364);
            this.VerknuepfungTxb.Margin = new System.Windows.Forms.Padding(2);
            this.VerknuepfungTxb.Name = "VerknuepfungTxb";
            this.VerknuepfungTxb.Size = new System.Drawing.Size(296, 28);
            this.VerknuepfungTxb.TabIndex = 9;
            // 
            // PruefmethodeTxb
            // 
            this.PruefmethodeTxb.Enabled = false;
            this.PruefmethodeTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PruefmethodeTxb.Location = new System.Drawing.Point(32, 292);
            this.PruefmethodeTxb.Margin = new System.Windows.Forms.Padding(2);
            this.PruefmethodeTxb.Name = "PruefmethodeTxb";
            this.PruefmethodeTxb.Size = new System.Drawing.Size(296, 28);
            this.PruefmethodeTxb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prüfmethode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Verknüpfung";
            // 
            // PruefmerkmalDataGridVw
            // 
            this.PruefmerkmalDataGridVw.AllowUserToAddRows = false;
            this.PruefmerkmalDataGridVw.AllowUserToDeleteRows = false;
            this.PruefmerkmalDataGridVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PruefmerkmalDataGridVw.Location = new System.Drawing.Point(3, 5);
            this.PruefmerkmalDataGridVw.Margin = new System.Windows.Forms.Padding(2);
            this.PruefmerkmalDataGridVw.Name = "PruefmerkmalDataGridVw";
            this.PruefmerkmalDataGridVw.ReadOnly = true;
            this.PruefmerkmalDataGridVw.RowHeadersWidth = 51;
            this.PruefmerkmalDataGridVw.RowTemplate.Height = 24;
            this.PruefmerkmalDataGridVw.Size = new System.Drawing.Size(738, 214);
            this.PruefmerkmalDataGridVw.TabIndex = 1;
            this.PruefmerkmalDataGridVw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PruefmerkmalDataGridVw_CellClick);
            // 
            // searchTxb
            // 
            this.searchTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxb.Location = new System.Drawing.Point(8, 15);
            this.searchTxb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxb.Name = "searchTxb";
            this.searchTxb.Size = new System.Drawing.Size(148, 30);
            this.searchTxb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Universalsuche";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 545);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::WinFormLCM_Inteos.Properties.Resources.icons8_create_80;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Location = new System.Drawing.Point(280, 10);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(34, 39);
            this.editBtn.TabIndex = 7;
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackgroundImage = global::WinFormLCM_Inteos.Properties.Resources.icons8_page_80;
            this.createBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBtn.Location = new System.Drawing.Point(242, 10);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(34, 39);
            this.createBtn.TabIndex = 6;
            this.createBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = global::WinFormLCM_Inteos.Properties.Resources.icons8_search_50;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(160, 15);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(34, 29);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Location = new System.Drawing.Point(320, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(34, 39);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // LCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 545);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTxb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LCM";
            this.Text = "LCM";
            this.Load += new System.EventHandler(this.LCM_Load);
            this.tab.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            this.tab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCMTypenDataGridVw)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PruefeinheitDataGridVw)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PruefmerkmalDataGridVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab0;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridView LCMTypenDataGridVw;
        private System.Windows.Forms.DataGridView PruefeinheitDataGridVw;
        private System.Windows.Forms.DataGridView PruefmerkmalDataGridVw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BezeichnungTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SymbolTxb;
        private System.Windows.Forms.TextBox PruefmethodeTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BemerkungInternTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TypBeschreibungTxb;
        private System.Windows.Forms.ComboBox PruefmethodeCmb;
        private System.Windows.Forms.ComboBox PruefeinheitCmb0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VerknuepfungTxb;
        private System.Windows.Forms.RichTextBox AnweisungenTxb;
        private System.Windows.Forms.Label label10;
    }
}