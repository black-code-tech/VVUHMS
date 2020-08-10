namespace VVUHMS.Forms.UserControls.DoctorForms
{
    partial class ConsultPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultPatients));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWaitingPatients = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Patient_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.txtPatAvailable = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAttend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingPatients)).BeginInit();
            this.btnRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waiting Patients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWaitingPatients
            // 
            this.dgvWaitingPatients.AllowCustomTheming = false;
            this.dgvWaitingPatients.AllowUserToAddRows = false;
            this.dgvWaitingPatients.AllowUserToDeleteRows = false;
            this.dgvWaitingPatients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvWaitingPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWaitingPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWaitingPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaitingPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvWaitingPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWaitingPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWaitingPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWaitingPatients.ColumnHeadersHeight = 40;
            this.dgvWaitingPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient_ID,
            this.FirstName,
            this.MiddleName,
            this.LastName});
            this.dgvWaitingPatients.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvWaitingPatients.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWaitingPatients.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWaitingPatients.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvWaitingPatients.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWaitingPatients.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvWaitingPatients.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvWaitingPatients.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvWaitingPatients.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvWaitingPatients.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvWaitingPatients.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvWaitingPatients.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWaitingPatients.CurrentTheme.Name = null;
            this.dgvWaitingPatients.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvWaitingPatients.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWaitingPatients.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWaitingPatients.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvWaitingPatients.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWaitingPatients.EnableHeadersVisualStyles = false;
            this.dgvWaitingPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvWaitingPatients.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvWaitingPatients.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvWaitingPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dgvWaitingPatients.Location = new System.Drawing.Point(35, 38);
            this.dgvWaitingPatients.Name = "dgvWaitingPatients";
            this.dgvWaitingPatients.ReadOnly = true;
            this.dgvWaitingPatients.RowHeadersVisible = false;
            this.dgvWaitingPatients.RowTemplate.Height = 40;
            this.dgvWaitingPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitingPatients.Size = new System.Drawing.Size(776, 341);
            this.dgvWaitingPatients.TabIndex = 0;
            this.dgvWaitingPatients.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dgvWaitingPatients.DoubleClick += new System.EventHandler(this.dgvWaitingPatients_DoubleClick);
            // 
            // Patient_ID
            // 
            this.Patient_ID.DataPropertyName = "Patient_ID";
            this.Patient_ID.HeaderText = "Patient ID";
            this.Patient_ID.Name = "Patient_ID";
            this.Patient_ID.ReadOnly = true;
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
            // btnRefresh
            // 
            this.btnRefresh.Controls.Add(this.refresh);
            this.btnRefresh.Controls.Add(this.txtPatAvailable);
            this.btnRefresh.Controls.Add(this.bunifuLabel4);
            this.btnRefresh.Controls.Add(this.btnAttend);
            this.btnRefresh.Controls.Add(this.dgvWaitingPatients);
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(0, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(845, 453);
            this.btnRefresh.TabIndex = 8;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(779, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refresh.TabIndex = 10;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // txtPatAvailable
            // 
            this.txtPatAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatAvailable.AutoEllipsis = false;
            this.txtPatAvailable.AutoSize = false;
            this.txtPatAvailable.CursorType = null;
            this.txtPatAvailable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatAvailable.ForeColor = System.Drawing.Color.DimGray;
            this.txtPatAvailable.Location = new System.Drawing.Point(249, 178);
            this.txtPatAvailable.Name = "txtPatAvailable";
            this.txtPatAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPatAvailable.Size = new System.Drawing.Size(342, 78);
            this.txtPatAvailable.TabIndex = 9;
            this.txtPatAvailable.Text = "No Waiting Patients";
            this.txtPatAvailable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPatAvailable.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtPatAvailable.Visible = false;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(845, 32);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Double Click A Record To Select";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAttend
            // 
            this.btnAttend.AllowToggling = false;
            this.btnAttend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttend.AnimationSpeed = 200;
            this.btnAttend.AutoGenerateColors = false;
            this.btnAttend.BackColor = System.Drawing.Color.Transparent;
            this.btnAttend.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnAttend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttend.BackgroundImage")));
            this.btnAttend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttend.ButtonText = "ATTEND TO PATIENT";
            this.btnAttend.ButtonTextMarginLeft = 0;
            this.btnAttend.ColorContrastOnClick = 45;
            this.btnAttend.ColorContrastOnHover = 45;
            this.btnAttend.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAttend.CustomizableEdges = borderEdges1;
            this.btnAttend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttend.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAttend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAttend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAttend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAttend.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAttend.ForeColor = System.Drawing.Color.White;
            this.btnAttend.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttend.IconMarginLeft = 11;
            this.btnAttend.IconPadding = 10;
            this.btnAttend.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttend.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnAttend.IdleBorderRadius = 3;
            this.btnAttend.IdleBorderThickness = 1;
            this.btnAttend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnAttend.IdleIconLeftImage = null;
            this.btnAttend.IdleIconRightImage = null;
            this.btnAttend.IndicateFocus = false;
            this.btnAttend.Location = new System.Drawing.Point(545, 385);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnAttend.onHoverState.BorderRadius = 3;
            this.btnAttend.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttend.onHoverState.BorderThickness = 1;
            this.btnAttend.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnAttend.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAttend.onHoverState.IconLeftImage = null;
            this.btnAttend.onHoverState.IconRightImage = null;
            this.btnAttend.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnAttend.OnIdleState.BorderRadius = 3;
            this.btnAttend.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttend.OnIdleState.BorderThickness = 1;
            this.btnAttend.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.btnAttend.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAttend.OnIdleState.IconLeftImage = null;
            this.btnAttend.OnIdleState.IconRightImage = null;
            this.btnAttend.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnAttend.OnPressedState.BorderRadius = 3;
            this.btnAttend.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAttend.OnPressedState.BorderThickness = 1;
            this.btnAttend.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            this.btnAttend.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAttend.OnPressedState.IconLeftImage = null;
            this.btnAttend.OnPressedState.IconRightImage = null;
            this.btnAttend.Size = new System.Drawing.Size(266, 60);
            this.btnAttend.TabIndex = 5;
            this.btnAttend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttend.TextMarginLeft = 0;
            this.btnAttend.UseDefaultRadiusAndThickness = true;
            this.btnAttend.Visible = false;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(179)))), ((int)(((byte)(60)))));
            this.info.Location = new System.Drawing.Point(0, 57);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(845, 453);
            this.info.TabIndex = 7;
            this.info.Text = "Waiting Patients";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultPatients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.info);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Name = "ConsultPatients";
            this.Size = new System.Drawing.Size(845, 510);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingPatients)).EndInit();
            this.btnRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAttend;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvWaitingPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Panel btnRefresh;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel txtPatAvailable;
        private System.Windows.Forms.PictureBox refresh;
    }
}
