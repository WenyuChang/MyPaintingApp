namespace Graphy
{
    partial class MainWindows
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox pro;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.Stylenum = new System.Windows.Forms.TextBox();
            this.Style = new System.Windows.Forms.Label();
            this.widthnum = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Drawing = new System.Windows.Forms.PictureBox();
            this.grpTool = new System.Windows.Forms.GroupBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.AddFilledPolygon = new System.Windows.Forms.Button();
            this.AddCurve = new System.Windows.Forms.Button();
            this.AddPolygon = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.AddFillCircle = new System.Windows.Forms.Button();
            this.AddPoint = new System.Windows.Forms.Button();
            this.AddLine = new System.Windows.Forms.Button();
            this.AddHollowRectangle = new System.Windows.Forms.Button();
            this.AddFilledRectangle = new System.Windows.Forms.Button();
            this.AddHollowEllipse = new System.Windows.Forms.Button();
            this.AddFilledEllipse = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.Magenta = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.LawnGreen = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.MousePisition = new System.Windows.Forms.ToolStripStatusLabel();
            this.PointPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.Position = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.ColorS = new System.Windows.Forms.Label();
            this.TypeS = new System.Windows.Forms.Label();
            this.StatusType = new System.Windows.Forms.Label();
            this.StatusColor = new System.Windows.Forms.Label();
            pro = new System.Windows.Forms.GroupBox();
            pro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).BeginInit();
            this.grpTool.SuspendLayout();
            this.ColorBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pro
            // 
            pro.Controls.Add(this.Stylenum);
            pro.Controls.Add(this.Style);
            pro.Controls.Add(this.widthnum);
            pro.Controls.Add(this.width);
            pro.Location = new System.Drawing.Point(1, 460);
            pro.Name = "pro";
            pro.Size = new System.Drawing.Size(743, 37);
            pro.TabIndex = 33;
            pro.TabStop = false;
            // 
            // Stylenum
            // 
            this.Stylenum.Location = new System.Drawing.Point(518, 10);
            this.Stylenum.Name = "Stylenum";
            this.Stylenum.Size = new System.Drawing.Size(113, 21);
            this.Stylenum.TabIndex = 4;
            this.Stylenum.Text = "1";
            this.Stylenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Style
            // 
            this.Style.AutoSize = true;
            this.Style.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Style.Location = new System.Drawing.Point(272, 16);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(240, 16);
            this.Style.TabIndex = 3;
            this.Style.Text = "Style(1:实线，2:虚线，3:点线)";
            // 
            // widthnum
            // 
            this.widthnum.Location = new System.Drawing.Point(103, 10);
            this.widthnum.Name = "widthnum";
            this.widthnum.Size = new System.Drawing.Size(113, 21);
            this.widthnum.TabIndex = 2;
            this.widthnum.Text = "1";
            this.widthnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.width.Location = new System.Drawing.Point(9, 16);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(88, 16);
            this.width.TabIndex = 0;
            this.width.Text = "Width(1-5)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.toolStripSeparator1,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "File(F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建NToolStripMenuItem.Text = "New(N)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开OToolStripMenuItem.Text = "Open(O)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出XToolStripMenuItem.Text = "Exit(X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editEToolStripMenuItem.Text = "Edit(E)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "Help(H)";
            // 
            // Drawing
            // 
            this.Drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Drawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drawing.Location = new System.Drawing.Point(12, 27);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(567, 427);
            this.Drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Drawing.TabIndex = 5;
            this.Drawing.TabStop = false;
            this.Drawing.MouseLeave += new System.EventHandler(this.Drawing_MouseLeave);
            this.Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseMove);
            this.Drawing.Click += new System.EventHandler(this.Drawing_Click);
            this.Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseDown);
            this.Drawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseUp);
            // 
            // grpTool
            // 
            this.grpTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTool.Controls.Add(this.btnCut);
            this.grpTool.Controls.Add(this.btnPick);
            this.grpTool.Controls.Add(this.AddFilledPolygon);
            this.grpTool.Controls.Add(this.AddCurve);
            this.grpTool.Controls.Add(this.AddPolygon);
            this.grpTool.Controls.Add(this.btnEraser);
            this.grpTool.Controls.Add(this.AddFillCircle);
            this.grpTool.Controls.Add(this.AddPoint);
            this.grpTool.Controls.Add(this.AddLine);
            this.grpTool.Controls.Add(this.AddHollowRectangle);
            this.grpTool.Controls.Add(this.AddFilledRectangle);
            this.grpTool.Controls.Add(this.AddHollowEllipse);
            this.grpTool.Controls.Add(this.AddFilledEllipse);
            this.grpTool.Controls.Add(this.AddCircle);
            this.grpTool.Location = new System.Drawing.Point(650, 38);
            this.grpTool.Name = "grpTool";
            this.grpTool.Size = new System.Drawing.Size(82, 240);
            this.grpTool.TabIndex = 26;
            this.grpTool.TabStop = false;
            // 
            // btnCut
            // 
            this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCut.BackgroundImage")));
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCut.Location = new System.Drawing.Point(48, 208);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(26, 26);
            this.btnCut.TabIndex = 35;
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPick.BackgroundImage")));
            this.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPick.Location = new System.Drawing.Point(8, 208);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(26, 26);
            this.btnPick.TabIndex = 34;
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // AddFilledPolygon
            // 
            this.AddFilledPolygon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilledPolygon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFilledPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFilledPolygon.BackgroundImage")));
            this.AddFilledPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFilledPolygon.Location = new System.Drawing.Point(48, 144);
            this.AddFilledPolygon.Name = "AddFilledPolygon";
            this.AddFilledPolygon.Size = new System.Drawing.Size(26, 26);
            this.AddFilledPolygon.TabIndex = 31;
            this.AddFilledPolygon.UseVisualStyleBackColor = false;
            this.AddFilledPolygon.Click += new System.EventHandler(this.AddFilledPolygon_Click);
            // 
            // AddCurve
            // 
            this.AddCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCurve.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCurve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCurve.BackgroundImage")));
            this.AddCurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCurve.Location = new System.Drawing.Point(8, 176);
            this.AddCurve.Name = "AddCurve";
            this.AddCurve.Size = new System.Drawing.Size(26, 26);
            this.AddCurve.TabIndex = 30;
            this.AddCurve.UseVisualStyleBackColor = false;
            this.AddCurve.Click += new System.EventHandler(this.AddCurve_Click);
            // 
            // AddPolygon
            // 
            this.AddPolygon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPolygon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPolygon.BackgroundImage")));
            this.AddPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPolygon.Location = new System.Drawing.Point(8, 144);
            this.AddPolygon.Name = "AddPolygon";
            this.AddPolygon.Size = new System.Drawing.Size(26, 26);
            this.AddPolygon.TabIndex = 29;
            this.AddPolygon.UseVisualStyleBackColor = false;
            this.AddPolygon.Click += new System.EventHandler(this.AddPolygon_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEraser.Location = new System.Drawing.Point(48, 176);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(26, 26);
            this.btnEraser.TabIndex = 27;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // AddFillCircle
            // 
            this.AddFillCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFillCircle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFillCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFillCircle.BackgroundImage")));
            this.AddFillCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFillCircle.Image = ((System.Drawing.Image)(resources.GetObject("AddFillCircle.Image")));
            this.AddFillCircle.Location = new System.Drawing.Point(48, 112);
            this.AddFillCircle.Name = "AddFillCircle";
            this.AddFillCircle.Size = new System.Drawing.Size(26, 26);
            this.AddFillCircle.TabIndex = 25;
            this.AddFillCircle.UseVisualStyleBackColor = false;
            this.AddFillCircle.Click += new System.EventHandler(this.AddFillCircle_Click);
            // 
            // AddPoint
            // 
            this.AddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPoint.BackgroundImage")));
            this.AddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPoint.Location = new System.Drawing.Point(8, 16);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(26, 26);
            this.AddPoint.TabIndex = 15;
            this.AddPoint.UseVisualStyleBackColor = false;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // AddLine
            // 
            this.AddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddLine.BackgroundImage")));
            this.AddLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLine.Location = new System.Drawing.Point(48, 16);
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(26, 26);
            this.AddLine.TabIndex = 23;
            this.AddLine.UseVisualStyleBackColor = false;
            this.AddLine.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // AddHollowRectangle
            // 
            this.AddHollowRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHollowRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddHollowRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddHollowRectangle.BackgroundImage")));
            this.AddHollowRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddHollowRectangle.Image = ((System.Drawing.Image)(resources.GetObject("AddHollowRectangle.Image")));
            this.AddHollowRectangle.Location = new System.Drawing.Point(8, 48);
            this.AddHollowRectangle.Name = "AddHollowRectangle";
            this.AddHollowRectangle.Size = new System.Drawing.Size(26, 26);
            this.AddHollowRectangle.TabIndex = 16;
            this.AddHollowRectangle.UseVisualStyleBackColor = false;
            this.AddHollowRectangle.Click += new System.EventHandler(this.AddHollowRectangle_Click);
            // 
            // AddFilledRectangle
            // 
            this.AddFilledRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilledRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFilledRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFilledRectangle.BackgroundImage")));
            this.AddFilledRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFilledRectangle.Image = ((System.Drawing.Image)(resources.GetObject("AddFilledRectangle.Image")));
            this.AddFilledRectangle.Location = new System.Drawing.Point(48, 48);
            this.AddFilledRectangle.Name = "AddFilledRectangle";
            this.AddFilledRectangle.Size = new System.Drawing.Size(26, 26);
            this.AddFilledRectangle.TabIndex = 17;
            this.AddFilledRectangle.UseVisualStyleBackColor = false;
            this.AddFilledRectangle.Click += new System.EventHandler(this.AddFilledRectangle_Click);
            // 
            // AddHollowEllipse
            // 
            this.AddHollowEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHollowEllipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddHollowEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddHollowEllipse.BackgroundImage")));
            this.AddHollowEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddHollowEllipse.Image = ((System.Drawing.Image)(resources.GetObject("AddHollowEllipse.Image")));
            this.AddHollowEllipse.Location = new System.Drawing.Point(8, 80);
            this.AddHollowEllipse.Name = "AddHollowEllipse";
            this.AddHollowEllipse.Size = new System.Drawing.Size(26, 26);
            this.AddHollowEllipse.TabIndex = 19;
            this.AddHollowEllipse.UseVisualStyleBackColor = false;
            this.AddHollowEllipse.Click += new System.EventHandler(this.AddHollowEllipse_Click);
            // 
            // AddFilledEllipse
            // 
            this.AddFilledEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilledEllipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFilledEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFilledEllipse.BackgroundImage")));
            this.AddFilledEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFilledEllipse.Image = ((System.Drawing.Image)(resources.GetObject("AddFilledEllipse.Image")));
            this.AddFilledEllipse.Location = new System.Drawing.Point(48, 80);
            this.AddFilledEllipse.Name = "AddFilledEllipse";
            this.AddFilledEllipse.Size = new System.Drawing.Size(26, 26);
            this.AddFilledEllipse.TabIndex = 22;
            this.AddFilledEllipse.UseVisualStyleBackColor = false;
            this.AddFilledEllipse.Click += new System.EventHandler(this.AddFilledEllipse_Click);
            // 
            // AddCircle
            // 
            this.AddCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCircle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCircle.BackgroundImage")));
            this.AddCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCircle.Image = ((System.Drawing.Image)(resources.GetObject("AddCircle.Image")));
            this.AddCircle.Location = new System.Drawing.Point(8, 112);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(26, 26);
            this.AddCircle.TabIndex = 24;
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox.Controls.Add(this.blue);
            this.ColorBox.Controls.Add(this.Red);
            this.ColorBox.Controls.Add(this.btnColor);
            this.ColorBox.Controls.Add(this.Magenta);
            this.ColorBox.Controls.Add(this.White);
            this.ColorBox.Controls.Add(this.Black);
            this.ColorBox.Controls.Add(this.Yellow);
            this.ColorBox.Controls.Add(this.LawnGreen);
            this.ColorBox.Controls.Add(this.Cyan);
            this.ColorBox.Location = new System.Drawing.Point(676, 278);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(48, 112);
            this.ColorBox.TabIndex = 30;
            this.ColorBox.TabStop = false;
            // 
            // blue
            // 
            this.blue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(24, 56);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(15, 15);
            this.blue.TabIndex = 3;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // Red
            // 
            this.Red.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(8, 56);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(15, 15);
            this.Red.TabIndex = 2;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(12, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 24);
            this.btnColor.TabIndex = 32;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Magenta
            // 
            this.Magenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Magenta.BackColor = System.Drawing.Color.Magenta;
            this.Magenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Magenta.Location = new System.Drawing.Point(24, 88);
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(15, 15);
            this.Magenta.TabIndex = 31;
            this.Magenta.UseVisualStyleBackColor = false;
            this.Magenta.Click += new System.EventHandler(this.Magenta_Click);
            // 
            // White
            // 
            this.White.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.White.BackColor = System.Drawing.Color.White;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.Location = new System.Drawing.Point(24, 40);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(15, 15);
            this.White.TabIndex = 1;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Black
            // 
            this.Black.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.Location = new System.Drawing.Point(8, 40);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(15, 15);
            this.Black.TabIndex = 0;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Yellow
            // 
            this.Yellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(8, 72);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(15, 15);
            this.Yellow.TabIndex = 28;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // LawnGreen
            // 
            this.LawnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LawnGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.LawnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LawnGreen.Location = new System.Drawing.Point(24, 72);
            this.LawnGreen.Name = "LawnGreen";
            this.LawnGreen.Size = new System.Drawing.Size(15, 15);
            this.LawnGreen.TabIndex = 29;
            this.LawnGreen.UseVisualStyleBackColor = false;
            this.LawnGreen.Click += new System.EventHandler(this.LawnGreen_Click);
            // 
            // Cyan
            // 
            this.Cyan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Cyan.BackColor = System.Drawing.Color.Cyan;
            this.Cyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cyan.Location = new System.Drawing.Point(8, 88);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(15, 15);
            this.Cyan.TabIndex = 30;
            this.Cyan.UseVisualStyleBackColor = false;
            this.Cyan.Click += new System.EventHandler(this.Cyan_Click);
            // 
            // statusBar
            // 
            this.statusBar.GripMargin = new System.Windows.Forms.Padding(3);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MousePisition,
            this.PointPosition,
            this.Position});
            this.statusBar.Location = new System.Drawing.Point(0, 497);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(744, 22);
            this.statusBar.TabIndex = 31;
            // 
            // MousePisition
            // 
            this.MousePisition.Name = "MousePisition";
            this.MousePisition.Size = new System.Drawing.Size(0, 17);
            // 
            // PointPosition
            // 
            this.PointPosition.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.PointPosition.Name = "PointPosition";
            this.PointPosition.Size = new System.Drawing.Size(57, 17);
            this.PointPosition.Text = "Position:";
            this.PointPosition.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PointPosition.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Position
            // 
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(0, 17);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.ColorS);
            this.groupStatus.Controls.Add(this.TypeS);
            this.groupStatus.Controls.Add(this.StatusType);
            this.groupStatus.Controls.Add(this.StatusColor);
            this.groupStatus.Location = new System.Drawing.Point(603, 393);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(121, 61);
            this.groupStatus.TabIndex = 32;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status:";
            // 
            // ColorS
            // 
            this.ColorS.AutoSize = true;
            this.ColorS.Location = new System.Drawing.Point(58, 40);
            this.ColorS.Name = "ColorS";
            this.ColorS.Size = new System.Drawing.Size(35, 12);
            this.ColorS.TabIndex = 3;
            this.ColorS.Text = "Black";
            // 
            // TypeS
            // 
            this.TypeS.AutoSize = true;
            this.TypeS.Location = new System.Drawing.Point(58, 17);
            this.TypeS.Name = "TypeS";
            this.TypeS.Size = new System.Drawing.Size(29, 12);
            this.TypeS.TabIndex = 2;
            this.TypeS.Text = "Null";
            // 
            // StatusType
            // 
            this.StatusType.AutoSize = true;
            this.StatusType.Location = new System.Drawing.Point(8, 17);
            this.StatusType.Name = "StatusType";
            this.StatusType.Size = new System.Drawing.Size(41, 12);
            this.StatusType.TabIndex = 1;
            this.StatusType.Text = "Type :";
            // 
            // StatusColor
            // 
            this.StatusColor.AutoSize = true;
            this.StatusColor.Location = new System.Drawing.Point(8, 40);
            this.StatusColor.Name = "StatusColor";
            this.StatusColor.Size = new System.Drawing.Size(41, 12);
            this.StatusColor.TabIndex = 0;
            this.StatusColor.Text = "Color:";
            // 
            // MainWindows
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(744, 519);
            this.Controls.Add(pro);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.grpTool);
            this.Controls.Add(this.Drawing);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindows";
            this.Text = "MyPGS";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            pro.ResumeLayout(false);
            pro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).EndInit();
            this.grpTool.ResumeLayout(false);
            this.ColorBox.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.PictureBox Drawing;
        private System.Windows.Forms.GroupBox grpTool;
        private System.Windows.Forms.Button AddCurve;
        private System.Windows.Forms.Button AddPolygon;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button AddFillCircle;
        internal System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Button AddLine;
        internal System.Windows.Forms.Button AddHollowRectangle;
        internal System.Windows.Forms.Button AddFilledRectangle;
        internal System.Windows.Forms.Button AddHollowEllipse;
        internal System.Windows.Forms.Button AddFilledEllipse;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button Magenta;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button LawnGreen;
        private System.Windows.Forms.Button Cyan;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel PointPosition;
        private System.Windows.Forms.ToolStripStatusLabel MousePisition;
        private System.Windows.Forms.ToolStripStatusLabel Position;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label StatusColor;
        private System.Windows.Forms.Label StatusType;
        private System.Windows.Forms.Label ColorS;
        private System.Windows.Forms.Label TypeS;
        private System.Windows.Forms.TextBox widthnum;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.TextBox Stylenum;
        private System.Windows.Forms.Label Style;
        private System.Windows.Forms.Button AddFilledPolygon;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnCut;


    }
}

