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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtFullName.Text = frmLogin.dto_User.FullName;
            txtPhoneNumber.Text = frmLogin.dto_User.PhoneNumber;
            txtPassword.Text = frmLogin.dto_User.Password;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtFullName.Text) && !String.IsNullOrEmpty(txtPhoneNumber.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                if (Regex.IsMatch(txtFullName.Text, @"^[a-zA-Z ]+$"))
                {
                    if(Regex.IsMatch(txtPhoneNumber.Text, @"^[0-9]+$") && txtPhoneNumber.Text.Length == 10)
                    {
                        if(Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9 ]+$"))
                        {
                            frmLogin.dto_User.FullName = txtFullName.Text;
                            frmLogin.dto_User.PhoneNumber = txtPhoneNumber.Text;
                            frmLogin.dto_User.Password = txtPassword.Text;

                            frmLogin.bll_User.UpdateUser(frmLogin.dto_User);
                            MessageBox.Show("Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Password can only contain letters, space and numbers!");
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
                MessageBox.Show("Fill all the above informations!");
            }
        }
    }
}
