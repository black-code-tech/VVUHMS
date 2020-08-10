namespace VVUHMS.Forms.UserControls
{
    partial class AdminPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.AdminBodyPanel = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAllDrugs = new System.Windows.Forms.Button();
            this.btnSearchRecords = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.MenuIconPanel = new System.Windows.Forms.Panel();
            this.picLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.HandlePanel = new System.Windows.Forms.Panel();
            this.picMenuBtn = new System.Windows.Forms.PictureBox();
            this.logoTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.SideMenuTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.SideMenu.SuspendLayout();
            this.MenuIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.HandlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminBodyPanel
            // 
            this.SideMenuTransition.SetDecoration(this.AdminBodyPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.AdminBodyPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.AdminBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminBodyPanel.Location = new System.Drawing.Point(55, 0);
            this.AdminBodyPanel.Name = "AdminBodyPanel";
            this.AdminBodyPanel.Size = new System.Drawing.Size(845, 510);
            this.AdminBodyPanel.TabIndex = 5;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.SideMenu.Controls.Add(this.btnProfile);
            this.SideMenu.Controls.Add(this.btnAddStaff);
            this.SideMenu.Controls.Add(this.btnAllDrugs);
            this.SideMenu.Controls.Add(this.btnSearchRecords);
            this.SideMenu.Controls.Add(this.btnSignOut);
            this.SideMenu.Controls.Add(this.MenuIconPanel);
            this.SideMenu.Controls.Add(this.HandlePanel);
            this.SideMenuTransition.SetDecoration(this.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(10);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(55, 510);
            this.SideMenu.TabIndex = 4;
            // 
            // btnProfile
            // 
            this.logoTransition.SetDecoration(this.btnProfile, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.btnProfile, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 250);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(5);
            this.btnProfile.Size = new System.Drawing.Size(55, 40);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "          My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddStaff
            // 
            this.logoTransition.SetDecoration(this.btnAddStaff, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.btnAddStaff, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(0, 210);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddStaff.Size = new System.Drawing.Size(55, 40);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "          Add New Staff";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnAllDrugs
            // 
            this.logoTransition.SetDecoration(this.btnAllDrugs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.btnAllDrugs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAllDrugs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllDrugs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnAllDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllDrugs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllDrugs.Image = ((System.Drawing.Image)(resources.GetObject("btnAllDrugs.Image")));
            this.btnAllDrugs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllDrugs.Location = new System.Drawing.Point(0, 170);
            this.btnAllDrugs.Name = "btnAllDrugs";
            this.btnAllDrugs.Padding = new System.Windows.Forms.Padding(5);
            this.btnAllDrugs.Size = new System.Drawing.Size(55, 40);
            this.btnAllDrugs.TabIndex = 14;
            this.btnAllDrugs.Text = "          All Drugs Available";
            this.btnAllDrugs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllDrugs.UseVisualStyleBackColor = true;
            this.btnAllDrugs.Click += new System.EventHandler(this.btnAllDrugs_Click);
            // 
            // btnSearchRecords
            // 
            this.logoTransition.SetDecoration(this.btnSearchRecords, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.btnSearchRecords, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSearchRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSearchRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRecords.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRecords.Image")));
            this.btnSearchRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRecords.Location = new System.Drawing.Point(0, 130);
            this.btnSearchRecords.Name = "btnSearchRecords";
            this.btnSearchRecords.Padding = new System.Windows.Forms.Padding(5);
            this.btnSearchRecords.Size = new System.Drawing.Size(55, 40);
            this.btnSearchRecords.TabIndex = 13;
            this.btnSearchRecords.Text = "          Search Staff/Patient";
            this.btnSearchRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRecords.UseVisualStyleBackColor = true;
            this.btnSearchRecords.Click += new System.EventHandler(this.btnSearchRecords_Click);
            // 
            // btnSignOut
            // 
            this.logoTransition.SetDecoration(this.btnSignOut, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.btnSignOut, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 470);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(10);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(5);
            this.btnSignOut.Size = new System.Drawing.Size(55, 40);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "          Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // MenuIconPanel
            // 
            this.MenuIconPanel.Controls.Add(this.picLogo);
            this.SideMenuTransition.SetDecoration(this.MenuIconPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.MenuIconPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MenuIconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuIconPanel.Location = new System.Drawing.Point(0, 30);
            this.MenuIconPanel.Name = "MenuIconPanel";
            this.MenuIconPanel.Size = new System.Drawing.Size(55, 100);
            this.MenuIconPanel.TabIndex = 9;
            // 
            // picLogo
            // 
            this.picLogo.AllowFocused = false;
            this.picLogo.BorderRadius = 0;
            this.SideMenuTransition.SetDecoration(this.picLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.picLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.IsCircle = false;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(55, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // HandlePanel
            // 
            this.HandlePanel.Controls.Add(this.picMenuBtn);
            this.SideMenuTransition.SetDecoration(this.HandlePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.HandlePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.HandlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HandlePanel.Location = new System.Drawing.Point(0, 0);
            this.HandlePanel.Name = "HandlePanel";
            this.HandlePanel.Size = new System.Drawing.Size(55, 30);
            this.HandlePanel.TabIndex = 8;
            // 
            // picMenuBtn
            // 
            this.picMenuBtn.BackColor = System.Drawing.Color.White;
            this.picMenuBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoTransition.SetDecoration(this.picMenuBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this.picMenuBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.picMenuBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("picMenuBtn.Image")));
            this.picMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.picMenuBtn.Name = "picMenuBtn";
            this.picMenuBtn.Size = new System.Drawing.Size(55, 30);
            this.picMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuBtn.TabIndex = 0;
            this.picMenuBtn.TabStop = false;
            this.picMenuBtn.Click += new System.EventHandler(this.picMenuBtn_Click);
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation2;
            // 
            // SideMenuTransition
            // 
            this.SideMenuTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.SideMenuTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.SideMenuTransition.DefaultAnimation = animation1;
            // 
            // AdminPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AdminBodyPanel);
            this.Controls.Add(this.SideMenu);
            this.logoTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(900, 510);
            this.SideMenu.ResumeLayout(false);
            this.MenuIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.HandlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminBodyPanel;
        private Bunifu.UI.WinForms.BunifuTransition SideMenuTransition;
        private Bunifu.UI.WinForms.BunifuTransition logoTransition;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAllDrugs;
        private System.Windows.Forms.Button btnSearchRecords;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel MenuIconPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox picLogo;
        private System.Windows.Forms.Panel HandlePanel;
        private System.Windows.Forms.PictureBox picMenuBtn;
    }
}
