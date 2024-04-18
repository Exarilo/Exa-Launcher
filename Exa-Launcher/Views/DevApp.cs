using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Exa_Launcher.Views
{
    public partial class DevApp : UserControl
    {
        private const int icon_size = 32;
        public DevApp()
        {
            InitializeComponent();
            listViewItems.Columns.Add("Application", 200);
            listViewItems.Columns.Add("Path", 0);

            listViewItems.View = View.LargeIcon;
            listViewItems.LargeImageList = new ImageList();
            listViewItems.LargeImageList.ImageSize = new Size(icon_size, icon_size);
            btAddItem.Click += (s, e) => AddItem();
            listViewItems.Click += (s, e) => listViewItemClicked();
        }

        private void listViewItemClicked()
        {
            if (listViewItems.SelectedItems.Count > 0)
            {
                string appPath = listViewItems.SelectedItems[0].SubItems[1].Text;
                Process.Start(appPath);
            }
        }

        private void AddItem()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Applications (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.Title = "Select an Application";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedAppPath = openFileDialog.FileName;
                AddAppToListView(selectedAppPath);
            }
        }
        private void AddAppToListView(string appPath)
        {
            string appName = Path.GetFileNameWithoutExtension(appPath);
            Icon appIcon = Icon.ExtractAssociatedIcon(appPath);
            Bitmap resizedIcon = new Bitmap(appIcon.ToBitmap(), new Size(icon_size, icon_size));
            listViewItems.LargeImageList.Images.Add(resizedIcon);
            ListViewItem item = new ListViewItem(appName, listViewItems.LargeImageList.Images.Count - 1); 
            item.SubItems.Add(appPath);
            listViewItems.Items.Add(item);
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            string appPath = (string)clickedButton.Tag;
            Process.Start(appPath);
        }
    }
}
