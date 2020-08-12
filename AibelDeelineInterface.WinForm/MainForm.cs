using AibelDeelineInterface.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AibelDeelineInterface.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aibelDeelineDbDataSet.Communications' table. You can move, or remove it, as needed.
            this.communicationsTableAdapter.Fill(this.aibelDeelineDbDataSet.Communications);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new NewReleaseFrm();
            frm.ShowDialog();
            frm.FormClosed += (_, __) => this.communicationsTableAdapter.Update(this.aibelDeelineDbDataSet.Communications);
        }
    }
}
