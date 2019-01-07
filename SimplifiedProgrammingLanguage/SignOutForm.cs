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
    /// <summary>
    /// Class SignOutForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SignOutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignOutForm"/> class.
        /// </summary>
        public SignOutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Submitbtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void Submitbtn_Click(object sender, EventArgs e)
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

        private void SignOutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
