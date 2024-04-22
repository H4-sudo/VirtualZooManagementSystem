using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace VirtualZooManagementSystem
{
    public partial class VirtualZooMangementSystem : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=H4Z3Y_\JEFFY;Initial Catalog=animals;Integrated Security=True;Trust Server Certificate=True");

        public VirtualZooMangementSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
