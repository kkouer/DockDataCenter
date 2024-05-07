using droneDockDataCenter.Controls;

namespace droneDockDataCenter
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxStatus = new DSkin.Controls.DSkinTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinGroupBox1 = new DSkin.Controls.DSkinGroupBox();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.button1 = new DSkin.Controls.DSkinButton();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.docksList1 = new droneDockDataCenter.Controls.DocksList();
            this.panel1.SuspendLayout();
            this.controlHost1.SuspendLayout();
            this.dSkinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxStatus.BitmapCache = false;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStatus.ForeColor = System.Drawing.Color.White;
            this.textBoxStatus.Location = new System.Drawing.Point(4, 540);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(950, 16);
            this.textBoxStatus.TabIndex = 1;
            this.textBoxStatus.TabStop = false;
            this.textBoxStatus.TransparencyKey = System.Drawing.Color.Empty;
            this.textBoxStatus.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStatus.WaterText = "Info";
            this.textBoxStatus.WaterTextOffset = new System.Drawing.Point(5, 0);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.docksList1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 533);
            this.panel1.TabIndex = 3;
            // 
            // controlHost1
            // 
            this.controlHost1.Controls.Add(this.dSkinGroupBox1);
            this.controlHost1.Controls.Add(this.textBoxStatus);
            this.controlHost1.Controls.Add(this.panel1);
            this.controlHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost1.Location = new System.Drawing.Point(4, 34);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(954, 555);
            this.controlHost1.TabIndex = 4;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinGroupBox1
            // 
            this.dSkinGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.Borders.AllColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Borders.AllWidth = 0;
            this.dSkinGroupBox1.Borders.BottomColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Borders.BottomWidth = 0;
            this.dSkinGroupBox1.Borders.LeftColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Borders.LeftWidth = 2;
            this.dSkinGroupBox1.Borders.RightColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Borders.RightWidth = 0;
            this.dSkinGroupBox1.Borders.TopColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Borders.TopWidth = 0;
            this.dSkinGroupBox1.Controls.Add(this.dSkinButton2);
            this.dSkinGroupBox1.Controls.Add(this.button1);
            this.dSkinGroupBox1.Controls.Add(this.dSkinButton1);
            this.dSkinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGroupBox1.ForeColor = System.Drawing.Color.White;
            this.dSkinGroupBox1.Location = new System.Drawing.Point(816, 3);
            this.dSkinGroupBox1.Name = "dSkinGroupBox1";
            this.dSkinGroupBox1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinGroupBox1.RightBottom")));
            this.dSkinGroupBox1.Size = new System.Drawing.Size(135, 530);
            this.dSkinGroupBox1.TabIndex = 7;
            this.dSkinGroupBox1.Text = "Control Panel";
            // 
            // dSkinButton2
            // 
            this.dSkinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton2.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton2.ButtonBorderWidth = 1;
            this.dSkinButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dSkinButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinButton2.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton2.HoverImage = null;
            this.dSkinButton2.Location = new System.Drawing.Point(6, 439);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = null;
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = null;
            this.dSkinButton2.Radius = 10;
            this.dSkinButton2.ShowButtonBorder = true;
            this.dSkinButton2.Size = new System.Drawing.Size(121, 34);
            this.dSkinButton2.TabIndex = 6;
            this.dSkinButton2.Text = "Settings";
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextPadding = 0;
            this.dSkinButton2.Click += new System.EventHandler(this.dSkinButton2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BaseColor = System.Drawing.Color.SkyBlue;
            this.button1.ButtonBorderWidth = 1;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.HoverColor = System.Drawing.Color.Empty;
            this.button1.HoverImage = null;
            this.button1.Location = new System.Drawing.Point(6, 37);
            this.button1.Name = "button1";
            this.button1.NormalImage = null;
            this.button1.PressColor = System.Drawing.Color.Empty;
            this.button1.PressedImage = null;
            this.button1.Radius = 10;
            this.button1.ShowButtonBorder = true;
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextPadding = 0;
            this.button1.Click += new System.EventHandler(this.buttonConnAndSubscribe_Click);
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dSkinButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.Location = new System.Drawing.Point(6, 493);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(121, 34);
            this.dSkinButton1.TabIndex = 5;
            this.dSkinButton1.Text = "Detail";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // docksList1
            // 
            this.docksList1.BackColor = System.Drawing.Color.Transparent;
            this.docksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docksList1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.docksList1.Location = new System.Drawing.Point(0, 0);
            this.docksList1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.docksList1.Name = "docksList1";
            this.docksList1.Size = new System.Drawing.Size(796, 533);
            this.docksList1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CaptionCenter = true;
            this.CaptionColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionOffset = new System.Drawing.Point(20, 0);
            this.ClientSize = new System.Drawing.Size(962, 593);
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.Controls.Add(this.controlHost1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.HaloColor = System.Drawing.Color.Black;
            this.HaloSize = 3;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.NormalBox.NormalColor = System.Drawing.Color.White;
            this.Radius = 5;
            this.ShowShadow = true;
            this.Text = "DockCenterManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.controlHost1.ResumeLayout(false);
            this.controlHost1.PerformLayout();
            this.dSkinGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DSkin.Controls.DSkinTextBox textBoxStatus;
        private DocksList docksList1;
        private System.Windows.Forms.Panel panel1;
        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinButton button1;
        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.Controls.DSkinButton dSkinButton2;
        private DSkin.Controls.DSkinGroupBox dSkinGroupBox1;
    }
}

