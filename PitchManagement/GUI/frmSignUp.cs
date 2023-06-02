using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmSignUp : Form
    {
        public static BLL_User bll_User = new BLL_User();
        public static DTO_User dto_User = new DTO_User();
        public frmSignUp()
        {
            InitializeComponent();
        }
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFullName.Text) && !String.IsNullOrEmpty(txtPhoneNumber.Text) && !String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && !String.IsNullOrEmpty(txtConfirm.Text))
            {
                if(Regex.IsMatch(txtUserName.Text, @"^[a-zA-Z0-9]+$"))
                {
                    if(Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9 ]+$"))
                    {
                        if (Regex.IsMatch(txtFullName.Text, @"^[a-zA-Z ]+$"))
                        {
                            if (Regex.IsMatch(txtPhoneNumber.Text, @"^[0-9]+$") && txtPhoneNumber.Text.Length == 10)
                            {
                                dto_User.FullName = txtFullName.Text;
                                dto_User.PhoneNumber = txtPhoneNumber.Text;
                                dto_User.Username = txtUserName.Text;
                                dto_User.Password = txtPassword.Text;

                                dto_User = bll_User.getUser(dto_User);
                                if (dto_User.IsUser)
                                {
                                    MessageBox.Show("User name already used!");
                                }
                                else
                                {
                                    if (txtPassword.Text == txtConfirm.Text)
                                    {
                                        dto_User.IsAdmin = false;
                                        bll_User.AddUser(dto_User);
                                        MessageBox.Show("Account create successfully!");
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Confirm password is not correct!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Phone number can only contain number and 10 number long!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Full name can only contain letters and space!");
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
        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
