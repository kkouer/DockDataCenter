using droneDockDataCenter.Modle;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter.Controls
{
    public partial class DocksList : UserControl
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DocksList));
        List<Dock> docks = new List<Dock>();

        public event EventHandler DockCoverCloseCommand;
        public event EventHandler DockCoverOpenCommand;
        public event EventHandler DockHomingCommand;
        public DocksList()
        {
            InitializeComponent();
            initListView();
        }

        public event Action<Dock> DockItemDoubleClick;
        public event Action<Dock> DockItemClick;

        public void listview1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string dockId = selectedItem.Text;

                Dock selectedDock = docks.FirstOrDefault(d => d.Id == dockId);
                if (selectedDock != null)
                {
                    DockItemDoubleClick?.Invoke(selectedDock);
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string dockId = selectedItem.Text;

                Dock selectedDock = docks.FirstOrDefault(d => d.Id == dockId);
                if (selectedDock != null)
                {
                    DockItemClick?.Invoke(selectedDock);
                }
            }
        }



        private void initListView()
        {
            listView1.Columns.Add("Dock ID", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Alive", 100, HorizontalAlignment.Center);

            // 添加图标到 ImageList
            imageList1.Images.Add("dock_offline", Properties.Resources.dock);
            imageList1.Images.Add("dock_online", Properties.Resources.dock_online);

            listView1.SmallImageList = imageList1;

            foreach (var dock in docks)
            {
                ListViewItem item = new ListViewItem(dock.Id); // 添加 Dock ID
                item.SubItems.Add(dock.IsOnLine() ? "连接" : "断开"); // 添加连接状态
                item.ImageKey = dock.IsOnLine() ? "dock_online" : "dock_offline";
                listView1.Items.Add(item); // 添加项到 ListView
            }
            logger.Info("initListView");
        }

        
        public void UpdateDockManager(DockManager dockManager)
        {
            this.docks = dockManager.docks;
            UpdateListView();

            updateDockInfoText(dockManager);
        }

        private void updateDockInfoText(DockManager manager)
        {
            if(manager != null && manager.CurrentDock != null)
            {
                TBDockId = "ID: " + manager.CurrentDock.Id;
                TBDockCover = "Cover: " + manager.CurrentDock.CoverStatus;
                TBDockTime = "Time: " + manager.CurrentDock.LastUpdated.ToString();
                TBDockWeaterWindSpeed = "Wind speed: " + manager.CurrentDock.WeatherData.WindSpeed.ToString();
                TBDockWeaterTemperature = "Temp inside: " + manager.CurrentDock.WeatherData.TemperatureInside.ToString("0.0℃");
            }
        }

        public string TBDockId
        {

            set { dSkinLabel1.Text = value; }

        }
        public string TBDockCover
        {

            set { dSkinLabel2.Text = value; }

        }

        public string TBDockTime
        {

            set { dSkinLabel3.Text = value; }

        }
        public string TBDockWeaterWindSpeed
        {

            set { dSkinLabel4.Text = value; }

        }
        public string TBDockWeaterTemperature
        {

            set { dSkinLabel5.Text = value; }

        }



        //private void StartRefreshThread()
        //{
        //    Task.Run(async () =>
        //    {
        //        while (true)
        //        {
        //            await Task.Delay(2000); // 2秒刷新一次

        //            // 刷新ListView
        //            UpdateListView();
        //        }
        //    });
        //}


        private void UpdateListView()
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new MethodInvoker(UpdateListView));
                return;
            }
            int selectedIndex = listView1.SelectedIndices.Count > 0 ? listView1.SelectedIndices[0] : -1;

            listView1.Items.Clear();

            foreach (var dock in docks)
            {
                ListViewItem item = new ListViewItem(dock.Id); // 添加 Dock ID
                item.SubItems.Add(dock.IsOnLine() ? "连接" : "断开"); // 添加连接状态
                item.ImageKey = dock.IsOnLine() ? "dock_online" : "dock_offline";
                listView1.Items.Add(item); // 添加项到 ListView
            }
            if (selectedIndex != -1 && selectedIndex < listView1.Items.Count)
            {
                listView1.Items[selectedIndex].Selected = true;
            }
            logger.Info("UpdateListView");
        }

        private void DocksList_Load(object sender, EventArgs e)
        {
            // 启动刷新线程
            //StartRefreshThread();
        }

        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            DockCoverOpenCommand?.Invoke(this, EventArgs.Empty);
            logger.Info("DockCoverOpenCommand");

        }

        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            DockCoverCloseCommand?.Invoke(this, EventArgs.Empty);
            logger.Info("DockCoverCloseCommand");

        }

        private void dSkinButton3_Click(object sender, EventArgs e)
        {
            DockHomingCommand?.Invoke(this, EventArgs.Empty);
            logger.Info("DockHomingCommand");
        }

        private void dSkinButtonSetValue_Click(object sender, EventArgs e)
        {

        }
    }
}
