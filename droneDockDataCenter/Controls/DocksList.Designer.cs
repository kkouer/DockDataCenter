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
            this.dSkinGroupBox1 = new DSkin.Controls.DSkinGroupBox();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.dSkinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // dSkinGroupBox1
            // 
            this.dSkinGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel5);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel4);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel3);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel2);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel1);
            this.dSkinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGroupBox1.Location = new System.Drawing.Point(531, 3);
            this.dSkinGroupBox1.Name = "dSkinGroupBox1";
            this.dSkinGroupBox1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinGroupBox1.RightBottom")));
            this.dSkinGroupBox1.Size = new System.Drawing.Size(200, 212);
            this.dSkinGroupBox1.TabIndex = 2;
            this.dSkinGroupBox1.Text = "Dock Status";
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(23, 31);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(24, 21);
            this.dSkinLabel1.TabIndex = 0;
            this.dSkinLabel1.Text = "ID:";
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel2.Location = new System.Drawing.Point(23, 66);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(94, 21);
            this.dSkinLabel2.TabIndex = 0;
            this.dSkinLabel2.Text = "Cover status:";
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel3.Location = new System.Drawing.Point(23, 101);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(71, 21);
            this.dSkinLabel3.TabIndex = 0;
            this.dSkinLabel3.Text = "Last time:";
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel4.Location = new System.Drawing.Point(23, 136);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(91, 21);
            this.dSkinLabel4.TabIndex = 0;
            this.dSkinLabel4.Text = "Wind speed:";
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel5.Location = new System.Drawing.Point(23, 171);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(97, 21);
            this.dSkinLabel5.TabIndex = 0;
            this.dSkinLabel5.Text = "Temperature:";
            // 
            // DocksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dSkinGroupBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocksList";
            this.Size = new System.Drawing.Size(747, 523);
            this.Load += new System.EventHandler(this.DocksList_Load);
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
    }
}
