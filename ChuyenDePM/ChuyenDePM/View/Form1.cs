using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDePM
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
            lb_Test.Text = con.ToString();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_Test_Click(object sender, EventArgs e)
        {

        }

    }
}
