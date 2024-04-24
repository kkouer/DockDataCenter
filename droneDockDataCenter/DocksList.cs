using droneDockDataCenter.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter
{
    public partial class DocksList : UserControl
    {
        List<Dock> docks = new List<Dock> 
        { 
            new Dock{ Id = "001", OnLine = true},
            new Dock{ Id = "002", OnLine = false},
            new Dock{ Id = "003", OnLine = true},
            new Dock{ Id = "004", OnLine = true},
            new Dock{ Id = "005", OnLine = true},
            new Dock{ Id = "006", OnLine = true}

        };
        public DocksList()
        {
            InitializeComponent();
            initListView();
        }
        public DocksList(List<Dock> docks)
        {
            InitializeComponent();
            this.docks = docks;
            initListView();
        }

        private void initListView()
        {
            listView1.Columns.Add("Dock ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("连接状态", 100, HorizontalAlignment.Left);

            // 添加图标到 ImageList
            imageList1.Images.Add("dock_offline", Properties.Resources.dock);
            imageList1.Images.Add("dock_online", Properties.Resources.dock_online);

            listView1.SmallImageList = imageList1;

            foreach (var dock in docks)
            {
                ListViewItem item = new ListViewItem(dock.Id); // 添加 Dock ID
                item.SubItems.Add(dock.OnLine ? "连接" : "断开"); // 添加连接状态
                item.ImageKey = dock.OnLine ? "dock_online" : "dock_offline";
                listView1.Items.Add(item); // 添加项到 ListView
            }

        }

        private void StartRefreshThread()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(2000); // 5秒刷新一次

                    // 更新机库状态
                    UpdateDockStatus();

                    // 刷新ListView
                    UpdateListView();
                }
            });
        }

        private void UpdateDockStatus()
        {
            // 模拟更新机库状态
            Random random = new Random();
            foreach (var dock in docks)
            {
                dock.OnLine = random.Next(0, 2) == 1;
            }
        }

        private void UpdateListView()
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new MethodInvoker(UpdateListView));
                return;
            }
            listView1.Items.Clear();

            foreach (var dock in docks)
            {
                ListViewItem item = new ListViewItem(dock.Id); // 添加 Dock ID
                item.SubItems.Add(dock.OnLine ? "连接" : "断开"); // 添加连接状态
                item.ImageKey = dock.OnLine ? "dock_online" : "dock_offline";
                listView1.Items.Add(item); // 添加项到 ListView
            }
        }

        private void DocksList_Load(object sender, EventArgs e)
        {
            // 启动刷新线程
            StartRefreshThread();
        }
    }
}
