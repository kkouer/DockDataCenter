namespace droneDockDataCenter.Controls
{
    partial class DockDetailPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockDetailPanel));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.dSkinGroupBox1 = new DSkin.Controls.DSkinGroupBox();
            this.dSkinPen1 = new DSkin.Controls.DSkinPen(this.components);
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinTableLayoutPanel1 = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinButtonRTL = new DSkin.Controls.DSkinButton();
            this.dSkinButtonTkoff = new DSkin.Controls.DSkinButton();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.hudControl1 = new droneDockDataCenter.Controls.HUDControl();
            this.dSkinTabPage2 = new DSkin.Controls.DSkinTabPage();
            this.pictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinGroupBox1.SuspendLayout();
            this.dSkinTableLayoutPanel1.SuspendLayout();
            this.dSkinTabControl1.SuspendLayout();
            this.dSkinTabPage1.SuspendLayout();
            this.dSkinTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(775, 563);
            this.gMapControl1.TabIndex = 3;
            this.gMapControl1.Zoom = 0D;
            // 
            // dSkinButton2
            // 
            this.dSkinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton2.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton2.ButtonBorderWidth = 1;
            this.dSkinButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinButton2.ForeColor = System.Drawing.Color.White;
            this.dSkinButton2.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton2.HoverImage = null;
            this.dSkinButton2.Location = new System.Drawing.Point(676, 524);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = null;
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = null;
            this.dSkinButton2.Radius = 10;
            this.dSkinButton2.ShowButtonBorder = true;
            this.dSkinButton2.Size = new System.Drawing.Size(96, 36);
            this.dSkinButton2.TabIndex = 6;
            this.dSkinButton2.Text = "Play";
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextPadding = 0;
            this.dSkinButton2.Click += new System.EventHandler(this.dSkinButton2_Click);
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinButton1.ForeColor = System.Drawing.Color.White;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.Location = new System.Drawing.Point(112, 276);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton1.TabIndex = 5;
            this.dSkinButton1.Text = "Back";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dSkinGroupBox1
            // 
            this.dSkinGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.Borders.AllWidth = 0;
            this.dSkinGroupBox1.Borders.BottomPen = this.dSkinPen1;
            this.dSkinGroupBox1.Borders.BottomWidth = 3;
            this.dSkinGroupBox1.Borders.LeftWidth = 0;
            this.dSkinGroupBox1.Borders.RightWidth = 0;
            this.dSkinGroupBox1.Borders.TopWidth = 0;
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel5);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel4);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel3);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel2);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel1);
            this.dSkinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.dSkinGroupBox1.ForeColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Location = new System.Drawing.Point(784, 11);
            this.dSkinGroupBox1.Name = "dSkinGroupBox1";
            this.dSkinGroupBox1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinGroupBox1.RightBottom")));
            this.dSkinGroupBox1.Size = new System.Drawing.Size(219, 212);
            this.dSkinGroupBox1.TabIndex = 7;
            this.dSkinGroupBox1.Text = "Drone Status";
            // 
            // dSkinPen1
            // 
            this.dSkinPen1.Color = System.Drawing.Color.White;
            this.dSkinPen1.CompoundArray = new float[0];
            this.dSkinPen1.DashPattern = new float[0];
            this.dSkinPen1.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.EffectValue = 1;
            this.dSkinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel5.Location = new System.Drawing.Point(19, 171);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(108, 21);
            this.dSkinLabel5.TabIndex = 1;
            this.dSkinLabel5.Text = "Ground Speed:";
            this.dSkinLabel5.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.EffectValue = 1;
            this.dSkinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel4.Location = new System.Drawing.Point(19, 136);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(63, 21);
            this.dSkinLabel4.TabIndex = 2;
            this.dSkinLabel4.Text = "Throttle:";
            this.dSkinLabel4.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.EffectValue = 1;
            this.dSkinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel3.Location = new System.Drawing.Point(19, 101);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(92, 21);
            this.dSkinLabel3.TabIndex = 3;
            this.dSkinLabel3.Text = "Flight mode:";
            this.dSkinLabel3.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.EffectValue = 1;
            this.dSkinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel2.Location = new System.Drawing.Point(19, 66);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(58, 21);
            this.dSkinLabel2.TabIndex = 4;
            this.dSkinLabel2.Text = "Battery:";
            this.dSkinLabel2.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.EffectValue = 1;
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel1.Location = new System.Drawing.Point(19, 31);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(24, 21);
            this.dSkinLabel1.TabIndex = 5;
            this.dSkinLabel1.Text = "ID:";
            this.dSkinLabel1.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinTableLayoutPanel1
            // 
            this.dSkinTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTableLayoutPanel1.BitmapCache = false;
            this.dSkinTableLayoutPanel1.Borders.AllColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanel1.Borders.BottomColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanel1.Borders.LeftColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanel1.Borders.LeftWidth = 0;
            this.dSkinTableLayoutPanel1.Borders.RightColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanel1.Borders.RightWidth = 0;
            this.dSkinTableLayoutPanel1.Borders.TopColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanel1.Borders.TopWidth = 0;
            this.dSkinTableLayoutPanel1.ColumnCount = 2;
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButton1, 1, 3);
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButtonRTL, 1, 0);
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButtonTkoff, 0, 0);
            this.dSkinTableLayoutPanel1.Location = new System.Drawing.Point(784, 229);
            this.dSkinTableLayoutPanel1.Name = "dSkinTableLayoutPanel1";
            this.dSkinTableLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanel1.RightBottom")));
            this.dSkinTableLayoutPanel1.RowCount = 4;
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dSkinTableLayoutPanel1.Size = new System.Drawing.Size(219, 367);
            this.dSkinTableLayoutPanel1.TabIndex = 4;
            // 
            // dSkinButtonRTL
            // 
            this.dSkinButtonRTL.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButtonRTL.ButtonBorderWidth = 1;
            this.dSkinButtonRTL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButtonRTL.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinButtonRTL.ForeColor = System.Drawing.Color.White;
            this.dSkinButtonRTL.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButtonRTL.HoverImage = null;
            this.dSkinButtonRTL.Location = new System.Drawing.Point(112, 3);
            this.dSkinButtonRTL.Name = "dSkinButtonRTL";
            this.dSkinButtonRTL.NormalImage = null;
            this.dSkinButtonRTL.PressColor = System.Drawing.Color.Empty;
            this.dSkinButtonRTL.PressedImage = null;
            this.dSkinButtonRTL.Radius = 10;
            this.dSkinButtonRTL.ShowButtonBorder = true;
            this.dSkinButtonRTL.Size = new System.Drawing.Size(98, 34);
            this.dSkinButtonRTL.TabIndex = 6;
            this.dSkinButtonRTL.Text = "RTL";
            this.dSkinButtonRTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButtonRTL.TextPadding = 0;
            this.dSkinButtonRTL.Click += new System.EventHandler(this.dSkinButtonRTL_Click);
            // 
            // dSkinButtonTkoff
            // 
            this.dSkinButtonTkoff.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButtonTkoff.ButtonBorderWidth = 1;
            this.dSkinButtonTkoff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButtonTkoff.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinButtonTkoff.ForeColor = System.Drawing.Color.White;
            this.dSkinButtonTkoff.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButtonTkoff.HoverImage = null;
            this.dSkinButtonTkoff.Location = new System.Drawing.Point(3, 3);
            this.dSkinButtonTkoff.Name = "dSkinButtonTkoff";
            this.dSkinButtonTkoff.NormalImage = null;
            this.dSkinButtonTkoff.PressColor = System.Drawing.Color.Empty;
            this.dSkinButtonTkoff.PressedImage = null;
            this.dSkinButtonTkoff.Radius = 10;
            this.dSkinButtonTkoff.ShowButtonBorder = true;
            this.dSkinButtonTkoff.Size = new System.Drawing.Size(98, 34);
            this.dSkinButtonTkoff.TabIndex = 6;
            this.dSkinButtonTkoff.Text = "Takeoff";
            this.dSkinButtonTkoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButtonTkoff.TextPadding = 0;
            this.dSkinButtonTkoff.Click += new System.EventHandler(this.dSkinButtonTkoff_Click);
            // 
            // dSkinTabControl1
            // 
            this.dSkinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTabControl1.BitmapCache = false;
            this.dSkinTabControl1.Controls.Add(this.dSkinTabPage1);
            this.dSkinTabControl1.Controls.Add(this.dSkinTabPage2);
            this.dSkinTabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.SteelBlue};
            this.dSkinTabControl1.ItemBackgroundImage = null;
            this.dSkinTabControl1.ItemBackgroundImageHover = null;
            this.dSkinTabControl1.ItemBackgroundImageSelected = null;
            this.dSkinTabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.dSkinTabControl1.Location = new System.Drawing.Point(3, 3);
            this.dSkinTabControl1.Name = "dSkinTabControl1";
            this.dSkinTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            this.dSkinTabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.dSkinTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.SelectedBottomLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dSkinTabControl1.SelectedBottomLineHeight = ((uint)(3u));
            this.dSkinTabControl1.Size = new System.Drawing.Size(775, 593);
            this.dSkinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dSkinTabControl1.TabIndex = 8;
            this.dSkinTabControl1.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.dSkinTabControl1.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.dSkinTabControl1.UpdownBtnBackColor = System.Drawing.Color.White;
            this.dSkinTabControl1.UpdownBtnBorderColor = System.Drawing.Color.Black;
            // 
            // dSkinTabPage1
            // 
            this.dSkinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage1.Controls.Add(this.hudControl1);
            this.dSkinTabPage1.Controls.Add(this.gMapControl1);
            this.dSkinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinTabPage1.Location = new System.Drawing.Point(0, 30);
            this.dSkinTabPage1.Name = "dSkinTabPage1";
            this.dSkinTabPage1.Size = new System.Drawing.Size(775, 563);
            this.dSkinTabPage1.TabIndex = 0;
            this.dSkinTabPage1.TabItemImage = null;
            this.dSkinTabPage1.Text = "Map";
            // 
            // hudControl1
            // 
            this.hudControl1.Airspeed = 0;
            this.hudControl1.Altitude = 0;
            this.hudControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hudControl1.Location = new System.Drawing.Point(575, 3);
            this.hudControl1.Name = "hudControl1";
            this.hudControl1.PitchAngle = 0F;
            this.hudControl1.RollAngle = 0F;
            this.hudControl1.Size = new System.Drawing.Size(200, 200);
            this.hudControl1.TabIndex = 0;
            this.hudControl1.Text = "hudControl1";
            this.hudControl1.YawAngle = 0F;
            // 
            // dSkinTabPage2
            // 
            this.dSkinTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage2.Controls.Add(this.dSkinButton2);
            this.dSkinTabPage2.Controls.Add(this.pictureBox1);
            this.dSkinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinTabPage2.Location = new System.Drawing.Point(0, 30);
            this.dSkinTabPage2.Name = "dSkinTabPage2";
            this.dSkinTabPage2.Size = new System.Drawing.Size(775, 563);
            this.dSkinTabPage2.TabIndex = 1;
            this.dSkinTabPage2.TabItemImage = null;
            this.dSkinTabPage2.Text = "Video Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = null;
            this.pictureBox1.Images = new System.Drawing.Image[] {
        null};
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.Text = "dSkinPictureBox1";
            // 
            // DockDetailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dSkinTabControl1);
            this.Controls.Add(this.dSkinTableLayoutPanel1);
            this.Controls.Add(this.dSkinGroupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DockDetailPanel";
            this.Size = new System.Drawing.Size(1006, 599);
            this.dSkinGroupBox1.ResumeLayout(false);
            this.dSkinGroupBox1.PerformLayout();
            this.dSkinTableLayoutPanel1.ResumeLayout(false);
            this.dSkinTabControl1.ResumeLayout(false);
            this.dSkinTabPage1.ResumeLayout(false);
            this.dSkinTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private HUDControl hudControl1;
        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.Controls.DSkinGroupBox dSkinGroupBox1;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanel1;
        private DSkin.Controls.DSkinButton dSkinButton2;
        private DSkin.Controls.DSkinLabel dSkinLabel5;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        private DSkin.Controls.DSkinLabel dSkinLabel2;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinTabControl dSkinTabControl1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage2;
        private DSkin.Controls.DSkinPictureBox pictureBox1;
        private DSkin.Controls.DSkinPen dSkinPen1;
        private DSkin.Controls.DSkinButton dSkinButtonTkoff;
        private DSkin.Controls.DSkinButton dSkinButtonRTL;
    }
}
