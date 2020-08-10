namespace VVUHMS.Forms
{
    partial class ForwardToDoctor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForwardToDoctor));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.Forward = new System.Windows.Forms.TabPage();
            this.Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnForward = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvDoctors = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuLabel();
            this.info = new System.Windows.Forms.Label();
            this.Forwarded = new System.Windows.Forms.TabPage();
            this.btnYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.FormShape = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.TitleBar.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.Forward.SuspendLayout();
            this.Body.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panel1.SuspendLayout();
            this.Forwarded.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.TitleBar.Controls.Add(this.bunifuLabel1);
            this.bunifuTransition1.SetDecoration(this.TitleBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(850, 40);
            this.TitleBar.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(177, 23);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "VVUHMS - Forwarding";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.Forward);
            this.bunifuPages1.Controls.Add(this.Forwarded);
            this.bunifuTransition1.SetDecoration(this.bunifuPages1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 40);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.Forwarded;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "Forwarded";
            this.bunifuPages1.PageTitle = "Forwarded";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(850, 510);
            this.bunifuPages1.TabIndex = 3;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation2;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Forward
            // 
            this.Forward.Controls.Add(this.Body);
            this.bunifuTransition1.SetDecoration(this.Forward, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Forward.Location = new System.Drawing.Point(4, 4);
            this.Forward.Name = "Forward";
            this.Forward.Padding = new System.Windows.Forms.Padding(3);
            this.Forward.Size = new System.Drawing.Size(842, 480);
            this.Forward.TabIndex = 0;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Controls.Add(this.panel2);
            this.Body.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.Body, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Body.Location = new System.Drawing.Point(3, 3);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(836, 474);
            this.Body.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuLabel4);
            this.panel2.Controls.Add(this.btnForward);
            this.panel2.Controls.Add(this.dgvDoctors);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 417);
            this.panel2.TabIndex = 1;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel4.Location = new System.Drawing.Point(125, 6);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(597, 19);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Double Click A Record To Select";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnForward
            // 
            this.btnForward.AllowToggling = false;
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.AnimationSpeed = 200;
            this.btnForward.AutoGenerateColors = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForward.BackgroundImage")));
            this.btnForward.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnForward.ButtonText = "FORWARD TO DOCTOR";
            this.btnForward.ButtonTextMarginLeft = 0;
            this.btnForward.ColorContrastOnClick = 45;
            this.btnForward.ColorContrastOnHover = 45;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnForward.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.btnForward, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnForward.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnForward.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnForward.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.IconMarginLeft = 11;
            this.btnForward.IconPadding = 10;
            this.btnForward.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnForward.IdleBorderRadius = 3;
            this.btnForward.IdleBorderThickness = 1;
            this.btnForward.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnForward.IdleIconLeftImage = null;
            this.btnForward.IdleIconRightImage = null;
            this.btnForward.IndicateFocus = false;
            this.btnForward.Location = new System.Drawing.Point(502, 349);
            this.btnForward.Name = "btnForward";
            this.btnForward.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnForward.onHoverState.BorderRadius = 3;
            this.btnForward.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnForward.onHoverState.BorderThickness = 1;
            this.btnForward.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnForward.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnForward.onHoverState.IconLeftImage = null;
            this.btnForward.onHoverState.IconRightImage = null;
            this.btnForward.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnForward.OnIdleState.BorderRadius = 3;
            this.btnForward.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnForward.OnIdleState.BorderThickness = 1;
            this.btnForward.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnForward.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnForward.OnIdleState.IconLeftImage = null;
            this.btnForward.OnIdleState.IconRightImage = null;
            this.btnForward.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnForward.OnPressedState.BorderRadius = 3;
            this.btnForward.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnForward.OnPressedState.BorderThickness = 1;
            this.btnForward.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnForward.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnForward.OnPressedState.IconLeftImage = null;
            this.btnForward.OnPressedState.IconRightImage = null;
            this.btnForward.Size = new System.Drawing.Size(266, 60);
            this.btnForward.TabIndex = 5;
            this.btnForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForward.TextMarginLeft = 0;
            this.btnForward.UseDefaultRadiusAndThickness = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowCustomTheming = false;
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctors.ColumnHeadersHeight = 40;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.FirstName,
            this.MiddleName,
            this.LastName});
            this.dgvDoctors.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvDoctors.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDoctors.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDoctors.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvDoctors.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDoctors.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvDoctors.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDoctors.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvDoctors.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDoctors.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoctors.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvDoctors.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDoctors.CurrentTheme.Name = null;
            this.dgvDoctors.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvDoctors.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDoctors.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDoctors.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvDoctors.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.dgvDoctors, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctors.EnableHeadersVisualStyles = false;
            this.dgvDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDoctors.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvDoctors.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDoctors.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDoctors.Location = new System.Drawing.Point(66, 24);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.RowTemplate.Height = 40;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(702, 319);
            this.dgvDoctors.TabIndex = 0;
            this.dgvDoctors.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dgvDoctors.DoubleClick += new System.EventHandler(this.dgvDoctors_DoubleClick);
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "ID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "OtherName";
            this.MiddleName.HeaderText = "Other Names";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.info);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoEllipsis = false;
            this.btnCancel.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.btnCancel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnCancel.Location = new System.Drawing.Point(769, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(55, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // info
            // 
            this.bunifuTransition1.SetDecoration(this.info, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(836, 57);
            this.info.TabIndex = 0;
            this.info.Text = "Select a doctor to forward the patient to";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forwarded
            // 
            this.Forwarded.Controls.Add(this.btnYes);
            this.Forwarded.Controls.Add(this.bunifuLabel3);
            this.Forwarded.Controls.Add(this.bunifuLabel2);
            this.bunifuTransition1.SetDecoration(this.Forwarded, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Forwarded.Location = new System.Drawing.Point(4, 4);
            this.Forwarded.Name = "Forwarded";
            this.Forwarded.Padding = new System.Windows.Forms.Padding(3);
            this.Forwarded.Size = new System.Drawing.Size(842, 480);
            this.Forwarded.TabIndex = 1;
            this.Forwarded.Text = "Forwarded";
            this.Forwarded.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.AllowToggling = false;
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.AnimationSpeed = 200;
            this.btnYes.AutoGenerateColors = false;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackColor1 = System.Drawing.Color.Transparent;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.ButtonText = "OK";
            this.btnYes.ButtonTextMarginLeft = 0;
            this.btnYes.ColorContrastOnClick = 45;
            this.btnYes.ColorContrastOnHover = 45;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnYes.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.btnYes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnYes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnYes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IconMarginLeft = 11;
            this.btnYes.IconPadding = 10;
            this.btnYes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btnYes.IdleBorderRadius = 3;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnYes.IdleIconLeftImage = null;
            this.btnYes.IdleIconRightImage = null;
            this.btnYes.IndicateFocus = false;
            this.btnYes.Location = new System.Drawing.Point(274, 261);
            this.btnYes.Name = "btnYes";
            this.btnYes.onHoverState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnYes.onHoverState.BorderRadius = 3;
            this.btnYes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.onHoverState.BorderThickness = 1;
            this.btnYes.onHoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnYes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYes.onHoverState.IconLeftImage = null;
            this.btnYes.onHoverState.IconRightImage = null;
            this.btnYes.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnYes.OnIdleState.BorderRadius = 3;
            this.btnYes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnIdleState.BorderThickness = 1;
            this.btnYes.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnYes.OnIdleState.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYes.OnIdleState.IconLeftImage = null;
            this.btnYes.OnIdleState.IconRightImage = null;
            this.btnYes.OnPressedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnYes.OnPressedState.BorderRadius = 3;
            this.btnYes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnPressedState.BorderThickness = 1;
            this.btnYes.OnPressedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnYes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYes.OnPressedState.IconLeftImage = null;
            this.btnYes.OnPressedState.IconRightImage = null;
            this.btnYes.Size = new System.Drawing.Size(278, 70);
            this.btnYes.TabIndex = 13;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextMarginLeft = 0;
            this.btnYes.UseDefaultRadiusAndThickness = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel3.Font = new System.Drawing.Font("Roboto", 16F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel3.Location = new System.Drawing.Point(3, 212);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(836, 34);
            this.bunifuLabel3.TabIndex = 1;
            this.bunifuLabel3.Text = "The patient\'s records have been submitted to the selected doctor.\r\n";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel2.Font = new System.Drawing.Font("Roboto", 30F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuLabel2.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(836, 209);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Submitted Successfully !!!";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormShape
            // 
            this.FormShape.ElipseRadius = 0;
            this.FormShape.TargetControl = this;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.5D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.TitleBar;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // ForwardToDoctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.TitleBar);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForwardToDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForwardToDoctor";
            this.TopMost = true;
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.bunifuPages1.ResumeLayout(false);
            this.Forward.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Forwarded.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitleBar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage Forward;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnForward;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDoctors;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel btnCancel;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.TabPage Forwarded;
        private Bunifu.Framework.UI.BunifuElipse FormShape;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}