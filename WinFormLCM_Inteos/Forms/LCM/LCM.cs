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
using WinFormLCM_Inteos.Forms.LCM;

namespace WinFormLCM_Inteos
{
    public partial class LCM : Form
    {

        //Repositories
        readonly LCMTypenRepo lcmtypenRepository = new LCMTypenRepo();
        readonly PruefeinheitenRepo pruefeinheitenRepo = new PruefeinheitenRepo();
        readonly PruefmerkmalenRepo pruefmerkmalenRepo = new PruefmerkmalenRepo();

        //UI elements
        int selectedTabIndex = 0;
        int selectedDataGridIndex = -1;

        public LCM()
        {
            InitializeComponent();

        }

        #region Event Handlers Buttons
        private void createBtn_Click(object sender, EventArgs e)
        { 
            switch (selectedTabIndex)
            {
                case 0:
                    LCMTypDialog dialog0 = new LCMTypDialog(lcmtypenRepository, pruefeinheitenRepo, pruefmerkmalenRepo);
                    dialog0.RecordSaved += Dialog_RecordSaved;
                    dialog0.ShowDialog();
                    break;
                case 1:
                    PruefeinheitDialog dialog1 = new PruefeinheitDialog(pruefeinheitenRepo);
                    dialog1.RecordSaved += Dialog_RecordSaved;
                    dialog1.ShowDialog();
                    break;
                case 2:
                    var pruefeinheitenList = pruefeinheitenRepo.GetAll();
                    PruefmerkmalDialog dialog2 = new PruefmerkmalDialog(pruefmerkmalenRepo);
                    dialog2.RecordSaved += Dialog_RecordSaved;
                    dialog2.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataGridIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie einen Datensatz aus.");
                return;
            }

            switch (selectedTabIndex)
            {
                case 0:
                    int lcmTypId = (int)LCMTypenDataGridVw.CurrentRow.Cells["Id"].Value;
                    LCMTypDialog dialog0 = new LCMTypDialog(lcmtypenRepository, pruefeinheitenRepo, pruefmerkmalenRepo, lcmTypId);
                    dialog0.RecordSaved += Dialog_RecordSaved;
                    dialog0.ShowDialog();
                    break;
                case 1:
                    PruefeinheitDialog dialog = new PruefeinheitDialog(pruefeinheitenRepo, (Pruefeinheit)PruefeinheitDataGridVw.CurrentRow.DataBoundItem);
                    dialog.RecordSaved += Dialog_RecordSaved;
                    dialog.ShowDialog();
                    break;
                case 2:
                    int pruefmerkmalId = (int)PruefmerkmalDataGridVw.CurrentRow.Cells["Id"].Value;
                    PruefmerkmalDialog dialog2 = new PruefmerkmalDialog(pruefmerkmalenRepo, pruefmerkmalId);
                    dialog2.RecordSaved += Dialog_RecordSaved;
                    dialog2.ShowDialog();

                    break;
                default:
                    break;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (selectedDataGridIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie einen Datensatz aus.");
                return;
            }
            switch (selectedTabIndex)
            {
                case 0:
                    int lcmTypId = (int)LCMTypenDataGridVw.CurrentRow.Cells["Id"].Value;
                    lcmtypenRepository.Delete(lcmTypId);
                    break;
                case 1:
                    int pruefeinheitId = (int)PruefeinheitDataGridVw.CurrentRow.Cells["Id"].Value;
                    pruefeinheitenRepo.Delete(pruefeinheitId);
                    break;
                case 2:
                    int pruefmerkmalId = (int)PruefmerkmalDataGridVw.CurrentRow.Cells["Id"].Value;
                    pruefmerkmalenRepo.Delete(pruefmerkmalId);
                    break;
                default:
                    break;
            }
            LoadDataForSelectedTab();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            switch (selectedTabIndex)
            {
                case 0:
                    LCMTypenDataGridVw.DataSource = lcmtypenRepository.Search(searchTxb.Text);
                    break;
                case 1:
                    PruefeinheitDataGridVw.DataSource = pruefeinheitenRepo.Search(searchTxb.Text);
                    break;
                case 2:
                    PruefmerkmalDataGridVw.DataSource = pruefmerkmalenRepo.Search(searchTxb.Text);
                    break;
                default:
                    break;
            }
            ClearFields();
        }

        #endregion Event Handlers Buttons

        #region Event Handlers DataGridViews
        private void PruefeinheitDataGridVw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDataGridIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PruefeinheitDataGridVw.Rows[e.RowIndex];
                BezeichnungTxb.Text = row.Cells["Bezeichnung"].Value.ToString();
                SymbolTxb.Text = row.Cells["Symbol"].Value.ToString();
            }
        }

        private void PruefmerkmalDataGridVw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDataGridIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PruefmerkmalDataGridVw.Rows[e.RowIndex];
                PruefmethodeTxb.Text = row.Cells["Pruefmethode"].Value.ToString();
                VerknuepfungTxb.Text = row.Cells["Verknuepfung"].Value.ToString();
                AnweisungenTxb.Text = row.Cells["Anweisungen"].Value.ToString();
            }

        }

        private void LCMTypenDataGridVw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDataGridIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.LCMTypenDataGridVw.Rows[e.RowIndex];
                TypBeschreibungTxb.Text = row.Cells["TypBeschreibung"].Value.ToString();
                BemerkungInternTxb.Text = row.Cells["BemerkungIntern"].Value.ToString();
                PruefeinheitCmb0.Text = row.Cells["PruefeinheitName"].Value.ToString();
                PruefmethodeCmb.Text = row.Cells["PruefmethodeName"].Value.ToString();
            }
        }

        #endregion Event Handlers DataGridViews

        #region Event Handlers Other
        private void LCM_Load(object sender, EventArgs e)
        {
            LoadDataForSelectedTab();
            selectedDataGridIndex = -1;
        }

        private void Dialog_RecordSaved(object sender, EventArgs e)
        {
            LoadDataForSelectedTab();
        }


        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTabIndex = tab.SelectedIndex;
            selectedDataGridIndex = -1;
            searchTxb.Text = "";    
            LoadDataForSelectedTab();
        }
        #endregion Event Handlers Other 

        #region Custom Methods
        private void LoadDataForSelectedTab()
        {
            selectedDataGridIndex = 0;
            searchTxb.Text = "";
            ClearFields();

            switch (selectedTabIndex)
            {
                case 0: //LCMTypen
                    LCMTypenDataGridVw.DataSource = lcmtypenRepository.GetAll();
                    break;
                case 1: //Prüfeinheiten
                    PruefeinheitDataGridVw.DataSource = pruefeinheitenRepo.GetAll();
                    break;
                case 2: //Prüfmerkmale
                    PruefmerkmalDataGridVw.DataSource = pruefmerkmalenRepo.GetAll();
                    break;
                default:
                    break;
            }
        }

        private void ClearFields()
        {
            switch (selectedTabIndex)
            {
                case 0:
                    TypBeschreibungTxb.Text = "";
                    BemerkungInternTxb.Text = "";
                    PruefeinheitCmb0.SelectedIndex = -1;
                    PruefeinheitCmb0.Text = "";
                    PruefmethodeCmb.SelectedIndex = -1;
                    PruefmethodeCmb.Text = "";
                    break;
                case 1:
                    BezeichnungTxb.Text = "";
                    SymbolTxb.Text = "";
                    break;
                case 2:
                    PruefmethodeTxb.Text = "";
                    VerknuepfungTxb.Text = "";
                    AnweisungenTxb.Text = "";
                    break;
                default:
                    break;
            }
        }


        #endregion Custom Methods


    }

}
