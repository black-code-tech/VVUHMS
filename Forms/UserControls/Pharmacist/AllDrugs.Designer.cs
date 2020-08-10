namespace VVUHMS.Forms.UserControls.DoctorForms
{
    partial class AllDrugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllDrugs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnavailable = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvDrugs = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnVitals = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Drugs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnavailable
            // 
            this.txtUnavailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnavailable.AutoEllipsis = false;
            this.txtUnavailable.AutoSize = false;
            this.txtUnavailable.CursorType = null;
            this.txtUnavailable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnavailable.ForeColor = System.Drawing.Color.DimGray;
            this.txtUnavailable.Location = new System.Drawing.Point(244, 220);
            this.txtUnavailable.Name = "txtUnavailable";
            this.txtUnavailable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnavailable.Size = new System.Drawing.Size(371, 130);
            this.txtUnavailable.TabIndex = 28;
            this.txtUnavailable.Text = "No Records Available";
            this.txtUnavailable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUnavailable.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtUnavailable.Visible = false;
            // 
            // dgvDrugs
            // 
            this.dgvDrugs.AllowCustomTheming = false;
            this.dgvDrugs.AllowUserToAddRows = false;
            this.dgvDrugs.AllowUserToDeleteRows = false;
            this.dgvDrugs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDrugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrugs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrugs.ColumnHeadersHeight = 40;
            this.dgvDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrugName,
            this.Cost,
            this.NumAvailable,
            this.NHIS});
            this.dgvDrugs.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvDrugs.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrugs.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrugs.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvDrugs.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrugs.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvDrugs.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDrugs.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvDrugs.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrugs.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrugs.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvDrugs.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrugs.CurrentTheme.Name = null;
            this.dgvDrugs.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvDrugs.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrugs.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrugs.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvDrugs.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrugs.EnableHeadersVisualStyles = false;
            this.dgvDrugs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDrugs.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvDrugs.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDrugs.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDrugs.Location = new System.Drawing.Point(23, 124);
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.ReadOnly = true;
            this.dgvDrugs.RowHeadersVisible = false;
            this.dgvDrugs.RowTemplate.Height = 40;
            this.dgvDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugs.Size = new System.Drawing.Size(800, 317);
            this.dgvDrugs.TabIndex = 27;
            this.dgvDrugs.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // btnVitals
            // 
            this.btnVitals.AllowToggling = false;
            this.btnVitals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVitals.AnimationSpeed = 200;
            this.btnVitals.AutoGenerateColors = false;
            this.btnVitals.BackColor = System.Drawing.Color.Transparent;
            this.btnVitals.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnVitals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVitals.BackgroundImage")));
            this.btnVitals.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVitals.ButtonText = "PROCEED TO VITALS ENTRY";
            this.btnVitals.ButtonTextMarginLeft = 0;
            this.btnVitals.ColorContrastOnClick = 45;
            this.btnVitals.ColorContrastOnHover = 45;
            this.btnVitals.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnVitals.CustomizableEdges = borderEdges1;
            this.btnVitals.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVitals.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnVitals.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVitals.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVitals.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVitals.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnVitals.ForeColor = System.Drawing.Color.White;
            this.btnVitals.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnVitals.IconMarginLeft = 11;
            this.btnVitals.IconPadding = 10;
            this.btnVitals.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnVitals.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnVitals.IdleBorderRadius = 3;
            this.btnVitals.IdleBorderThickness = 1;
            this.btnVitals.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnVitals.IdleIconLeftImage = null;
            this.btnVitals.IdleIconRightImage = null;
            this.btnVitals.IndicateFocus = false;
            this.btnVitals.Location = new System.Drawing.Point(557, 447);
            this.btnVitals.Name = "btnVitals";
            this.btnVitals.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnVitals.onHoverState.BorderRadius = 3;
            this.btnVitals.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVitals.onHoverState.BorderThickness = 1;
            this.btnVitals.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnVitals.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVitals.onHoverState.IconLeftImage = null;
            this.btnVitals.onHoverState.IconRightImage = null;
            this.btnVitals.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnVitals.OnIdleState.BorderRadius = 3;
            this.btnVitals.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVitals.OnIdleState.BorderThickness = 1;
            this.btnVitals.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnVitals.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVitals.OnIdleState.IconLeftImage = null;
            this.btnVitals.OnIdleState.IconRightImage = null;
            this.btnVitals.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnVitals.OnPressedState.BorderRadius = 3;
            this.btnVitals.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVitals.OnPressedState.BorderThickness = 1;
            this.btnVitals.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnVitals.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVitals.OnPressedState.IconLeftImage = null;
            this.btnVitals.OnPressedState.IconRightImage = null;
            this.btnVitals.Size = new System.Drawing.Size(266, 60);
            this.btnVitals.TabIndex = 26;
            this.btnVitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVitals.TextMarginLeft = 0;
            this.btnVitals.UseDefaultRadiusAndThickness = true;
            this.btnVitals.Visible = false;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel3.Location = new System.Drawing.Point(122, 99);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(597, 19);
            this.bunifuLabel3.TabIndex = 25;
            this.bunifuLabel3.Text = "Double Click A Record To Select";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = false;
            this.searchBox.AcceptsTab = false;
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AnimationSpeed = 200;
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBox.BackgroundImage")));
            this.searchBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.searchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.searchBox.BorderRadius = 1;
            this.searchBox.BorderThickness = 1;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.searchBox.DefaultText = "";
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchBox.HideSelection = true;
            this.searchBox.IconLeft = null;
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.IconPadding = 10;
            this.searchBox.IconRight = null;
            this.searchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(101, 60);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBox.Modified = false;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties4;
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchBox.PlaceholderText = "Search by Name, Hospital ID or Health Insurance ID";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(635, 33);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.searchBox.TabIndex = 24;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 5;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Name, Hospital ID or Health Insurance ID";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // DrugName
            // 
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.HeaderText = "Drug Name";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // NumAvailable
            // 
            this.NumAvailable.DataPropertyName = "NumAvailable";
            this.NumAvailable.HeaderText = "Available Quantity";
            this.NumAvailable.Name = "NumAvailable";
            this.NumAvailable.ReadOnly = true;
            // 
            // NHIS
            // 
            this.NHIS.DataPropertyName = "NHIS";
            this.NHIS.HeaderText = "Supports NHIS";
            this.NHIS.Name = "NHIS";
            this.NHIS.ReadOnly = true;
            // 
            // AllDrugs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtUnavailable);
            this.Controls.Add(this.dgvDrugs);
            this.Controls.Add(this.btnVitals);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AllDrugs";
            this.Size = new System.Drawing.Size(845, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel txtUnavailable;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDrugs;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVitals;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHIS;
    }
}
