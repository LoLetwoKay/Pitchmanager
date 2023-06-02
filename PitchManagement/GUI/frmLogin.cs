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
using DTO;
using BLL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public static BLL_User bll_User = new BLL_User();
        public static DTO_User dto_User = new DTO_User();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                if(Regex.IsMatch(txtUserName.Text, @"^[a-zA-Z0-9]+$"))
                {
                    if(Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9 ]+$"))
                    {
                        dto_User.Username = txtUserName.Text;
                        dto_User.Password = txtPassword.Text;

                        dto_User = bll_User.getUser(dto_User);
                        if (dto_User.IsUser)
                        {
                            if (dto_User.CorrectPassword)
                            {
                                if (dto_User.IsAdmin)
                                {
                                    frmAdmin formAdmin = new frmAdmin();
                                    this.Hide();
                                    formAdmin.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    frmUser formUser = new frmUser();
                                    this.Hide();
                                    formUser.ShowDialog();
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account not found!");
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
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp form = new frmSignUp();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            frmForgot form = new frmForgot();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
