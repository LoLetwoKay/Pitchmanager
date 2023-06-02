using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmForgot : Form
    {
        public static BLL_User bll_User = new BLL_User();
        public static DTO_User dto_User = new DTO_User();
        public frmForgot()
        {
            InitializeComponent();
        }
        private void frmForgot_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && !String.IsNullOrEmpty(txtConfirm.Text))
            {
                if(Regex.IsMatch(txtUserName.Text, @"^[a-zA-Z0-9]+$"))
                {
                    if(Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9 ]+$") && Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9 ]+$"))
                    {
                        if (txtPassword.Text == txtConfirm.Text)
                        {
                            dto_User.Username = txtUserName.Text;
                            dto_User.Password = txtPassword.Text;

                            dto_User = bll_User.getUser(dto_User);
                            if (dto_User.IsUser)
                            {
                                bll_User.UpdateUser(dto_User);
                                MessageBox.Show("Password has changed!");
                            }
                            else
                            {
                                MessageBox.Show("Account not found!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirm password is not correct!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password can only contain letters, space and numbers!");
                    }
                }
                else
                {
                    MessageBox.Show("Username can only contain letters and numbers!");
                }
            }
            else
            {
                MessageBox.Show("Fill all the above informations!");
            }
        }
    }
}
