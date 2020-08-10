namespace VVUHMS.Forms
{
    partial class PatientDetails
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetails));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Body = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.FormShape = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClrAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveVitals = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPreg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPrescription = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Controls.Add(this.splitContainer1);
            this.bunifuTransition1.SetDecoration(this.Body, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Body.Location = new System.Drawing.Point(0, 40);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(900, 560);
            this.Body.TabIndex = 5;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(200, 23);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "VVUHMS - Patient Details";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.TitleBar.Controls.Add(this.Close);
            this.TitleBar.Controls.Add(this.bunifuLabel1);
            this.bunifuTransition1.SetDecoration(this.TitleBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(900, 40);
            this.TitleBar.TabIndex = 4;
            // 
            // Close
            // 
            this.bunifuTransition1.SetDecoration(this.Close, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(860, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Close.TabIndex = 7;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            // FormShape
            // 
            this.FormShape.ElipseRadius = 0;
            this.FormShape.TargetControl = this;
            // 
            // splitContainer1
            // 
            this.bunifuTransition1.SetDecoration(this.splitContainer1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClrAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveVitals);
            this.splitContainer1.Panel1.Controls.Add(this.txtPreg);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtSugar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtBP);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtWeight);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTemp);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDate);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.splitContainer1.Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstPrescription);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.txtReport);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.bunifuTransition1.SetDecoration(this.splitContainer1.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitContainer1.Size = new System.Drawing.Size(900, 560);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnClrAll
            // 
            this.btnClrAll.AllowToggling = false;
            this.btnClrAll.AnimationSpeed = 200;
            this.btnClrAll.AutoGenerateColors = false;
            this.btnClrAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClrAll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClrAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClrAll.BackgroundImage")));
            this.btnClrAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClrAll.ButtonText = "Edit Form";
            this.btnClrAll.ButtonTextMarginLeft = 0;
            this.btnClrAll.ColorContrastOnClick = 45;
            this.btnClrAll.ColorContrastOnHover = 45;
            this.btnClrAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClrAll.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.btnClrAll, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClrAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClrAll.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnClrAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClrAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClrAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClrAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClrAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnClrAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnClrAll.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClrAll.IconMarginLeft = 11;
            this.btnClrAll.IconPadding = 10;
            this.btnClrAll.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClrAll.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnClrAll.IdleBorderRadius = 3;
            this.btnClrAll.IdleBorderThickness = 1;
            this.btnClrAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClrAll.IdleIconLeftImage = null;
            this.btnClrAll.IdleIconRightImage = null;
            this.btnClrAll.IndicateFocus = false;
            this.btnClrAll.Location = new System.Drawing.Point(10, 460);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnClrAll.onHoverState.BorderRadius = 3;
            this.btnClrAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClrAll.onHoverState.BorderThickness = 1;
            this.btnClrAll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnClrAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClrAll.onHoverState.IconLeftImage = null;
            this.btnClrAll.onHoverState.IconRightImage = null;
            this.btnClrAll.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnClrAll.OnIdleState.BorderRadius = 3;
            this.btnClrAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClrAll.OnIdleState.BorderThickness = 1;
            this.btnClrAll.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClrAll.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnClrAll.OnIdleState.IconLeftImage = null;
            this.btnClrAll.OnIdleState.IconRightImage = null;
            this.btnClrAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnClrAll.OnPressedState.BorderRadius = 3;
            this.btnClrAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClrAll.OnPressedState.BorderThickness = 1;
            this.btnClrAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnClrAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClrAll.OnPressedState.IconLeftImage = null;
            this.btnClrAll.OnPressedState.IconRightImage = null;
            this.btnClrAll.Size = new System.Drawing.Size(289, 45);
            this.btnClrAll.TabIndex = 29;
            this.btnClrAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClrAll.TextMarginLeft = 0;
            this.btnClrAll.UseDefaultRadiusAndThickness = true;
            // 
            // btnSaveVitals
            // 
            this.btnSaveVitals.AllowToggling = false;
            this.btnSaveVitals.AnimationSpeed = 200;
            this.btnSaveVitals.AutoGenerateColors = false;
            this.btnSaveVitals.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveVitals.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveVitals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveVitals.BackgroundImage")));
            this.btnSaveVitals.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveVitals.ButtonText = "Finished";
            this.btnSaveVitals.ButtonTextMarginLeft = 0;
            this.btnSaveVitals.ColorContrastOnClick = 45;
            this.btnSaveVitals.ColorContrastOnHover = 45;
            this.btnSaveVitals.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSaveVitals.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.btnSaveVitals, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSaveVitals.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveVitals.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSaveVitals.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveVitals.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveVitals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveVitals.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveVitals.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSaveVitals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSaveVitals.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveVitals.IconMarginLeft = 11;
            this.btnSaveVitals.IconPadding = 10;
            this.btnSaveVitals.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveVitals.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnSaveVitals.IdleBorderRadius = 3;
            this.btnSaveVitals.IdleBorderThickness = 1;
            this.btnSaveVitals.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveVitals.IdleIconLeftImage = null;
            this.btnSaveVitals.IdleIconRightImage = null;
            this.btnSaveVitals.IndicateFocus = false;
            this.btnSaveVitals.Location = new System.Drawing.Point(10, 505);
            this.btnSaveVitals.Name = "btnSaveVitals";
            this.btnSaveVitals.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnSaveVitals.onHoverState.BorderRadius = 3;
            this.btnSaveVitals.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveVitals.onHoverState.BorderThickness = 1;
            this.btnSaveVitals.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(119)))), ((int)(((byte)(157)))));
            this.btnSaveVitals.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveVitals.onHoverState.IconLeftImage = null;
            this.btnSaveVitals.onHoverState.IconRightImage = null;
            this.btnSaveVitals.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnSaveVitals.OnIdleState.BorderRadius = 3;
            this.btnSaveVitals.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveVitals.OnIdleState.BorderThickness = 1;
            this.btnSaveVitals.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveVitals.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(14)))), ((int)(((byte)(111)))));
            this.btnSaveVitals.OnIdleState.IconLeftImage = null;
            this.btnSaveVitals.OnIdleState.IconRightImage = null;
            this.btnSaveVitals.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSaveVitals.OnPressedState.BorderRadius = 3;
            this.btnSaveVitals.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveVitals.OnPressedState.BorderThickness = 1;
            this.btnSaveVitals.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSaveVitals.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveVitals.OnPressedState.IconLeftImage = null;
            this.btnSaveVitals.OnPressedState.IconRightImage = null;
            this.btnSaveVitals.Size = new System.Drawing.Size(289, 45);
            this.btnSaveVitals.TabIndex = 28;
            this.btnSaveVitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveVitals.TextMarginLeft = 0;
            this.btnSaveVitals.UseDefaultRadiusAndThickness = true;
            // 
            // txtPreg
            // 
            this.bunifuTransition1.SetDecoration(this.txtPreg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtPreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPreg.Enabled = false;
            this.txtPreg.Location = new System.Drawing.Point(10, 325);
            this.txtPreg.Name = "txtPreg";
            this.txtPreg.ReadOnly = true;
            this.txtPreg.Size = new System.Drawing.Size(289, 24);
            this.txtPreg.TabIndex = 27;
            // 
            // label6
            // 
            this.bunifuTransition1.SetDecoration(this.label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 35);
            this.label6.TabIndex = 26;
            this.label6.Text = "Pregnant";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSugar
            // 
            this.bunifuTransition1.SetDecoration(this.txtSugar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtSugar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSugar.Enabled = false;
            this.txtSugar.Location = new System.Drawing.Point(10, 266);
            this.txtSugar.Name = "txtSugar";
            this.txtSugar.ReadOnly = true;
            this.txtSugar.Size = new System.Drawing.Size(289, 24);
            this.txtSugar.TabIndex = 25;
            // 
            // label5
            // 
            this.bunifuTransition1.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(10, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 35);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sugar Level";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBP
            // 
            this.bunifuTransition1.SetDecoration(this.txtBP, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtBP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBP.Enabled = false;
            this.txtBP.Location = new System.Drawing.Point(10, 207);
            this.txtBP.Name = "txtBP";
            this.txtBP.ReadOnly = true;
            this.txtBP.Size = new System.Drawing.Size(289, 24);
            this.txtBP.TabIndex = 23;
            // 
            // label4
            // 
            this.bunifuTransition1.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Blood Pressure";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtWeight
            // 
            this.bunifuTransition1.SetDecoration(this.txtWeight, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(10, 147);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(289, 24);
            this.txtWeight.TabIndex = 21;
            // 
            // label3
            // 
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Weight";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTemp
            // 
            this.bunifuTransition1.SetDecoration(this.txtTemp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(10, 87);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(289, 24);
            this.txtTemp.TabIndex = 19;
            // 
            // label2
            // 
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Temperature";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDate
            // 
            this.bunifuTransition1.SetDecoration(this.txtDate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(10, 28);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(289, 24);
            this.txtDate.TabIndex = 17;
            // 
            // label1
            // 
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstPrescription
            // 
            this.lstPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPrescription.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.lstPrescription, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lstPrescription.FormattingEnabled = true;
            this.lstPrescription.ItemHeight = 17;
            this.lstPrescription.Location = new System.Drawing.Point(32, 52);
            this.lstPrescription.Name = "lstPrescription";
            this.lstPrescription.Size = new System.Drawing.Size(536, 123);
            this.lstPrescription.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(32, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 2);
            this.panel3.TabIndex = 24;
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtReport, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtReport.Location = new System.Drawing.Point(32, 265);
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.Size = new System.Drawing.Size(536, 264);
            this.txtReport.TabIndex = 23;
            this.txtReport.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(28, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Consultation Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(28, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Prescription";
            // 
            // PatientDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.TitleBar);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientDetails";
            this.Body.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel Body;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.Framework.UI.BunifuElipse FormShape;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClrAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveVitals;
        private System.Windows.Forms.TextBox txtPreg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPrescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}