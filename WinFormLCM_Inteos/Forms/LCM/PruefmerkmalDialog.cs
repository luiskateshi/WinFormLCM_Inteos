using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLCM_Inteos.Data;
using WinFormLCM_Inteos.Entities;

namespace WinFormLCM_Inteos.Forms.LCM
{
    public partial class PruefmerkmalDialog: Form
    {
        private readonly PruefmerkmalenRepo pruefmerkmalenRepo;
        private readonly Pruefmerkmal pruefmerkmal;
        public event EventHandler RecordSaved;
        private string OldFileName;

        //create Constructor
        public PruefmerkmalDialog(PruefmerkmalenRepo pruefmerkmalenRepo)
        {
            InitializeComponent();
            this.pruefmerkmalenRepo = pruefmerkmalenRepo;
            OldFileName = VerknuepfungTxb.Text;
        }

        //edit Constructor
        public PruefmerkmalDialog(PruefmerkmalenRepo pruefmerkmalenRepo, int PruefmerkmalId)
        {
            InitializeComponent();
            this.pruefmerkmalenRepo = pruefmerkmalenRepo;
            pruefmerkmal = pruefmerkmalenRepo.GetById(PruefmerkmalId);
            PruefmethodeTxb.Text = pruefmerkmal.Pruefmethode;
            VerknuepfungTxb.Text = pruefmerkmal.Verknuepfung;
            AnweisungenTxb.Text = pruefmerkmal.Anweisungen;
            OldFileName = VerknuepfungTxb.Text;
        }

        private void speicherBtn_Click(object sender, EventArgs e)
        {
            if (pruefmerkmal == null)
            {
                Pruefmerkmal pruefmerkmal = new Pruefmerkmal
                {
                    Pruefmethode = PruefmethodeTxb.Text,
                    Verknuepfung = VerknuepfungTxb.Text,
                    Anweisungen = AnweisungenTxb.Text
                };
                pruefmerkmalenRepo.Insert(pruefmerkmal);
            }
            else
            {
                pruefmerkmal.Pruefmethode = PruefmethodeTxb.Text;
                pruefmerkmal.Verknuepfung = VerknuepfungTxb.Text;
                pruefmerkmal.Anweisungen = AnweisungenTxb.Text;
                pruefmerkmalenRepo.Update(pruefmerkmal);
            }

            removeFile(OldFileName);//remove current file from filesystem

            RecordSaved?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName; 
                    string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName; // Go to project root
                    string uploadFolder = Path.Combine(projectPath, "db", "Uploads"); 
                    string fileName = Path.GetFileName(sourcePath); 

                    string destinationPath = Path.Combine(uploadFolder, fileName);
                    File.Copy(sourcePath, destinationPath, true);

                    VerknuepfungTxb.Text = fileName;
                }
            }
        }

        private void removeFile(string fileName)
        {
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string fullPath = Path.Combine(projectPath, "db", "Uploads", fileName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(VerknuepfungTxb.Text))
            {
                MessageBox.Show("Keine Datei gewählt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string relativePath = Path.Combine("db","Uploads",VerknuepfungTxb.Text);

            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string fullPath = Path.Combine(projectPath, relativePath);

            if (File.Exists(fullPath))
            {
                System.Diagnostics.Process.Start(fullPath); 
            }
            else
            {
                MessageBox.Show("Datei wurde nicht gefunden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
