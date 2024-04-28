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
            this.textBox1 = new DSkin.Controls.DSkinTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.button1 = new DSkin.Controls.DSkinButton();
            this.docksList1 = new droneDockDataCenter.Controls.DocksList();
            this.panel1.SuspendLayout();
            this.controlHost1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BitmapCache = false;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 532);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(954, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.textBox1.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.WaterText = "";
            this.textBox1.WaterTextOffset = new System.Drawing.Point(0, 0);
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
            this.controlHost1.Controls.Add(this.dSkinButton1);
            this.controlHost1.Controls.Add(this.button1);
            this.controlHost1.Controls.Add(this.textBox1);
            this.controlHost1.Controls.Add(this.panel1);
            this.controlHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost1.Location = new System.Drawing.Point(4, 34);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(954, 555);
            this.controlHost1.TabIndex = 4;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dSkinButton1.ForeColor = System.Drawing.Color.White;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.Location = new System.Drawing.Point(802, 461);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(152, 64);
            this.dSkinButton1.TabIndex = 5;
            this.dSkinButton1.Text = "Detail";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BaseColor = System.Drawing.Color.SkyBlue;
            this.button1.ButtonBorderWidth = 1;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverColor = System.Drawing.Color.Empty;
            this.button1.HoverImage = null;
            this.button1.Location = new System.Drawing.Point(802, 16);
            this.button1.Name = "button1";
            this.button1.NormalImage = null;
            this.button1.PressColor = System.Drawing.Color.Empty;
            this.button1.PressedImage = null;
            this.button1.Radius = 10;
            this.button1.ShowButtonBorder = true;
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextPadding = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.DrawIcon = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.HaloColor = System.Drawing.Color.Black;
            this.HaloSize = 3;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Radius = 5;
            this.ShowIcon = false;
            this.ShowShadow = true;
            this.Text = "DockCenterManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.controlHost1.ResumeLayout(false);
            this.controlHost1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DSkin.Controls.DSkinTextBox textBox1;
        private DocksList docksList1;
        private System.Windows.Forms.Panel panel1;
        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinButton button1;
        private DSkin.Controls.DSkinButton dSkinButton1;
    }
}

