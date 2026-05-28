using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProbnikk
{
    public partial class EditUserForm : Form
    {
        Users users;
        public EditUserForm(Users users)
        {
            InitializeComponent();
            this .users = users;
            loginTextBox.Text = users.Login;
            passwordTextBox.Text = users.Password;
            
        }        

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
