using AibelDeelineInterface.Aibel_Deeline;
using AibelDeelineInterface.Common;
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
    public partial class NewReleaseFrm : Form
    {
        public NewReleaseFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveCOs(lstAllCOs, lstSelectedCOs);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveCOs(lstSelectedCOs, lstAllCOs);
        }

        private void MoveCOs(ListBox source, ListBox target)
        {
            var item = source.SelectedItem;
            if (item != null)
            {
                target.Items.Add(item);
                source.Items.Remove(item);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            using (var repos = new COReleaseRepository(new AibelDeelineDbContext()))
            {
                Enum.TryParse<PriorityEnum>(cmbPriority.SelectedItem as string, out var enumVal);
                var release = new CORelease(Mediator.CurrentUser, Mediator.CurrentLocation, enumVal, lstSelectedCOs.Items.OfType<string>().ToArray());
                repos.Add(release);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
