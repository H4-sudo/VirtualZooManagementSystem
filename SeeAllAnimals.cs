using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class SeeAllAnimals : UserControl
    {
        public SeeAllAnimals()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalsTableAdapter.FillBy(this.animalsDataSet.animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
