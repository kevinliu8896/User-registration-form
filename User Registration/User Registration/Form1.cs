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

namespace User_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=userregcs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('"+txtFirstName.Text+"', '"+txtLastName.Text+"', '"+txtAddress.Text+"', '"+cmbGender.Text+"', '"+txtEmail.Text+"', '"+txtPhone+"', '"+txtUsername.Text+"', '"+txtPassword+"')", con);
            con.Open(); // open up connection
            cmd.ExecuteNonQuery();
            con.Close(); // close connection
            MessageBox.Show("Registered Succesfully!");

        }
    }
}
