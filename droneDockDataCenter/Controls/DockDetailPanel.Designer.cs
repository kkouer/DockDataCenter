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
                if (_isRecording)
                {
                    StopRecording(); // 等待停止录制完成
                }
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
            this.dSkinPen1 = new DSkin.Controls.DSkinPen(this.components);
            this.dSkinTableLayoutPanelGimbal = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinButton5 = new DSkin.Controls.DSkinButton();
            this.dSkinButton6 = new DSkin.Controls.DSkinButton();
            this.dSkinButton7 = new DSkin.Controls.DSkinButton();
            this.dSkinButton8 = new DSkin.Controls.DSkinButton();
            this.dSkinButton9 = new DSkin.Controls.DSkinButton();
            this.dSkinButton3 = new DSkin.Controls.DSkinButton();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.dSkinButton11 = new DSkin.Controls.DSkinButton();
            this.dSkinButton12 = new DSkin.Controls.DSkinButton();
            this.dSkinButton10 = new DSkin.Controls.DSkinButton();
            this.dSkinButton13 = new DSkin.Controls.DSkinButton();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dSkinTabPage2 = new DSkin.Controls.DSkinTabPage();
            this.pictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinTableLayoutPanelDroneCMD = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinButton17 = new DSkin.Controls.DSkinButton();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.dSkinButtonRTL = new DSkin.Controls.DSkinButton();
            this.dSkinButtonTkoff = new DSkin.Controls.DSkinButton();
            this.dSkinButton4 = new DSkin.Controls.DSkinButton();
            this.dSkinButton14 = new DSkin.Controls.DSkinButton();
            this.dSkinButton15 = new DSkin.Controls.DSkinButton();
            this.dSkinButton16 = new DSkin.Controls.DSkinButton();
            this.dSkinGroupBoxDroneStatus = new DSkin.Controls.DSkinGroupBox();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinCheckBoxFollowDrone = new DSkin.Controls.DSkinCheckBox();
            this.hudControl1 = new droneDockDataCenter.Controls.HUDControl();
            this.dSkinTableLayoutPanelGimbal.SuspendLayout();
            this.dSkinTabControl1.SuspendLayout();
            this.dSkinTabPage1.SuspendLayout();
            this.dSkinTabPage2.SuspendLayout();
            this.dSkinTableLayoutPanelDroneCMD.SuspendLayout();
            this.dSkinGroupBoxDroneStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSkinPen1
            // 
            this.dSkinPen1.Color = System.Drawing.Color.White;
            this.dSkinPen1.CompoundArray = new float[0];
            this.dSkinPen1.DashPattern = new float[0];
            this.dSkinPen1.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            // 
            // dSkinTableLayoutPanelGimbal
            // 
            this.dSkinTableLayoutPanelGimbal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTableLayoutPanelGimbal.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTableLayoutPanelGimbal.BitmapCache = false;
            this.dSkinTableLayoutPanelGimbal.ColumnCount = 3;
            this.dSkinTableLayoutPanelGimbal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dSkinTableLayoutPanelGimbal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dSkinTableLayoutPanelGimbal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton5, 1, 0);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton6, 1, 2);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton7, 0, 1);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton8, 2, 1);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton9, 1, 1);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton3, 2, 4);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton2, 2, 5);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton11, 2, 0);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton12, 0, 2);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton10, 2, 6);
            this.dSkinTableLayoutPanelGimbal.Controls.Add(this.dSkinButton13, 2, 2);
            this.dSkinTableLayoutPanelGimbal.Location = new System.Drawing.Point(784, 12);
            this.dSkinTableLayoutPanelGimbal.Name = "dSkinTableLayoutPanelGimbal";
            this.dSkinTableLayoutPanelGimbal.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanelGimbal.RightBottom")));
            this.dSkinTableLayoutPanelGimbal.RowCount = 7;
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dSkinTableLayoutPanelGimbal.Size = new System.Drawing.Size(219, 581);
            this.dSkinTableLayoutPanelGimbal.TabIndex = 9;
            this.dSkinTableLayoutPanelGimbal.Visible = false;
            // 
            // dSkinButton5
            // 
            this.dSkinButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton5.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton5.ButtonBorderWidth = 1;
            this.dSkinButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton5.ForeColor = System.Drawing.Color.White;
            this.dSkinButton5.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton5.HoverImage = global::droneDockDataCenter.Properties.Resources.up_arrow_hover;
            this.dSkinButton5.Location = new System.Drawing.Point(77, 15);
            this.dSkinButton5.Name = "dSkinButton5";
            this.dSkinButton5.NormalImage = global::droneDockDataCenter.Properties.Resources.up_arrow;
            this.dSkinButton5.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton5.PressedImage = null;
            this.dSkinButton5.Radius = 50;
            this.dSkinButton5.ShowButtonBorder = true;
            this.dSkinButton5.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton5.TabIndex = 9;
            this.dSkinButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton5.TextPadding = 0;
            this.dSkinButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton5_MouseDown);
            this.dSkinButton5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove_MouseUp);
            // 
            // dSkinButton6
            // 
            this.dSkinButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton6.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton6.ButtonBorderWidth = 1;
            this.dSkinButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton6.ForeColor = System.Drawing.Color.White;
            this.dSkinButton6.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton6.HoverImage = global::droneDockDataCenter.Properties.Resources.down_arrow_hover;
            this.dSkinButton6.Location = new System.Drawing.Point(77, 181);
            this.dSkinButton6.Name = "dSkinButton6";
            this.dSkinButton6.NormalImage = global::droneDockDataCenter.Properties.Resources.down_arrow;
            this.dSkinButton6.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton6.PressedImage = null;
            this.dSkinButton6.Radius = 50;
            this.dSkinButton6.ShowButtonBorder = true;
            this.dSkinButton6.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton6.TabIndex = 10;
            this.dSkinButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton6.TextPadding = 0;
            this.dSkinButton6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton6_MouseDown);
            this.dSkinButton6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove_MouseUp);
            // 
            // dSkinButton7
            // 
            this.dSkinButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton7.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton7.ButtonBorderWidth = 1;
            this.dSkinButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton7.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton7.ForeColor = System.Drawing.Color.White;
            this.dSkinButton7.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton7.HoverImage = global::droneDockDataCenter.Properties.Resources.left_arrow_hover;
            this.dSkinButton7.Location = new System.Drawing.Point(4, 98);
            this.dSkinButton7.Name = "dSkinButton7";
            this.dSkinButton7.NormalImage = global::droneDockDataCenter.Properties.Resources.left_arrow;
            this.dSkinButton7.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton7.PressedImage = null;
            this.dSkinButton7.Radius = 50;
            this.dSkinButton7.ShowButtonBorder = true;
            this.dSkinButton7.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton7.TabIndex = 11;
            this.dSkinButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton7.TextPadding = 0;
            this.dSkinButton7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton7_MouseDown);
            this.dSkinButton7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove_MouseUp);
            // 
            // dSkinButton8
            // 
            this.dSkinButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton8.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton8.ButtonBorderWidth = 1;
            this.dSkinButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton8.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton8.ForeColor = System.Drawing.Color.White;
            this.dSkinButton8.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton8.HoverImage = global::droneDockDataCenter.Properties.Resources.right_arrow__hover;
            this.dSkinButton8.Location = new System.Drawing.Point(151, 98);
            this.dSkinButton8.Name = "dSkinButton8";
            this.dSkinButton8.NormalImage = global::droneDockDataCenter.Properties.Resources.right_arrow;
            this.dSkinButton8.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton8.PressedImage = null;
            this.dSkinButton8.Radius = 50;
            this.dSkinButton8.ShowButtonBorder = true;
            this.dSkinButton8.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton8.TabIndex = 12;
            this.dSkinButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton8.TextPadding = 0;
            this.dSkinButton8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton8_MouseDown);
            this.dSkinButton8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove_MouseUp);
            // 
            // dSkinButton9
            // 
            this.dSkinButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton9.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton9.ButtonBorderWidth = 1;
            this.dSkinButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton9.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton9.ForeColor = System.Drawing.Color.White;
            this.dSkinButton9.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton9.HoverImage = null;
            this.dSkinButton9.Location = new System.Drawing.Point(82, 113);
            this.dSkinButton9.Name = "dSkinButton9";
            this.dSkinButton9.NormalImage = null;
            this.dSkinButton9.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton9.PressedImage = null;
            this.dSkinButton9.Radius = 30;
            this.dSkinButton9.ShowButtonBorder = true;
            this.dSkinButton9.Size = new System.Drawing.Size(60, 50);
            this.dSkinButton9.TabIndex = 13;
            this.dSkinButton9.Text = "Center";
            this.dSkinButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton9.TextPadding = 0;
            this.dSkinButton9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton9_MouseDown);
            this.dSkinButton9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove_MouseUp);
            // 
            // dSkinButton3
            // 
            this.dSkinButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton3.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton3.ButtonBorderWidth = 1;
            this.dSkinButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton3.ForeColor = System.Drawing.Color.White;
            this.dSkinButton3.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton3.HoverImage = null;
            this.dSkinButton3.Location = new System.Drawing.Point(148, 376);
            this.dSkinButton3.Name = "dSkinButton3";
            this.dSkinButton3.NormalImage = null;
            this.dSkinButton3.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton3.PressedImage = null;
            this.dSkinButton3.Radius = 10;
            this.dSkinButton3.ShowButtonBorder = true;
            this.dSkinButton3.Size = new System.Drawing.Size(68, 36);
            this.dSkinButton3.TabIndex = 8;
            this.dSkinButton3.Text = "REC";
            this.dSkinButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton3.TextPadding = 0;
            this.dSkinButton3.Click += new System.EventHandler(this.dSkinButton3_Click);
            // 
            // dSkinButton2
            // 
            this.dSkinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton2.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton2.ButtonBorderWidth = 1;
            this.dSkinButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton2.ForeColor = System.Drawing.Color.White;
            this.dSkinButton2.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton2.HoverImage = null;
            this.dSkinButton2.Location = new System.Drawing.Point(148, 459);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = null;
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = null;
            this.dSkinButton2.Radius = 10;
            this.dSkinButton2.ShowButtonBorder = true;
            this.dSkinButton2.Size = new System.Drawing.Size(68, 36);
            this.dSkinButton2.TabIndex = 6;
            this.dSkinButton2.Text = "Play";
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextPadding = 0;
            this.dSkinButton2.Click += new System.EventHandler(this.dSkinButton2_Click);
            // 
            // dSkinButton11
            // 
            this.dSkinButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dSkinButton11.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton11.ButtonBorderWidth = 1;
            this.dSkinButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton11.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton11.ForeColor = System.Drawing.Color.White;
            this.dSkinButton11.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton11.HoverImage = null;
            this.dSkinButton11.Location = new System.Drawing.Point(148, 44);
            this.dSkinButton11.Name = "dSkinButton11";
            this.dSkinButton11.NormalImage = null;
            this.dSkinButton11.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton11.PressedImage = null;
            this.dSkinButton11.Radius = 10;
            this.dSkinButton11.ShowButtonBorder = true;
            this.dSkinButton11.Size = new System.Drawing.Size(66, 36);
            this.dSkinButton11.TabIndex = 15;
            this.dSkinButton11.Text = "Conn";
            this.dSkinButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton11.TextPadding = 0;
            this.dSkinButton11.Click += new System.EventHandler(this.dSkinButton11_Click);
            // 
            // dSkinButton12
            // 
            this.dSkinButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton12.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton12.ButtonBorderWidth = 1;
            this.dSkinButton12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton12.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton12.ForeColor = System.Drawing.Color.White;
            this.dSkinButton12.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton12.HoverImage = global::droneDockDataCenter.Properties.Resources.zoom_in_hover;
            this.dSkinButton12.Location = new System.Drawing.Point(4, 181);
            this.dSkinButton12.Name = "dSkinButton12";
            this.dSkinButton12.NormalImage = global::droneDockDataCenter.Properties.Resources.zoom_in;
            this.dSkinButton12.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton12.PressedImage = null;
            this.dSkinButton12.Radius = 10;
            this.dSkinButton12.ShowButtonBorder = true;
            this.dSkinButton12.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton12.TabIndex = 16;
            this.dSkinButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton12.TextPadding = 0;
            this.dSkinButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton12_MouseDown);
            this.dSkinButton12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopZoom_MouseUp);
            // 
            // dSkinButton10
            // 
            this.dSkinButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dSkinButton10.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton10.ButtonBorderWidth = 1;
            this.dSkinButton10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton10.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton10.ForeColor = System.Drawing.Color.White;
            this.dSkinButton10.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton10.HoverImage = null;
            this.dSkinButton10.Location = new System.Drawing.Point(148, 542);
            this.dSkinButton10.Name = "dSkinButton10";
            this.dSkinButton10.NormalImage = null;
            this.dSkinButton10.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton10.PressedImage = null;
            this.dSkinButton10.Radius = 10;
            this.dSkinButton10.ShowButtonBorder = true;
            this.dSkinButton10.Size = new System.Drawing.Size(66, 36);
            this.dSkinButton10.TabIndex = 14;
            this.dSkinButton10.Text = "Get Url";
            this.dSkinButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton10.TextPadding = 0;
            this.dSkinButton10.Click += new System.EventHandler(this.dSkinButton10_Click);
            // 
            // dSkinButton13
            // 
            this.dSkinButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton13.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton13.ButtonBorderWidth = 1;
            this.dSkinButton13.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton13.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton13.ForeColor = System.Drawing.Color.White;
            this.dSkinButton13.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton13.HoverImage = global::droneDockDataCenter.Properties.Resources.zoom_out_hover;
            this.dSkinButton13.Location = new System.Drawing.Point(151, 181);
            this.dSkinButton13.Name = "dSkinButton13";
            this.dSkinButton13.NormalImage = global::droneDockDataCenter.Properties.Resources.zoom_out;
            this.dSkinButton13.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton13.PressedImage = null;
            this.dSkinButton13.Radius = 10;
            this.dSkinButton13.ShowButtonBorder = true;
            this.dSkinButton13.Size = new System.Drawing.Size(65, 65);
            this.dSkinButton13.TabIndex = 17;
            this.dSkinButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton13.TextPadding = 0;
            this.dSkinButton13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinButton13_MouseDown);
            this.dSkinButton13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopZoom_MouseUp);
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
            this.dSkinTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.dSkinTabControl1_Selecting);
            // 
            // dSkinTabPage1
            // 
            this.dSkinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage1.Controls.Add(this.dSkinCheckBoxFollowDrone);
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
            // dSkinTabPage2
            // 
            this.dSkinTabPage2.BackColor = System.Drawing.Color.Transparent;
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
            // dSkinTableLayoutPanelDroneCMD
            // 
            this.dSkinTableLayoutPanelDroneCMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTableLayoutPanelDroneCMD.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTableLayoutPanelDroneCMD.BitmapCache = false;
            this.dSkinTableLayoutPanelDroneCMD.Borders.AllColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanelDroneCMD.Borders.BottomColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanelDroneCMD.Borders.LeftColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanelDroneCMD.Borders.LeftWidth = 0;
            this.dSkinTableLayoutPanelDroneCMD.Borders.RightColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanelDroneCMD.Borders.RightWidth = 0;
            this.dSkinTableLayoutPanelDroneCMD.Borders.TopColor = System.Drawing.Color.White;
            this.dSkinTableLayoutPanelDroneCMD.Borders.TopWidth = 0;
            this.dSkinTableLayoutPanelDroneCMD.ColumnCount = 2;
            this.dSkinTableLayoutPanelDroneCMD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanelDroneCMD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton17, 0, 3);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton1, 1, 3);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButtonRTL, 1, 0);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButtonTkoff, 0, 0);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton4, 0, 1);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton14, 1, 1);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton15, 0, 2);
            this.dSkinTableLayoutPanelDroneCMD.Controls.Add(this.dSkinButton16, 1, 2);
            this.dSkinTableLayoutPanelDroneCMD.Location = new System.Drawing.Point(784, 229);
            this.dSkinTableLayoutPanelDroneCMD.Name = "dSkinTableLayoutPanelDroneCMD";
            this.dSkinTableLayoutPanelDroneCMD.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanelDroneCMD.RightBottom")));
            this.dSkinTableLayoutPanelDroneCMD.RowCount = 4;
            this.dSkinTableLayoutPanelDroneCMD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanelDroneCMD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanelDroneCMD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanelDroneCMD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dSkinTableLayoutPanelDroneCMD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dSkinTableLayoutPanelDroneCMD.Size = new System.Drawing.Size(219, 367);
            this.dSkinTableLayoutPanelDroneCMD.TabIndex = 4;
            // 
            // dSkinButton17
            // 
            this.dSkinButton17.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton17.ButtonBorderWidth = 1;
            this.dSkinButton17.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton17.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton17.ForeColor = System.Drawing.Color.White;
            this.dSkinButton17.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton17.HoverImage = null;
            this.dSkinButton17.Location = new System.Drawing.Point(3, 276);
            this.dSkinButton17.Name = "dSkinButton17";
            this.dSkinButton17.NormalImage = null;
            this.dSkinButton17.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton17.PressedImage = null;
            this.dSkinButton17.Radius = 10;
            this.dSkinButton17.ShowButtonBorder = true;
            this.dSkinButton17.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton17.TabIndex = 11;
            this.dSkinButton17.Text = "Drop";
            this.dSkinButton17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton17.TextPadding = 0;
            this.dSkinButton17.Click += new System.EventHandler(this.dSkinButton17_Click);
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 11F);
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
            // dSkinButtonRTL
            // 
            this.dSkinButtonRTL.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButtonRTL.ButtonBorderWidth = 1;
            this.dSkinButtonRTL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButtonRTL.Font = new System.Drawing.Font("微软雅黑", 11F);
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
            this.dSkinButtonTkoff.Font = new System.Drawing.Font("微软雅黑", 11F);
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
            // dSkinButton4
            // 
            this.dSkinButton4.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton4.ButtonBorderWidth = 1;
            this.dSkinButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton4.ForeColor = System.Drawing.Color.White;
            this.dSkinButton4.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton4.HoverImage = null;
            this.dSkinButton4.Location = new System.Drawing.Point(3, 94);
            this.dSkinButton4.Name = "dSkinButton4";
            this.dSkinButton4.NormalImage = null;
            this.dSkinButton4.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton4.PressedImage = null;
            this.dSkinButton4.Radius = 10;
            this.dSkinButton4.ShowButtonBorder = true;
            this.dSkinButton4.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton4.TabIndex = 7;
            this.dSkinButton4.Text = "Get WPs";
            this.dSkinButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton4.TextPadding = 0;
            this.dSkinButton4.Click += new System.EventHandler(this.dSkinButton4_Click);
            // 
            // dSkinButton14
            // 
            this.dSkinButton14.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton14.ButtonBorderWidth = 1;
            this.dSkinButton14.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton14.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton14.ForeColor = System.Drawing.Color.White;
            this.dSkinButton14.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton14.HoverImage = null;
            this.dSkinButton14.Location = new System.Drawing.Point(112, 94);
            this.dSkinButton14.Name = "dSkinButton14";
            this.dSkinButton14.NormalImage = null;
            this.dSkinButton14.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton14.PressedImage = null;
            this.dSkinButton14.Radius = 10;
            this.dSkinButton14.ShowButtonBorder = true;
            this.dSkinButton14.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton14.TabIndex = 8;
            this.dSkinButton14.Text = "Star Mission";
            this.dSkinButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton14.TextPadding = 0;
            this.dSkinButton14.Click += new System.EventHandler(this.dSkinButton14_Click);
            // 
            // dSkinButton15
            // 
            this.dSkinButton15.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton15.ButtonBorderWidth = 1;
            this.dSkinButton15.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton15.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton15.ForeColor = System.Drawing.Color.White;
            this.dSkinButton15.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton15.HoverImage = null;
            this.dSkinButton15.Location = new System.Drawing.Point(3, 185);
            this.dSkinButton15.Name = "dSkinButton15";
            this.dSkinButton15.NormalImage = null;
            this.dSkinButton15.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton15.PressedImage = null;
            this.dSkinButton15.Radius = 10;
            this.dSkinButton15.ShowButtonBorder = true;
            this.dSkinButton15.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton15.TabIndex = 9;
            this.dSkinButton15.Text = "Pause Mission";
            this.dSkinButton15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton15.TextPadding = 0;
            this.dSkinButton15.Click += new System.EventHandler(this.dSkinButton15_Click);
            // 
            // dSkinButton16
            // 
            this.dSkinButton16.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton16.ButtonBorderWidth = 1;
            this.dSkinButton16.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton16.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton16.ForeColor = System.Drawing.Color.White;
            this.dSkinButton16.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton16.HoverImage = null;
            this.dSkinButton16.Location = new System.Drawing.Point(112, 185);
            this.dSkinButton16.Name = "dSkinButton16";
            this.dSkinButton16.NormalImage = null;
            this.dSkinButton16.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton16.PressedImage = null;
            this.dSkinButton16.Radius = 10;
            this.dSkinButton16.ShowButtonBorder = true;
            this.dSkinButton16.Size = new System.Drawing.Size(98, 34);
            this.dSkinButton16.TabIndex = 10;
            this.dSkinButton16.Text = "Continue Mission";
            this.dSkinButton16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton16.TextPadding = 0;
            this.dSkinButton16.Click += new System.EventHandler(this.dSkinButton16_Click);
            // 
            // dSkinGroupBoxDroneStatus
            // 
            this.dSkinGroupBoxDroneStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinGroupBoxDroneStatus.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBoxDroneStatus.BorderColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBoxDroneStatus.Borders.AllWidth = 0;
            this.dSkinGroupBoxDroneStatus.Borders.BottomPen = this.dSkinPen1;
            this.dSkinGroupBoxDroneStatus.Borders.BottomWidth = 3;
            this.dSkinGroupBoxDroneStatus.Borders.LeftWidth = 0;
            this.dSkinGroupBoxDroneStatus.Borders.RightWidth = 0;
            this.dSkinGroupBoxDroneStatus.Borders.TopWidth = 0;
            this.dSkinGroupBoxDroneStatus.Controls.Add(this.dSkinLabel5);
            this.dSkinGroupBoxDroneStatus.Controls.Add(this.dSkinLabel4);
            this.dSkinGroupBoxDroneStatus.Controls.Add(this.dSkinLabel3);
            this.dSkinGroupBoxDroneStatus.Controls.Add(this.dSkinLabel2);
            this.dSkinGroupBoxDroneStatus.Controls.Add(this.dSkinLabel1);
            this.dSkinGroupBoxDroneStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.dSkinGroupBoxDroneStatus.ForeColor = System.Drawing.Color.White;
            this.dSkinGroupBoxDroneStatus.Location = new System.Drawing.Point(784, 11);
            this.dSkinGroupBoxDroneStatus.Name = "dSkinGroupBoxDroneStatus";
            this.dSkinGroupBoxDroneStatus.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinGroupBoxDroneStatus.RightBottom")));
            this.dSkinGroupBoxDroneStatus.Size = new System.Drawing.Size(219, 212);
            this.dSkinGroupBoxDroneStatus.TabIndex = 7;
            this.dSkinGroupBoxDroneStatus.Text = "Drone Status";
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
            // dSkinCheckBoxFollowDrone
            // 
            this.dSkinCheckBoxFollowDrone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dSkinCheckBoxFollowDrone.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinCheckBoxFollowDrone.Checked = false;
            this.dSkinCheckBoxFollowDrone.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.dSkinCheckBoxFollowDrone.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBoxFollowDrone.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.dSkinCheckBoxFollowDrone.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.dSkinCheckBoxFollowDrone.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.dSkinCheckBoxFollowDrone.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.dSkinCheckBoxFollowDrone.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.dSkinCheckBoxFollowDrone.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBoxFollowDrone.CheckRectWidth = 14;
            this.dSkinCheckBoxFollowDrone.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.dSkinCheckBoxFollowDrone.ForeColor = System.Drawing.Color.Black;
            this.dSkinCheckBoxFollowDrone.InnerPaddingWidth = 2;
            this.dSkinCheckBoxFollowDrone.InnerRectInflate = 3;
            this.dSkinCheckBoxFollowDrone.Location = new System.Drawing.Point(3, 539);
            this.dSkinCheckBoxFollowDrone.Name = "dSkinCheckBoxFollowDrone";
            this.dSkinCheckBoxFollowDrone.Size = new System.Drawing.Size(109, 21);
            this.dSkinCheckBoxFollowDrone.SpaceBetweenCheckMarkAndText = 3;
            this.dSkinCheckBoxFollowDrone.TabIndex = 4;
            this.dSkinCheckBoxFollowDrone.Text = "Drone Center";
            this.dSkinCheckBoxFollowDrone.TextColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBoxFollowDrone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            // DockDetailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dSkinTableLayoutPanelGimbal);
            this.Controls.Add(this.dSkinTabControl1);
            this.Controls.Add(this.dSkinTableLayoutPanelDroneCMD);
            this.Controls.Add(this.dSkinGroupBoxDroneStatus);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DockDetailPanel";
            this.Size = new System.Drawing.Size(1006, 599);
            this.dSkinTableLayoutPanelGimbal.ResumeLayout(false);
            this.dSkinTabControl1.ResumeLayout(false);
            this.dSkinTabPage1.ResumeLayout(false);
            this.dSkinTabPage1.PerformLayout();
            this.dSkinTabPage2.ResumeLayout(false);
            this.dSkinTableLayoutPanelDroneCMD.ResumeLayout(false);
            this.dSkinGroupBoxDroneStatus.ResumeLayout(false);
            this.dSkinGroupBoxDroneStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private HUDControl hudControl1;
        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.Controls.DSkinGroupBox dSkinGroupBoxDroneStatus;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanelDroneCMD;
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
        private DSkin.Controls.DSkinButton dSkinButton3;
        private DSkin.Controls.DSkinButton dSkinButton4;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanelGimbal;
        private DSkin.Controls.DSkinButton dSkinButton5;
        private DSkin.Controls.DSkinButton dSkinButton6;
        private DSkin.Controls.DSkinButton dSkinButton7;
        private DSkin.Controls.DSkinButton dSkinButton8;
        private DSkin.Controls.DSkinButton dSkinButton9;
        private DSkin.Controls.DSkinButton dSkinButton10;
        private DSkin.Controls.DSkinButton dSkinButton11;
        private DSkin.Controls.DSkinButton dSkinButton12;
        private DSkin.Controls.DSkinButton dSkinButton13;
        private DSkin.Controls.DSkinButton dSkinButton17;
        private DSkin.Controls.DSkinButton dSkinButton14;
        private DSkin.Controls.DSkinButton dSkinButton15;
        private DSkin.Controls.DSkinButton dSkinButton16;
        private DSkin.Controls.DSkinCheckBox dSkinCheckBoxFollowDrone;
    }
}
