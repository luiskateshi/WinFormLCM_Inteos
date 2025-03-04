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
    public partial class LCMTypDialog: Form
    {
        private readonly LCMTypenRepo lcmTypenRepo;
        private readonly PruefeinheitenRepo pruefeinheitenRepo;
        private readonly PruefmerkmalenRepo pruefmerkmalenRepo;
        private readonly LCMTyp lcmtyp;
        public event EventHandler RecordSaved;

        //create Constructor
        public LCMTypDialog(LCMTypenRepo lcmTypenRepo, 
                            PruefeinheitenRepo pruefeinheitenRepo, 
                            PruefmerkmalenRepo pruefmerkmalenRepo)
        {
            InitializeComponent();
            this.lcmTypenRepo = lcmTypenRepo;
            this.pruefeinheitenRepo = pruefeinheitenRepo;
            this.pruefmerkmalenRepo = pruefmerkmalenRepo;
            LoadPruefeinheiten();
            LoadPruefmethode();
        }

        //edit Constructor
        public LCMTypDialog(LCMTypenRepo lcmTypenRepo, 
                            PruefeinheitenRepo pruefeinheitenRepo, 
                            PruefmerkmalenRepo pruefmerkmalenRepo,
                            int LcmTypId)
        {
            InitializeComponent();
            this.lcmTypenRepo = lcmTypenRepo;
            this.pruefeinheitenRepo = pruefeinheitenRepo;
            this.pruefmerkmalenRepo = pruefmerkmalenRepo;
            
            LoadPruefeinheiten();
            LoadPruefmethode();
            
            lcmtyp = lcmTypenRepo.GetById(LcmTypId);
            TypBeschreibungTxb.Text = lcmtyp.TypBeschreibung;
            BemerkungInternTxb.Text = lcmtyp.BemerkungIntern;
            PruefeinheitCmb.SelectedValue = lcmtyp.PruefeinheitId;
            PruefmethodeCmb.SelectedValue = lcmtyp.PruefmethodeId;
        }

        private void speicherBtn_Click(object sender, EventArgs e)
        {
            if (lcmtyp == null)
            {
                LCMTyp lcmtyp = new LCMTyp
                {
                    TypBeschreibung = TypBeschreibungTxb.Text,
                    BemerkungIntern = BemerkungInternTxb.Text,
                    PruefeinheitId = (int)PruefeinheitCmb.SelectedValue,
                    PruefmethodeId = (int)PruefmethodeCmb.SelectedValue
                };
                lcmTypenRepo.Insert(lcmtyp);
            }
            else
            {
                lcmtyp.TypBeschreibung = TypBeschreibungTxb.Text;
                lcmtyp.BemerkungIntern = BemerkungInternTxb.Text;
                lcmtyp.PruefeinheitId = (int)PruefeinheitCmb.SelectedValue;
                lcmtyp.PruefmethodeId = (int)PruefmethodeCmb.SelectedValue;
                lcmTypenRepo.Update(lcmtyp);
            }


            RecordSaved?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void LoadPruefeinheiten()
        {
            PruefeinheitCmb.DataSource = pruefeinheitenRepo.GetAll();
            PruefeinheitCmb.DisplayMember = "Bezeichnung";
            PruefeinheitCmb.ValueMember = "Id";
            PruefeinheitCmb.SelectedIndex = -1;
        }
        private void LoadPruefmethode()
        {
            PruefmethodeCmb.DataSource = pruefmerkmalenRepo.GetAll();
            PruefmethodeCmb.DisplayMember = "Pruefmethode";
            PruefmethodeCmb.ValueMember = "Id";
            PruefmethodeCmb.SelectedIndex = -1;
        }
    }
}
