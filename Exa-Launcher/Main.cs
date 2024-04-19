using Exa_Launcher.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Exa_Launcher
{

    public partial class Main : Form
    {
        private Point lastMousePosition;
        private const double OpacityStep = 0.03;
        private const double MinOpacity = 0.5;
        private const double MaxOpacity = 1.0;
        private Dictionary<Button, UserControl> viewMapping { get; set; } = new Dictionary<Button, UserControl>();
        private int splitterPreviousPosition;
        private bool isResizing = false;
        public Main()
        {
            InitializeComponent();
            InitializeViews();
            splitterPreviousPosition = splitter.SplitPosition;
            ChangeView(new DevApp());
            btMinimize.Click += (s, e) => WindowState = FormWindowState.Minimized;
            btMaximize.Click += (s, e) => WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            btClose.Click += (s, e) => Close();
            PanelTopBar.MouseDown += panel_MouseDown;
            PanelTopBar.MouseWheel += PanelTopBar_MouseWheel;
            pbResize.MouseUp += PbResize_MouseUp;
            pbResize.MouseDown += PbResize_MouseDown;
            pbResize.MouseMove += (s, e) => { if (isResizing) ResizeForm(e); };
            splitter.SplitterMoved += OnSplitterMove;
            btAvatar.Click += (s, e) => Process.Start("https://github.com/Exarilo?tab=repositories")?.Close();
            tabDevApp.Click+= (s, e) => ChangeView(new DevApp());
            tabFlux.Click += (s, e) => ChangeView(new test());
            this.KeyDown += HandleKeyDown;
        }
        private void OnSplitterMove(object sender, SplitterEventArgs e)
        {
            int deltaWidth = e.X - splitterPreviousPosition;
            roundedPanel.Width += deltaWidth; 
            splitterPreviousPosition = e.X; 
            roundedPanel.Invalidate(); 
        }

        private void InitializeViews()
        {
            
            viewMapping = new Dictionary<Button, UserControl>()
            {
                { tabDevApp, new DevApp() },
                {tabFlux, new test()}
            };
            viewMapping.ToList().ForEach(pair => pair.Key.Click += (s, e) => ChangeView(pair.Value));
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyDown(Keys.Right))
            {
          //     btAvatar.BackgroundImage = Properties.Resources.avatar_reverse;  
            }
            else if (e.KeyCode == Keys.Left)
            {
            //    btAvatar.BackgroundImage = Properties.Resources.avatar;
            }
        }


        protected virtual void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseMouseCapture();
                SendMessageToForm();
            }
        }
        private void PanelTopBar_MouseWheel(object sender, MouseEventArgs e) => Opacity += e.Delta > 0 ? Math.Min(OpacityStep, MaxOpacity - Opacity) : -Math.Min(OpacityStep, Opacity - MinOpacity);
        private bool IsKeyDown(Keys key) => (User32Interop.GetAsyncKeyState(key) & 0x8000) != 0;
        private void ReleaseMouseCapture() => User32Interop.ReleaseCapture();
        private void SendMessageToForm() => User32Interop.SendMessage(this.Handle, User32Interop.WM_NCLBUTTONDOWN, User32Interop.HT_CAPTION, 0);
        private void ResizeForm(MouseEventArgs e)
        {
            this.ClientSize = new Size(this.ClientSize.Width + e.X - lastMousePosition.X, this.ClientSize.Height + e.Y - lastMousePosition.Y);
            roundedPanel.Invalidate();
            roundedPanel.Invalidate();
        }
        private void PbResize_MouseDown(object sender, MouseEventArgs e) => (isResizing, lastMousePosition) = (e.Button == MouseButtons.Left, e.Location);
        private void PbResize_MouseUp(object sender, MouseEventArgs e) => isResizing = false;


        private void ChangeView(UserControl view)
        {
            if (view.Name == lbCurrentView.Text)
                return;
            lbCurrentView.Text= view.Name;
            view.Dock = DockStyle.Fill;
            panelView.Controls.Clear();
            panelView.Controls.Add(view);
        }
    }
}
