namespace VVUHMS.Forms.UserControls
{
    partial class DoctorPage
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPage));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation4 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.DoctorBodyPanel = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSearchRecords = new System.Windows.Forms.Button();
            this.MenuIconPanel = new System.Windows.Forms.Panel();
            this.picLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.HandlePanel = new System.Windows.Forms.Panel();
            this.picMenuBtn = new System.Windows.Forms.PictureBox();
            this.logoTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.SideMenuTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.btnProfile = new System.Windows.Forms.Button();
            this.SideMenu.SuspendLayout();
            this.MenuIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.HandlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorBodyPanel
            // 
            this.SideMenuTransition.SetDecoration(this.DoctorBodyPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.DoctorBodyPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoctorBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorBodyPanel.Location = new System.Drawing.Point(55, 0);
            this.DoctorBodyPanel.Name = "DoctorBodyPanel";
            this.DoctorBodyPanel.Size = new System.Drawing.Size(845, 510);
            this.DoctorBodyPanel.TabIndex = 3;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.SideMenu.Controls.Add(this.btnProfile);
            this.SideMenu.Controls.Add(this.btnSignOut);
            this.SideMenu.Controls.Add(this.btnSearchRecords);
            this.SideMenu.Controls.Add(this.MenuIconPanel);
            this.SideMenu.Controls.Add(this.HandlePanel);
            this.SideMenuTransition.SetDecoration(this.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoTransition.SetDecoration(this.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(10);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(55, 510);
            this.SideMenu.TabIndex = 2;
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
            this.btnSearchRecords.TabIndex = 10;
            this.btnSearchRecords.Text = "          Waiting Patients";
            this.btnSearchRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRecords.UseVisualStyleBackColor = true;
            this.btnSearchRecords.Click += new System.EventHandler(this.WaitingPatients);
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation3;
            // 
            // SideMenuTransition
            // 
            this.SideMenuTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.SideMenuTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.SideMenuTransition.DefaultAnimation = animation4;
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
            this.btnProfile.Location = new System.Drawing.Point(0, 170);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(5);
            this.btnProfile.Size = new System.Drawing.Size(55, 40);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "          My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Doctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DoctorBodyPanel);
            this.Controls.Add(this.SideMenu);
            this.logoTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideMenuTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(900, 510);
            this.SideMenu.ResumeLayout(false);
            this.MenuIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.HandlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DoctorBodyPanel;
        private Bunifu.UI.WinForms.BunifuTransition SideMenuTransition;
        private Bunifu.UI.WinForms.BunifuTransition logoTransition;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSearchRecords;
        private System.Windows.Forms.Panel MenuIconPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox picLogo;
        private System.Windows.Forms.Panel HandlePanel;
        private System.Windows.Forms.PictureBox picMenuBtn;
        private System.Windows.Forms.Button btnProfile;
    }
}
