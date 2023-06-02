
namespace GUI
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.mnsAdmin = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddPitch = new System.Windows.Forms.GroupBox();
            this.txtPitchName_Add = new System.Windows.Forms.TextBox();
            this.lblPitchName_Add = new System.Windows.Forms.Label();
            this.cmbCategory_Add = new System.Windows.Forms.ComboBox();
            this.lblCategory_Add = new System.Windows.Forms.Label();
            this.btnAddPitch = new System.Windows.Forms.Button();
            this.grpUpdatePitch = new System.Windows.Forms.GroupBox();
            this.cmbPitchName_Update = new System.Windows.Forms.ComboBox();
            this.lblNewPitchName = new System.Windows.Forms.Label();
            this.txtNewPitchName = new System.Windows.Forms.TextBox();
            this.lblPitchName_Update = new System.Windows.Forms.Label();
            this.btnUpdatePitch = new System.Windows.Forms.Button();
            this.cmbCategory_Update = new System.Windows.Forms.ComboBox();
            this.lblCategory_Update = new System.Windows.Forms.Label();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.lblPitchList = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTIme = new System.Windows.Forms.Label();
            this.lsvPitch = new System.Windows.Forms.ListView();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.grpDeletePitch = new System.Windows.Forms.GroupBox();
            this.cmbPitchName_Delete = new System.Windows.Forms.ComboBox();
            this.lblPitchName_Delete = new System.Windows.Forms.Label();
            this.btnDeletePitch = new System.Windows.Forms.Button();
            this.grpPitch = new System.Windows.Forms.GroupBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecond7PeoplePrice = new System.Windows.Forms.TextBox();
            this.txtSecond5PeoplePrice = new System.Windows.Forms.TextBox();
            this.txtFirst7PeoplePrice = new System.Windows.Forms.TextBox();
            this.txtFirst5PeoplePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondHourFrame = new System.Windows.Forms.TextBox();
            this.cmbHourFrame = new System.Windows.Forms.ComboBox();
            this.lblFirstTimeSlot = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.mnsAdmin.SuspendLayout();
            this.grpAddPitch.SuspendLayout();
            this.grpUpdatePitch.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.grpDeletePitch.SuspendLayout();
            this.grpPitch.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsAdmin
            // 
            this.mnsAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.mnsAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnsAdmin.Name = "mnsAdmin";
            this.mnsAdmin.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnsAdmin.Size = new System.Drawing.Size(1107, 28);
            this.mnsAdmin.TabIndex = 17;
            this.mnsAdmin.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // grpAddPitch
            // 
            this.grpAddPitch.Controls.Add(this.txtPitchName_Add);
            this.grpAddPitch.Controls.Add(this.lblPitchName_Add);
            this.grpAddPitch.Controls.Add(this.cmbCategory_Add);
            this.grpAddPitch.Controls.Add(this.lblCategory_Add);
            this.grpAddPitch.Controls.Add(this.btnAddPitch);
            this.grpAddPitch.Location = new System.Drawing.Point(6, 21);
            this.grpAddPitch.Name = "grpAddPitch";
            this.grpAddPitch.Size = new System.Drawing.Size(373, 79);
            this.grpAddPitch.TabIndex = 18;
            this.grpAddPitch.TabStop = false;
            this.grpAddPitch.Text = "Add";
            // 
            // txtPitchName_Add
            // 
            this.txtPitchName_Add.Location = new System.Drawing.Point(124, 21);
            this.txtPitchName_Add.Name = "txtPitchName_Add";
            this.txtPitchName_Add.Size = new System.Drawing.Size(162, 22);
            this.txtPitchName_Add.TabIndex = 20;
            // 
            // lblPitchName_Add
            // 
            this.lblPitchName_Add.AutoSize = true;
            this.lblPitchName_Add.Location = new System.Drawing.Point(6, 24);
            this.lblPitchName_Add.Name = "lblPitchName_Add";
            this.lblPitchName_Add.Size = new System.Drawing.Size(73, 16);
            this.lblPitchName_Add.TabIndex = 0;
            this.lblPitchName_Add.Text = "Pitch name";
            // 
            // cmbCategory_Add
            // 
            this.cmbCategory_Add.FormattingEnabled = true;
            this.cmbCategory_Add.Location = new System.Drawing.Point(124, 49);
            this.cmbCategory_Add.Name = "cmbCategory_Add";
            this.cmbCategory_Add.Size = new System.Drawing.Size(162, 24);
            this.cmbCategory_Add.TabIndex = 0;
            // 
            // lblCategory_Add
            // 
            this.lblCategory_Add.AutoSize = true;
            this.lblCategory_Add.Location = new System.Drawing.Point(6, 52);
            this.lblCategory_Add.Name = "lblCategory_Add";
            this.lblCategory_Add.Size = new System.Drawing.Size(62, 16);
            this.lblCategory_Add.TabIndex = 1;
            this.lblCategory_Add.Text = "Category";
            // 
            // btnAddPitch
            // 
            this.btnAddPitch.Location = new System.Drawing.Point(292, 32);
            this.btnAddPitch.Name = "btnAddPitch";
            this.btnAddPitch.Size = new System.Drawing.Size(75, 26);
            this.btnAddPitch.TabIndex = 21;
            this.btnAddPitch.Text = "Add";
            this.btnAddPitch.UseVisualStyleBackColor = true;
            this.btnAddPitch.Click += new System.EventHandler(this.btnAddPitch_Click);
            // 
            // grpUpdatePitch
            // 
            this.grpUpdatePitch.Controls.Add(this.cmbPitchName_Update);
            this.grpUpdatePitch.Controls.Add(this.lblNewPitchName);
            this.grpUpdatePitch.Controls.Add(this.txtNewPitchName);
            this.grpUpdatePitch.Controls.Add(this.lblPitchName_Update);
            this.grpUpdatePitch.Controls.Add(this.btnUpdatePitch);
            this.grpUpdatePitch.Controls.Add(this.cmbCategory_Update);
            this.grpUpdatePitch.Controls.Add(this.lblCategory_Update);
            this.grpUpdatePitch.Location = new System.Drawing.Point(6, 106);
            this.grpUpdatePitch.Name = "grpUpdatePitch";
            this.grpUpdatePitch.Size = new System.Drawing.Size(373, 107);
            this.grpUpdatePitch.TabIndex = 24;
            this.grpUpdatePitch.TabStop = false;
            this.grpUpdatePitch.Text = "Update";
            // 
            // cmbPitchName_Update
            // 
            this.cmbPitchName_Update.FormattingEnabled = true;
            this.cmbPitchName_Update.Location = new System.Drawing.Point(124, 21);
            this.cmbPitchName_Update.Name = "cmbPitchName_Update";
            this.cmbPitchName_Update.Size = new System.Drawing.Size(162, 24);
            this.cmbPitchName_Update.TabIndex = 29;
            // 
            // lblNewPitchName
            // 
            this.lblNewPitchName.AutoSize = true;
            this.lblNewPitchName.Location = new System.Drawing.Point(6, 52);
            this.lblNewPitchName.Name = "lblNewPitchName";
            this.lblNewPitchName.Size = new System.Drawing.Size(102, 16);
            this.lblNewPitchName.TabIndex = 28;
            this.lblNewPitchName.Text = "New pitch name";
            // 
            // txtNewPitchName
            // 
            this.txtNewPitchName.Location = new System.Drawing.Point(124, 49);
            this.txtNewPitchName.Name = "txtNewPitchName";
            this.txtNewPitchName.Size = new System.Drawing.Size(162, 22);
            this.txtNewPitchName.TabIndex = 27;
            // 
            // lblPitchName_Update
            // 
            this.lblPitchName_Update.AutoSize = true;
            this.lblPitchName_Update.Location = new System.Drawing.Point(6, 24);
            this.lblPitchName_Update.Name = "lblPitchName_Update";
            this.lblPitchName_Update.Size = new System.Drawing.Size(73, 16);
            this.lblPitchName_Update.TabIndex = 22;
            this.lblPitchName_Update.Text = "Pitch name";
            // 
            // btnUpdatePitch
            // 
            this.btnUpdatePitch.Location = new System.Drawing.Point(292, 47);
            this.btnUpdatePitch.Name = "btnUpdatePitch";
            this.btnUpdatePitch.Size = new System.Drawing.Size(75, 26);
            this.btnUpdatePitch.TabIndex = 26;
            this.btnUpdatePitch.Text = "Update";
            this.btnUpdatePitch.UseVisualStyleBackColor = true;
            this.btnUpdatePitch.Click += new System.EventHandler(this.btnUpdatePitch_Click);
            // 
            // cmbCategory_Update
            // 
            this.cmbCategory_Update.FormattingEnabled = true;
            this.cmbCategory_Update.Location = new System.Drawing.Point(124, 77);
            this.cmbCategory_Update.Name = "cmbCategory_Update";
            this.cmbCategory_Update.Size = new System.Drawing.Size(162, 24);
            this.cmbCategory_Update.TabIndex = 23;
            // 
            // lblCategory_Update
            // 
            this.lblCategory_Update.AutoSize = true;
            this.lblCategory_Update.Location = new System.Drawing.Point(6, 80);
            this.lblCategory_Update.Name = "lblCategory_Update";
            this.lblCategory_Update.Size = new System.Drawing.Size(62, 16);
            this.lblCategory_Update.TabIndex = 24;
            this.lblCategory_Update.Text = "Category";
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.btnRevenue);
            this.grpRevenue.Controls.Add(this.lblPitchList);
            this.grpRevenue.Controls.Add(this.dtpDate);
            this.grpRevenue.Controls.Add(this.lblDate);
            this.grpRevenue.Controls.Add(this.lblTIme);
            this.grpRevenue.Controls.Add(this.lsvPitch);
            this.grpRevenue.Controls.Add(this.cmbTime);
            this.grpRevenue.Location = new System.Drawing.Point(700, 31);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Size = new System.Drawing.Size(385, 419);
            this.grpRevenue.TabIndex = 25;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Pitch list";
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(304, 53);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(75, 26);
            this.btnRevenue.TabIndex = 31;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // lblPitchList
            // 
            this.lblPitchList.AutoSize = true;
            this.lblPitchList.Location = new System.Drawing.Point(6, 76);
            this.lblPitchList.Name = "lblPitchList";
            this.lblPitchList.Size = new System.Drawing.Size(62, 16);
            this.lblPitchList.TabIndex = 29;
            this.lblPitchList.Text = "Pitch List:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(51, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(244, 22);
            this.dtpDate.TabIndex = 28;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date";
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Location = new System.Drawing.Point(6, 52);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(38, 16);
            this.lblTIme.TabIndex = 26;
            this.lblTIme.Text = "Time";
            // 
            // lsvPitch
            // 
            this.lsvPitch.HideSelection = false;
            this.lsvPitch.Location = new System.Drawing.Point(6, 96);
            this.lsvPitch.Name = "lsvPitch";
            this.lsvPitch.Size = new System.Drawing.Size(373, 298);
            this.lsvPitch.TabIndex = 25;
            this.lsvPitch.UseCompatibleStateImageBehavior = false;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(51, 49);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(100, 24);
            this.cmbTime.TabIndex = 24;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // grpDeletePitch
            // 
            this.grpDeletePitch.Controls.Add(this.cmbPitchName_Delete);
            this.grpDeletePitch.Controls.Add(this.lblPitchName_Delete);
            this.grpDeletePitch.Controls.Add(this.btnDeletePitch);
            this.grpDeletePitch.Location = new System.Drawing.Point(6, 219);
            this.grpDeletePitch.Name = "grpDeletePitch";
            this.grpDeletePitch.Size = new System.Drawing.Size(373, 51);
            this.grpDeletePitch.TabIndex = 22;
            this.grpDeletePitch.TabStop = false;
            this.grpDeletePitch.Text = "Delete";
            // 
            // cmbPitchName_Delete
            // 
            this.cmbPitchName_Delete.FormattingEnabled = true;
            this.cmbPitchName_Delete.Location = new System.Drawing.Point(124, 21);
            this.cmbPitchName_Delete.Name = "cmbPitchName_Delete";
            this.cmbPitchName_Delete.Size = new System.Drawing.Size(162, 24);
            this.cmbPitchName_Delete.TabIndex = 30;
            // 
            // lblPitchName_Delete
            // 
            this.lblPitchName_Delete.AutoSize = true;
            this.lblPitchName_Delete.Location = new System.Drawing.Point(6, 24);
            this.lblPitchName_Delete.Name = "lblPitchName_Delete";
            this.lblPitchName_Delete.Size = new System.Drawing.Size(73, 16);
            this.lblPitchName_Delete.TabIndex = 0;
            this.lblPitchName_Delete.Text = "Pitch name";
            // 
            // btnDeletePitch
            // 
            this.btnDeletePitch.Location = new System.Drawing.Point(292, 19);
            this.btnDeletePitch.Name = "btnDeletePitch";
            this.btnDeletePitch.Size = new System.Drawing.Size(75, 26);
            this.btnDeletePitch.TabIndex = 21;
            this.btnDeletePitch.Text = "Delete";
            this.btnDeletePitch.UseVisualStyleBackColor = true;
            this.btnDeletePitch.Click += new System.EventHandler(this.btnDeletePitch_Click);
            // 
            // grpPitch
            // 
            this.grpPitch.Controls.Add(this.grpAddPitch);
            this.grpPitch.Controls.Add(this.grpDeletePitch);
            this.grpPitch.Controls.Add(this.grpUpdatePitch);
            this.grpPitch.Location = new System.Drawing.Point(12, 33);
            this.grpPitch.Name = "grpPitch";
            this.grpPitch.Size = new System.Drawing.Size(385, 276);
            this.grpPitch.TabIndex = 26;
            this.grpPitch.TabStop = false;
            this.grpPitch.Text = "Pitch";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.grpUpdate);
            this.grpTime.Location = new System.Drawing.Point(18, 327);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(504, 123);
            this.grpTime.TabIndex = 27;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnUpdateTime);
            this.grpUpdate.Controls.Add(this.label1);
            this.grpUpdate.Controls.Add(this.txtSecond7PeoplePrice);
            this.grpUpdate.Controls.Add(this.txtSecond5PeoplePrice);
            this.grpUpdate.Controls.Add(this.txtFirst7PeoplePrice);
            this.grpUpdate.Controls.Add(this.txtFirst5PeoplePrice);
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Controls.Add(this.txtSecondHourFrame);
            this.grpUpdate.Controls.Add(this.cmbHourFrame);
            this.grpUpdate.Controls.Add(this.lblFirstTimeSlot);
            this.grpUpdate.Location = new System.Drawing.Point(6, 21);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(492, 96);
            this.grpUpdate.TabIndex = 28;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update";
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.Location = new System.Drawing.Point(411, 51);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(75, 26);
            this.btnUpdateTime.TabIndex = 30;
            this.btnUpdateTime.Text = "Update";
            this.btnUpdateTime.UseVisualStyleBackColor = true;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "7 people price";
            // 
            // txtSecond7PeoplePrice
            // 
            this.txtSecond7PeoplePrice.Location = new System.Drawing.Point(310, 68);
            this.txtSecond7PeoplePrice.Name = "txtSecond7PeoplePrice";
            this.txtSecond7PeoplePrice.Size = new System.Drawing.Size(95, 22);
            this.txtSecond7PeoplePrice.TabIndex = 7;
            // 
            // txtSecond5PeoplePrice
            // 
            this.txtSecond5PeoplePrice.Location = new System.Drawing.Point(209, 68);
            this.txtSecond5PeoplePrice.Name = "txtSecond5PeoplePrice";
            this.txtSecond5PeoplePrice.Size = new System.Drawing.Size(95, 22);
            this.txtSecond5PeoplePrice.TabIndex = 6;
            // 
            // txtFirst7PeoplePrice
            // 
            this.txtFirst7PeoplePrice.Location = new System.Drawing.Point(310, 38);
            this.txtFirst7PeoplePrice.Name = "txtFirst7PeoplePrice";
            this.txtFirst7PeoplePrice.Size = new System.Drawing.Size(95, 22);
            this.txtFirst7PeoplePrice.TabIndex = 5;
            // 
            // txtFirst5PeoplePrice
            // 
            this.txtFirst5PeoplePrice.Location = new System.Drawing.Point(209, 38);
            this.txtFirst5PeoplePrice.Name = "txtFirst5PeoplePrice";
            this.txtFirst5PeoplePrice.Size = new System.Drawing.Size(95, 22);
            this.txtFirst5PeoplePrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "5 people price";
            // 
            // txtSecondHourFrame
            // 
            this.txtSecondHourFrame.Location = new System.Drawing.Point(9, 68);
            this.txtSecondHourFrame.Name = "txtSecondHourFrame";
            this.txtSecondHourFrame.Size = new System.Drawing.Size(194, 22);
            this.txtSecondHourFrame.TabIndex = 2;
            // 
            // cmbHourFrame
            // 
            this.cmbHourFrame.FormattingEnabled = true;
            this.cmbHourFrame.Location = new System.Drawing.Point(107, 38);
            this.cmbHourFrame.Name = "cmbHourFrame";
            this.cmbHourFrame.Size = new System.Drawing.Size(96, 24);
            this.cmbHourFrame.TabIndex = 1;
            this.cmbHourFrame.SelectedIndexChanged += new System.EventHandler(this.cmbHourFrame_SelectedIndexChanged);
            // 
            // lblFirstTimeSlot
            // 
            this.lblFirstTimeSlot.AutoSize = true;
            this.lblFirstTimeSlot.Location = new System.Drawing.Point(6, 41);
            this.lblFirstTimeSlot.Name = "lblFirstTimeSlot";
            this.lblFirstTimeSlot.Size = new System.Drawing.Size(87, 16);
            this.lblFirstTimeSlot.TabIndex = 0;
            this.lblFirstTimeSlot.Text = "First time slot:";
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(435, 54);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(239, 181);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 22;
            this.picAdmin.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 539);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpPitch);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.mnsAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.mnsAdmin.ResumeLayout(false);
            this.mnsAdmin.PerformLayout();
            this.grpAddPitch.ResumeLayout(false);
            this.grpAddPitch.PerformLayout();
            this.grpUpdatePitch.ResumeLayout(false);
            this.grpUpdatePitch.PerformLayout();
            this.grpRevenue.ResumeLayout(false);
            this.grpRevenue.PerformLayout();
            this.grpDeletePitch.ResumeLayout(false);
            this.grpDeletePitch.PerformLayout();
            this.grpPitch.ResumeLayout(false);
            this.grpTime.ResumeLayout(false);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAdmin;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpAddPitch;
        private System.Windows.Forms.Label lblCategory_Add;
        private System.Windows.Forms.Label lblPitchName_Add;
        private System.Windows.Forms.Button btnAddPitch;
        private System.Windows.Forms.TextBox txtPitchName_Add;
        private System.Windows.Forms.ComboBox cmbCategory_Add;
        private System.Windows.Forms.GroupBox grpUpdatePitch;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblNewPitchName;
        private System.Windows.Forms.TextBox txtNewPitchName;
        private System.Windows.Forms.Label lblPitchName_Update;
        private System.Windows.Forms.Button btnUpdatePitch;
        private System.Windows.Forms.ComboBox cmbCategory_Update;
        private System.Windows.Forms.Label lblCategory_Update;
        private System.Windows.Forms.GroupBox grpDeletePitch;
        private System.Windows.Forms.Label lblPitchName_Delete;
        private System.Windows.Forms.Button btnDeletePitch;
        private System.Windows.Forms.ListView lsvPitch;
        private System.Windows.Forms.ComboBox cmbPitchName_Update;
        private System.Windows.Forms.Label lblPitchList;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.GroupBox grpPitch;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecond7PeoplePrice;
        private System.Windows.Forms.TextBox txtSecond5PeoplePrice;
        private System.Windows.Forms.TextBox txtFirst7PeoplePrice;
        private System.Windows.Forms.TextBox txtFirst5PeoplePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondHourFrame;
        private System.Windows.Forms.ComboBox cmbHourFrame;
        private System.Windows.Forms.Label lblFirstTimeSlot;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.ComboBox cmbPitchName_Delete;
    }
}