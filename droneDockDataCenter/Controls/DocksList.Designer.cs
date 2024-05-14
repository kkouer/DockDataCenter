namespace droneDockDataCenter.Controls
{
    partial class DocksList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocksList));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dSkinPenboard = new DSkin.Controls.DSkinPen(this.components);
            this.dSkinTableLayoutPanel1 = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.dSkinGroupBox1 = new DSkin.Controls.DSkinGroupBox();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.valueModControl1 = new droneDockDataCenter.Controls.ValueModControl();
            this.valueModControl2 = new droneDockDataCenter.Controls.ValueModControl();
            this.valueModControl3 = new droneDockDataCenter.Controls.ValueModControl();
            this.valueModControl4 = new droneDockDataCenter.Controls.ValueModControl();
            this.dSkinButtonSetValue = new DSkin.Controls.DSkinButton();
            this.dSkinButton3 = new DSkin.Controls.DSkinButton();
            this.dSkinTableLayoutPanel1.SuspendLayout();
            this.dSkinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 506);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listview1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dSkinPenboard
            // 
            this.dSkinPenboard.Color = System.Drawing.Color.White;
            this.dSkinPenboard.CompoundArray = new float[0];
            this.dSkinPenboard.DashPattern = new float[0];
            this.dSkinPenboard.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
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
            this.dSkinTableLayoutPanel1.ColumnCount = 3;
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButton2, 0, 0);
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButton1, 1, 0);
            this.dSkinTableLayoutPanel1.Controls.Add(this.valueModControl1, 0, 2);
            this.dSkinTableLayoutPanel1.Controls.Add(this.valueModControl2, 0, 3);
            this.dSkinTableLayoutPanel1.Controls.Add(this.valueModControl3, 0, 4);
            this.dSkinTableLayoutPanel1.Controls.Add(this.valueModControl4, 0, 5);
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButtonSetValue, 2, 5);
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinButton3, 0, 1);
            this.dSkinTableLayoutPanel1.Location = new System.Drawing.Point(531, 222);
            this.dSkinTableLayoutPanel1.Name = "dSkinTableLayoutPanel1";
            this.dSkinTableLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanel1.RightBottom")));
            this.dSkinTableLayoutPanel1.RowCount = 6;
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dSkinTableLayoutPanel1.Size = new System.Drawing.Size(212, 297);
            this.dSkinTableLayoutPanel1.TabIndex = 3;
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
            this.dSkinButton2.Location = new System.Drawing.Point(3, 3);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = null;
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = null;
            this.dSkinButton2.Radius = 10;
            this.dSkinButton2.ShowButtonBorder = true;
            this.dSkinButton2.Size = new System.Drawing.Size(64, 43);
            this.dSkinButton2.TabIndex = 7;
            this.dSkinButton2.Text = "Cover open";
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextPadding = 0;
            this.dSkinButton2.Click += new System.EventHandler(this.dSkinButton2_Click);
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButton1.ForeColor = System.Drawing.Color.White;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.Location = new System.Drawing.Point(73, 3);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(64, 43);
            this.dSkinButton1.TabIndex = 8;
            this.dSkinButton1.Text = "Cover close";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.Click += new System.EventHandler(this.dSkinButton1_Click);
            // 
            // dSkinGroupBox1
            // 
            this.dSkinGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.Borders.AllWidth = 0;
            this.dSkinGroupBox1.Borders.BottomPen = this.dSkinPenboard;
            this.dSkinGroupBox1.Borders.BottomWidth = 3;
            this.dSkinGroupBox1.Borders.LeftWidth = 0;
            this.dSkinGroupBox1.Borders.RightWidth = 0;
            this.dSkinGroupBox1.Borders.TopWidth = 3;
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel5);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel4);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel3);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel2);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel1);
            this.dSkinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGroupBox1.ForeColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Location = new System.Drawing.Point(531, 3);
            this.dSkinGroupBox1.Name = "dSkinGroupBox1";
            this.dSkinGroupBox1.Radius = 20;
            this.dSkinGroupBox1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinGroupBox1.RightBottom")));
            this.dSkinGroupBox1.Size = new System.Drawing.Size(212, 212);
            this.dSkinGroupBox1.TabIndex = 2;
            this.dSkinGroupBox1.Text = "Dock Status";
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.EffectValue = 1;
            this.dSkinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel5.Location = new System.Drawing.Point(23, 171);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(97, 21);
            this.dSkinLabel5.TabIndex = 0;
            this.dSkinLabel5.Text = "Temperature:";
            this.dSkinLabel5.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.EffectValue = 1;
            this.dSkinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel4.Location = new System.Drawing.Point(23, 136);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(91, 21);
            this.dSkinLabel4.TabIndex = 0;
            this.dSkinLabel4.Text = "Wind speed:";
            this.dSkinLabel4.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.EffectValue = 1;
            this.dSkinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel3.Location = new System.Drawing.Point(23, 101);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(71, 21);
            this.dSkinLabel3.TabIndex = 0;
            this.dSkinLabel3.Text = "Last time:";
            this.dSkinLabel3.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.EffectValue = 1;
            this.dSkinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel2.Location = new System.Drawing.Point(23, 66);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(94, 21);
            this.dSkinLabel2.TabIndex = 0;
            this.dSkinLabel2.Text = "Cover status:";
            this.dSkinLabel2.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.EffectValue = 1;
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinLabel1.Location = new System.Drawing.Point(23, 31);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(24, 21);
            this.dSkinLabel1.TabIndex = 0;
            this.dSkinLabel1.Text = "ID:";
            this.dSkinLabel1.TextEffect = DSkin.DirectUI.TextEffects.Shadow;
            // 
            // valueModControl1
            // 
            this.valueModControl1.BackColor = System.Drawing.Color.Transparent;
            this.valueModControl1.BitmapCache = false;
            this.dSkinTableLayoutPanel1.SetColumnSpan(this.valueModControl1, 2);
            this.valueModControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valueModControl1.InfoValue = "Rain:";
            this.valueModControl1.Location = new System.Drawing.Point(4, 102);
            this.valueModControl1.Margin = new System.Windows.Forms.Padding(4);
            this.valueModControl1.Name = "valueModControl1";
            this.valueModControl1.RightBottom = ((System.Drawing.Image)(resources.GetObject("valueModControl1.RightBottom")));
            this.valueModControl1.Size = new System.Drawing.Size(132, 41);
            this.valueModControl1.TabIndex = 9;
            // 
            // valueModControl2
            // 
            this.valueModControl2.BackColor = System.Drawing.Color.Transparent;
            this.valueModControl2.BitmapCache = false;
            this.dSkinTableLayoutPanel1.SetColumnSpan(this.valueModControl2, 2);
            this.valueModControl2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valueModControl2.InfoValue = "Temperature:";
            this.valueModControl2.Location = new System.Drawing.Point(4, 151);
            this.valueModControl2.Margin = new System.Windows.Forms.Padding(4);
            this.valueModControl2.Name = "valueModControl2";
            this.valueModControl2.RightBottom = ((System.Drawing.Image)(resources.GetObject("valueModControl2.RightBottom")));
            this.valueModControl2.Size = new System.Drawing.Size(132, 41);
            this.valueModControl2.TabIndex = 9;
            // 
            // valueModControl3
            // 
            this.valueModControl3.BackColor = System.Drawing.Color.Transparent;
            this.valueModControl3.BitmapCache = false;
            this.dSkinTableLayoutPanel1.SetColumnSpan(this.valueModControl3, 2);
            this.valueModControl3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valueModControl3.InfoValue = "WInd:";
            this.valueModControl3.Location = new System.Drawing.Point(4, 200);
            this.valueModControl3.Margin = new System.Windows.Forms.Padding(4);
            this.valueModControl3.Name = "valueModControl3";
            this.valueModControl3.RightBottom = ((System.Drawing.Image)(resources.GetObject("valueModControl3.RightBottom")));
            this.valueModControl3.Size = new System.Drawing.Size(132, 41);
            this.valueModControl3.TabIndex = 9;
            // 
            // valueModControl4
            // 
            this.valueModControl4.BackColor = System.Drawing.Color.Transparent;
            this.valueModControl4.BitmapCache = false;
            this.dSkinTableLayoutPanel1.SetColumnSpan(this.valueModControl4, 2);
            this.valueModControl4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valueModControl4.InfoValue = "Humidity:";
            this.valueModControl4.Location = new System.Drawing.Point(4, 249);
            this.valueModControl4.Margin = new System.Windows.Forms.Padding(4);
            this.valueModControl4.Name = "valueModControl4";
            this.valueModControl4.RightBottom = ((System.Drawing.Image)(resources.GetObject("valueModControl4.RightBottom")));
            this.valueModControl4.Size = new System.Drawing.Size(132, 41);
            this.valueModControl4.TabIndex = 10;
            // 
            // dSkinButtonSetValue
            // 
            this.dSkinButtonSetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButtonSetValue.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButtonSetValue.ButtonBorderWidth = 1;
            this.dSkinButtonSetValue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButtonSetValue.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.dSkinButtonSetValue.ForeColor = System.Drawing.Color.White;
            this.dSkinButtonSetValue.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButtonSetValue.HoverImage = null;
            this.dSkinButtonSetValue.Location = new System.Drawing.Point(145, 251);
            this.dSkinButtonSetValue.Name = "dSkinButtonSetValue";
            this.dSkinButtonSetValue.NormalImage = null;
            this.dSkinButtonSetValue.PressColor = System.Drawing.Color.Empty;
            this.dSkinButtonSetValue.PressedImage = null;
            this.dSkinButtonSetValue.Radius = 10;
            this.dSkinButtonSetValue.ShowButtonBorder = true;
            this.dSkinButtonSetValue.Size = new System.Drawing.Size(64, 43);
            this.dSkinButtonSetValue.TabIndex = 11;
            this.dSkinButtonSetValue.Text = "SET";
            this.dSkinButtonSetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButtonSetValue.TextPadding = 0;
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
            this.dSkinButton3.Location = new System.Drawing.Point(3, 52);
            this.dSkinButton3.Name = "dSkinButton3";
            this.dSkinButton3.NormalImage = null;
            this.dSkinButton3.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton3.PressedImage = null;
            this.dSkinButton3.Radius = 10;
            this.dSkinButton3.ShowButtonBorder = true;
            this.dSkinButton3.Size = new System.Drawing.Size(64, 43);
            this.dSkinButton3.TabIndex = 12;
            this.dSkinButton3.Text = "Homing";
            this.dSkinButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton3.TextPadding = 0;
            // 
            // DocksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dSkinTableLayoutPanel1);
            this.Controls.Add(this.dSkinGroupBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocksList";
            this.Size = new System.Drawing.Size(747, 523);
            this.Load += new System.EventHandler(this.DocksList_Load);
            this.dSkinTableLayoutPanel1.ResumeLayout(false);
            this.dSkinGroupBox1.ResumeLayout(false);
            this.dSkinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView listView1;
        private DSkin.Controls.DSkinGroupBox dSkinGroupBox1;
        private DSkin.Controls.DSkinLabel dSkinLabel5;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        private DSkin.Controls.DSkinLabel dSkinLabel2;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinPen dSkinPenboard;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanel1;
        private DSkin.Controls.DSkinButton dSkinButton2;
        private DSkin.Controls.DSkinButton dSkinButton1;
        private ValueModControl valueModControl1;
        private ValueModControl valueModControl2;
        private ValueModControl valueModControl3;
        private ValueModControl valueModControl4;
        private DSkin.Controls.DSkinButton dSkinButtonSetValue;
        private DSkin.Controls.DSkinButton dSkinButton3;
    }
}
