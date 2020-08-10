namespace VVUHMS.Forms.UserControls.Nurse
{
    partial class SearchPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatAvailable = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvPatients = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnVitals = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SearchPageTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.Patient_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHIS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.SearchPageTransition.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(845, 55);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Search Records";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.refresh);
            this.SearchPanel.Controls.Add(this.bunifuLabel2);
            this.SearchPanel.Controls.Add(this.groupBox1);
            this.SearchPanel.Controls.Add(this.btnSearch);
            this.SearchPanel.Controls.Add(this.searchBox);
            this.SearchPageTransition.SetDecoration(this.SearchPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(0, 55);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(845, 455);
            this.SearchPanel.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPageTransition.SetDecoration(this.refresh, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(768, 109);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refresh.TabIndex = 22;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.SearchPageTransition.SetDecoration(this.bunifuLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel2.Location = new System.Drawing.Point(134, 122);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(597, 19);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "Double Click A Record To Select";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPatAvailable);
            this.groupBox1.Controls.Add(this.bunifuButton1);
            this.groupBox1.Controls.Add(this.dgvPatients);
            this.groupBox1.Controls.Add(this.btnVitals);
            this.SearchPageTransition.SetDecoration(this.groupBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // txtPatAvailable
            // 
            this.txtPatAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatAvailable.AutoEllipsis = false;
            this.txtPatAvailable.AutoSize = false;
            this.txtPatAvailable.CursorType = null;
            this.SearchPageTransition.SetDecoration(this.txtPatAvailable, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtPatAvailable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatAvailable.ForeColor = System.Drawing.Color.DimGray;
            this.txtPatAvailable.Location = new System.Drawing.Point(186, 72);
            this.txtPatAvailable.Name = "txtPatAvailable";
            this.txtPatAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPatAvailable.Size = new System.Drawing.Size(371, 134);
            this.txtPatAvailable.TabIndex = 20;
            this.txtPatAvailable.Text = "No Records Available";
            this.txtPatAvailable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPatAvailable.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtPatAvailable.Visible = false;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "UPDATE RECORD";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.SearchPageTransition.SetDecoration(this.bunifuButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(303, 259);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.bunifuButton1.onHoverState.BorderRadius = 3;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 3;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 3;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(136, 35);
            this.bunifuButton1.TabIndex = 6;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Visible = false;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowCustomTheming = false;
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeight = 40;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient_ID,
            this.NHIS_ID,
            this.FirstName,
            this.OtherName,
            this.LastName});
            this.dgvPatients.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvPatients.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPatients.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatients.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvPatients.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPatients.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvPatients.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvPatients.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvPatients.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPatients.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatients.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvPatients.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPatients.CurrentTheme.Name = null;
            this.dgvPatients.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvPatients.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPatients.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatients.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvPatients.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.SearchPageTransition.SetDecoration(this.dgvPatients, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvPatients.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvPatients.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPatients.Location = new System.Drawing.Point(3, 20);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowTemplate.Height = 40;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(751, 209);
            this.dgvPatients.TabIndex = 5;
            this.dgvPatients.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dgvPatients.DoubleClick += new System.EventHandler(this.dgvPatients_DoubleClick);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnVitals.CustomizableEdges = borderEdges2;
            this.SearchPageTransition.SetDecoration(this.btnVitals, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.btnVitals.Location = new System.Drawing.Point(485, 235);
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
            this.btnVitals.TabIndex = 4;
            this.btnVitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVitals.TextMarginLeft = 0;
            this.btnVitals.UseDefaultRadiusAndThickness = true;
            this.btnVitals.Visible = false;
            this.btnVitals.Click += new System.EventHandler(this.btnVitals_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AllowToggling = false;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges3;
            this.SearchPageTransition.SetDecoration(this.btnSearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnSearch.IdleBorderRadius = 3;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSearch.IdleIconLeftImage = null;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(281, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnSearch.onHoverState.BorderRadius = 3;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnSearch.OnIdleState.BorderRadius = 3;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSearch.OnIdleState.IconLeftImage = null;
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSearch.OnPressedState.BorderRadius = 3;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(286, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBox.BackgroundImage")));
            this.searchBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.searchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBox.BorderRadius = 1;
            this.searchBox.BorderThickness = 1;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchPageTransition.SetDecoration(this.searchBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.searchBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.searchBox.DefaultText = "";
            this.searchBox.FillColor = System.Drawing.Color.White;
            this.searchBox.HideSelection = true;
            this.searchBox.IconLeft = null;
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.IconPadding = 10;
            this.searchBox.IconRight = null;
            this.searchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(106, 30);
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
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties4;
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBox.PlaceholderText = "Search by Name, Hospital ID or Health Insurance ID";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(635, 33);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 5;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Name, Hospital ID or Health Insurance ID";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBox_MouseClick);
            // 
            // SearchPageTransition
            // 
            this.SearchPageTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.SearchPageTransition.Cursor = null;
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
            this.SearchPageTransition.DefaultAnimation = animation1;
            // 
            // Patient_ID
            // 
            this.Patient_ID.DataPropertyName = "Patient_ID";
            this.Patient_ID.HeaderText = "Patient ID";
            this.Patient_ID.Name = "Patient_ID";
            this.Patient_ID.ReadOnly = true;
            // 
            // NHIS_ID
            // 
            this.NHIS_ID.DataPropertyName = "NHIS_ID";
            this.NHIS_ID.HeaderText = "NHIS ID";
            this.NHIS_ID.Name = "NHIS_ID";
            this.NHIS_ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // OtherName
            // 
            this.OtherName.DataPropertyName = "OtherName";
            this.OtherName.HeaderText = "Other Names";
            this.OtherName.Name = "OtherName";
            this.OtherName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // SearchPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.bunifuLabel1);
            this.SearchPageTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(845, 510);
            this.Load += new System.EventHandler(this.SearchPage_Load);
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel SearchPanel;
        private Bunifu.UI.WinForms.BunifuTransition SearchPageTransition;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVitals;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPatients;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel txtPatAvailable;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHIS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}
