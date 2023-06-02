using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmUser : Form
    {
        BLL_Pitch bll_Pitch = new BLL_Pitch();
        DTO_Pitch dto_Pitch = new DTO_Pitch();
        List<Button> buttons = new List<Button>();
        public frmUser()
        {
            InitializeComponent();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            txtFullName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtCategory.Enabled = false;
            txtPitchName.Enabled = false;
            txtTotalPrice.Enabled = false;

            txtFullName.Text = frmLogin.dto_User.FullName;
            txtPhoneNumber.Text = frmLogin.dto_User.PhoneNumber;

            dtpDate.MinDate = DateTime.Today;
            dtpDate.MaxDate = DateTime.Today.AddDays(7);

            for (int i = 5; i < 21; i++)
            {
                cmbTime.Items.Add($"{i}h - {i + 1}h");
            }
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.SelectedIndex = 0;

            flpPitches.AutoScroll = true;

            foreach(DTO_Pitch dto_Pitch in bll_Pitch.getPitchList())
            {
                buttons.Add(new Button() { Text = $"{dto_Pitch.PitchName}", Width = 60, Height = 60 });
            }
            foreach (Button b in buttons)
            {
                b.Text += "\n\n";
                flpPitches.Controls.Add(b);
                CheckStatus(b);
                b.Click += new EventHandler(btn_Click);
            }

            btnBook.Enabled = false;
            btnCancelPitch.Enabled = false;
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtPitchName.Clear();
            txtCategory.Clear();
            txtTotalPrice.Clear();
            btnBook.Enabled = false;
            foreach (Button b in buttons)
            {
                CheckStatus(b);
            }
        }
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPitchName.Clear();
            txtCategory.Clear();
            txtTotalPrice.Clear();
            btnBook.Enabled = false;
            foreach (Button b in buttons)
            {
                CheckStatus(b);
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            string[] split = (sender as Button).Text.Split('\n');
            dto_Pitch.PitchName = split[0];

            dto_Pitch = bll_Pitch.getPrice(dto_Pitch);

            txtPitchName.Text = dto_Pitch.PitchName;
            txtCategory.Text = dto_Pitch.Category;
            txtTotalPrice.Text = dto_Pitch.Price.ToString("N0") + "VNĐ";
            if ((sender as Button).BackColor == Color.LightGreen)
            {
                btnBook.Enabled = true;
                btnCancelPitch.Enabled = false;
            }
            else
            {
                btnBook.Enabled = false;
                btnCancelPitch.Enabled = true;
            }
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            bll_Pitch.Order(frmLogin.dto_User, dto_Pitch);
            txtPitchName.Clear();
            txtCategory.Clear();
            txtTotalPrice.Clear();
            foreach (Button b in buttons)
            {
                CheckStatus(b);
            }
            MessageBox.Show("Booked!");
            btnBook.Enabled = false;
        }
        private void btnCancelPitch_Click(object sender, EventArgs e)
        {
            bll_Pitch.Cancel(frmLogin.dto_User, dto_Pitch);
            txtPitchName.Clear();
            txtCategory.Clear();
            txtTotalPrice.Clear();
            foreach (Button b in buttons)
            {
                CheckStatus(b);
            }
            MessageBox.Show("Canceled!");
            btnCancelPitch.Enabled = false;
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            this.Hide();
            frmProfile.ShowDialog();
            this.Show();
            txtFullName.Text = frmLogin.dto_User.FullName;
            txtPhoneNumber.Text = frmLogin.dto_User.PhoneNumber;
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void CheckStatus(Button b)
        {
            string[] split = b.Text.Split('\n');

            dto_Pitch.PitchName = split[0];
            dto_Pitch.Time = int.Parse(cmbTime.SelectedIndex.ToString()) + 5;
            dto_Pitch.Date = dtpDate.Value.Date;

            dto_Pitch = bll_Pitch.getStatus(dto_Pitch);
            if (dtpDate.Value.Date == dtpDate.MinDate && cmbTime.SelectedIndex + 5 <= DateTime.Now.TimeOfDay.Hours)
            {
                b.Text = split[0] + "\n\n";
                b.Enabled = false;
                b.BackColor = Color.Gray;
            }
            else
            {
                if (dto_Pitch.Status == true)
                {
                    if (dto_Pitch.Booker == frmLogin.dto_User.Username)
                    {
                        split[2] = "Booked";
                        b.Enabled = true;
                        b.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        split[2] = "Booked";
                        b.Enabled = false;
                        b.BackColor = Color.Red;
                    }
                }
                else
                {
                    split[2] = "Empty";
                    b.Enabled = true;
                    b.BackColor = Color.LightGreen;
                }
                b.Text = split[0] + "\n\n" + split[2];
            }
        }
    }
}
