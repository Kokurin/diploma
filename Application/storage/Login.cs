using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage
{
    public partial class Login : Form
    {
        //private SqlConnection SqlConnection = null;
        public Login()
        {
            InitializeComponent();
        }




        private void Login_Load(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Василий\Documents\GitHub\diploma\Application\storage\db.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand("Select * from [db].[users]");
            conn.Open();
            
            conn.Close();

        }
    }
}
