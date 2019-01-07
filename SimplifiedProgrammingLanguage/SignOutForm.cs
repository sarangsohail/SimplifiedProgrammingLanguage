using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    public partial class SignOutForm : Form
    {
        public SignOutForm()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtName.Text;
            password = txtPass.Text;

            if(username == "username" && password == ("password"))
            {
                MessageBox.Show("Access Granted");
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }
    }
}
