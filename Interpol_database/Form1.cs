using Interpol_database._Interpol_2_0DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol_database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Interpol_2_0DataSet.Archive' table. You can move, or remove it, as needed.
            this.archiveTableAdapter.Fill(this._Interpol_2_0DataSet.Archive);
            // TODO: This line of code loads data into the '_Interpol_2_0DataSet.Gang' table. You can move, or remove it, as needed.
            this.gangTableAdapter.Fill(this._Interpol_2_0DataSet.Gang);
            // TODO: This line of code loads data into the '_Interpol_2_0DataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this._Interpol_2_0DataSet.Member);

        }

        private void dataGridView_Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            memberTableAdapter.Update(_Interpol_2_0DataSet);
            gangTableAdapter.Update(_Interpol_2_0DataSet);
            archiveTableAdapter.Update(_Interpol_2_0DataSet);
        }
    }
}
