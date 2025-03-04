using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLCM_Inteos.Data;
using WinFormLCM_Inteos.Entities;

namespace WinFormLCM_Inteos.Forms.LCM
{
    public partial class PruefeinheitDialog: Form
    {

        private readonly PruefeinheitenRepo repo;
        private Pruefeinheit pruefeinheit;
        public event EventHandler RecordSaved;

        //Constructor for create mode
        public PruefeinheitDialog(PruefeinheitenRepo repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        //Constructor for edit mode
        public PruefeinheitDialog(PruefeinheitenRepo repo, Pruefeinheit pruefeinheit)
        {
            InitializeComponent();
            this.repo = repo;
            this.pruefeinheit = pruefeinheit;
            BezeichnungTxb.Text = pruefeinheit.Bezeichnung;
            SymbolTxb.Text = pruefeinheit.Symbol;
        }



        private void PruefeinheitDialog_Load(object sender, EventArgs e)
        {

        }

        private void speicherBtn_Click(object sender, EventArgs e)
        {
            if (pruefeinheit == null)
            {
                pruefeinheit = new Pruefeinheit();
                pruefeinheit.Bezeichnung = BezeichnungTxb.Text;
                pruefeinheit.Symbol = SymbolTxb.Text;
                repo.Insert(pruefeinheit);
            }
            else
            {
                pruefeinheit.Bezeichnung = BezeichnungTxb.Text;
                pruefeinheit.Symbol = SymbolTxb.Text;
                repo.Update(pruefeinheit);
            }

            RecordSaved?.Invoke(this, EventArgs.Empty);
            this.Close();
    }
    }
}
