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
    public partial class frmAdmin : Form
    {
        BLL_Pitch bll_Pitch = new BLL_Pitch();
        BLL_TimeAndPrice bll_TimeAndPrice = new BLL_TimeAndPrice();
        DTO_Pitch dto_Pitch = new DTO_Pitch();
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            cmbCategory_Add.Items.Add("5 people");
            cmbCategory_Add.Items.Add("7 people");
            cmbCategory_Add.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPitchName_Update.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCategory_Update.Items.Add("5 people");
            cmbCategory_Update.Items.Add("7 people");
            cmbCategory_Update.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPitchName_Delete.DropDownStyle = ComboBoxStyle.DropDownList;
            
            ShowPitchName();

            txtSecondHourFrame.Enabled = false;

            cmbHourFrame.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 6; i < 21; i++)
            {
                cmbHourFrame.Items.Add("5h - " + i + "h");
            }

            dtpDate.MinDate = DateTime.Today;
            dtpDate.MaxDate = DateTime.Today.AddDays(7);

            for (int i = 5; i < 21; i++)
            {
                cmbTime.Items.Add($"{i}h -> {i + 1}h");
            }
            cmbTime.SelectedIndex = 0;

            lsvPitch.View = View.Details;
            lsvPitch.GridLines = true;
            lsvPitch.FullRowSelect = true;
            lsvPitch.Columns.Add("Pitch name", 65);
            lsvPitch.Columns.Add("Category", 55);
            lsvPitch.Columns.Add("Price", 80);
            lsvPitch.Columns.Add("Status", 50);
            lsvPitch.Columns.Add("Booker", 100);
        }
        private void btnAddPitch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPitchName_Add.Text) && cmbCategory_Add.SelectedIndex >= 0)
            {
                if(Regex.IsMatch(txtPitchName_Add.Text, @"^[a-zA-Z0-9 ]+$"))
                {
                    bool Exist = false;

                    foreach (DTO_Pitch dto_Pitch in bll_Pitch.getPitchList())
                    {
                        if (dto_Pitch.PitchName == txtPitchName_Add.Text)
                        {
                            Exist = true;
                        }
                    }
                    if (!Exist)
                    {
                        dto_Pitch.PitchName = txtPitchName_Add.Text;
                        dto_Pitch.Category = cmbCategory_Add.Text;

                        bll_Pitch.AddPitch(dto_Pitch);
                        MessageBox.Show("Added!");
                        txtPitchName_Add.Clear();
                        cmbCategory_Add.SelectedIndex = -1;
                        ShowPitchName();
                        ShowPitchList();
                    }
                    else
                    {
                        MessageBox.Show("Pitch name is already used!");
                    }
                }
                else
                {
                    MessageBox.Show("Pitch name can only contain letters, space and numbers!");
                }
            }
            else
            {
                MessageBox.Show("Fill all the above informations!");
            }
        }
        private void btnUpdatePitch_Click(object sender, EventArgs e)
        {
            if (cmbPitchName_Update.SelectedIndex >= 0 && !String.IsNullOrEmpty(txtNewPitchName.Text) && cmbCategory_Update.SelectedIndex >= 0)
            {
                if (Regex.IsMatch(txtNewPitchName.Text, @"^[a-zA-Z0-9 ]+$"))
                {
                    bool Exist = false;

                    foreach (DTO_Pitch dto_Pitch in bll_Pitch.getPitchList())
                    {
                        if (dto_Pitch.PitchName == txtNewPitchName.Text)
                        {
                            Exist = true;
                        }

                    }
                    if (!Exist)
                    {
                        dto_Pitch.PitchName = cmbPitchName_Update.Text;
                        dto_Pitch.Category = cmbCategory_Update.Text;

                        bll_Pitch.UpdatePitch(dto_Pitch, txtNewPitchName.Text);
                        MessageBox.Show("Updated!");
                        ShowPitchName();
                        ShowPitchList();
                    }
                    else
                    {
                        MessageBox.Show("Pitch name already used!");
                    }
                }
                else
                {
                    MessageBox.Show("Pitch name can only contain letters, space and numbers!");
                }
            }
            else
            {
                MessageBox.Show("Fill all the above informations!");
            }
        }
        private void btnDeletePitch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbPitchName_Delete.Text))
            {
                dto_Pitch.PitchName = cmbPitchName_Delete.Text;

                bll_Pitch.DeletePitch(dto_Pitch);
                MessageBox.Show("Deleted!");
                ShowPitchName();
                ShowPitchList();
            }
            else
            {
                MessageBox.Show("Fill all the above informations!");
            }
        }
        private void cmbHourFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cmbHourFrame.Text))
            {
                string[] split = cmbHourFrame.Text.Split(' ');
                txtSecondHourFrame.Text = $"Second time slot: {split[2]} -> 21h";
            }
        }
        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cmbHourFrame.Text) && !String.IsNullOrEmpty(txtSecondHourFrame.Text) && !String.IsNullOrEmpty(txtFirst5PeoplePrice.Text) && !String.IsNullOrEmpty(txtFirst7PeoplePrice.Text) && !String.IsNullOrEmpty(txtSecond5PeoplePrice.Text) && !String.IsNullOrEmpty(txtSecond7PeoplePrice.Text))
            {
                if(Regex.IsMatch(txtFirst5PeoplePrice.Text, @"^[0-9]+$") && Regex.IsMatch(txtSecond5PeoplePrice.Text, @"^[0-9]+$") && Regex.IsMatch(txtFirst7PeoplePrice.Text, @"^[0-9]+$") && Regex.IsMatch(txtSecond7PeoplePrice.Text, @"^[0-9]+$"))
                {
                    bll_TimeAndPrice.UpdateTime(int.Parse(cmbHourFrame.SelectedIndex.ToString()) + 6);
                    bll_TimeAndPrice.UpdatePrice(decimal.Parse(txtFirst5PeoplePrice.Text), decimal.Parse(txtSecond5PeoplePrice.Text), decimal.Parse(txtFirst7PeoplePrice.Text), decimal.Parse(txtSecond7PeoplePrice.Text));
                    MessageBox.Show("Updated!");
                    cmbHourFrame.SelectedIndex = -1;
                    txtSecondHourFrame.Clear();
                    txtFirst5PeoplePrice.Clear();
                    txtFirst7PeoplePrice.Clear();
                    txtSecond5PeoplePrice.Clear();
                    txtSecond7PeoplePrice.Clear();
                    ShowPitchList();
                }
                else
                {
                    MessageBox.Show("Price can only contain number!");
                }
            }
            else
            {
                MessageBox.Show("Fill all the above informations!");
            }
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowPitchList();
        }
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPitchList();
        }
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            frmRevenue frmRevenue = new frmRevenue();
            this.Hide();
            frmRevenue.ShowDialog();
            this.Show();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            this.Hide();
            frmProfile.ShowDialog();
            this.Show();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ShowPitchName()
        {
            cmbPitchName_Update.Items.Clear();
            cmbPitchName_Delete.Items.Clear();
            foreach (DTO_Pitch dto_Pitch in bll_Pitch.getPitchList())
            {
                cmbPitchName_Update.Items.Add(dto_Pitch.PitchName);
                cmbPitchName_Delete.Items.Add(dto_Pitch.PitchName);
            }
            cmbPitchName_Update.SelectedIndex = -1;
            txtNewPitchName.Clear();
            cmbCategory_Update.SelectedIndex = -1;
            cmbPitchName_Delete.SelectedIndex = -1;
        }
        private void ShowPitchList()
        {
            lsvPitch.Items.Clear();
            foreach (DTO_Pitch dto_Pitch in bll_Pitch.getPitchList())
            {
                dto_Pitch.Time = int.Parse(cmbTime.SelectedIndex.ToString()) + 5;
                dto_Pitch.Date = dtpDate.Value.Date;

                bll_Pitch.getStatus(dto_Pitch);
                bll_Pitch.getPrice(dto_Pitch);

                ListViewItem item = lsvPitch.Items.Add(dto_Pitch.PitchName);
                item.SubItems.Add(dto_Pitch.Category);
                item.SubItems.Add(dto_Pitch.Price.ToString("N0") + "VNĐ");
                if(dto_Pitch.Status)
                {
                    item.SubItems.Add("Booked");
                    item.SubItems.Add(dto_Pitch.Booker);
                }
                else
                {
                    item.SubItems.Add("Empty");
                    item.SubItems.Add("None");
                }
            }
        }
    }
}
