﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exa_Launcher.Views
{
    //249,242
    public partial class DevApp : UserControl
    {
        public DevApp()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            listViewItems.Columns.Add("Application", 0);
            listViewItems.Columns.Add("Path", 0);
            listViewItems.View = View.LargeIcon;
            listViewItems.LargeImageList = new ImageList();
            listViewItems.LargeImageList.ImageSize =new Size(32,32);
            listViewItems.LargeImageList.ColorDepth = ColorDepth.Depth32Bit; 
            btAddApp.Click += (s, e) => AddItem();
            listViewItems.DoubleClick += (s, e) => listViewItemClicked();
            this.Resize += (s, e) => roundedPanel1.Invalidate();
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
            listViewItems.LargeImageList.Images.Add(appIcon);

            ListViewItem item = new ListViewItem(appName, listViewItems.LargeImageList.Images.Count - 1);
            item.SubItems.Add(appPath);
            listViewItems.Items.Add(item);

            item.ImageIndex = listViewItems.LargeImageList.Images.Count - 1;

        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            string appPath = (string)clickedButton.Tag;
            Process.Start(appPath);
        }
    }
}
