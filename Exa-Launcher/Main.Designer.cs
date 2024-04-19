namespace Exa_Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbResize = new System.Windows.Forms.PictureBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.lbCurrentView = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.roundedPanel = new Exa_Launcher.RoundedPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabFlux = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabDevApp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btAvatar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelTopBar.SuspendLayout();
            this.roundedPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelTopBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 530);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.panelView);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(117, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 503);
            this.panel3.TabIndex = 4;
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(926, 471);
            this.panelView.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pbResize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 471);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 32);
            this.panel6.TabIndex = 1;
            // 
            // pbResize
            // 
            this.pbResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pbResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbResize.Location = new System.Drawing.Point(895, 0);
            this.pbResize.Name = "pbResize";
            this.pbResize.Size = new System.Drawing.Size(31, 32);
            this.pbResize.TabIndex = 0;
            this.pbResize.TabStop = false;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(114, 25);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 503);
            this.splitter.TabIndex = 3;
            this.splitter.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.roundedPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 503);
            this.panel2.TabIndex = 2;
            // 
            // PanelTopBar
            // 
            this.PanelTopBar.BackColor = System.Drawing.SystemColors.Control;
            this.PanelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTopBar.Controls.Add(this.lbCurrentView);
            this.PanelTopBar.Controls.Add(this.btMinimize);
            this.PanelTopBar.Controls.Add(this.btMaximize);
            this.PanelTopBar.Controls.Add(this.btClose);
            this.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTopBar.Name = "PanelTopBar";
            this.PanelTopBar.Size = new System.Drawing.Size(1043, 25);
            this.PanelTopBar.TabIndex = 1;
            // 
            // lbCurrentView
            // 
            this.lbCurrentView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCurrentView.AutoSize = true;
            this.lbCurrentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentView.Location = new System.Drawing.Point(465, 4);
            this.lbCurrentView.Name = "lbCurrentView";
            this.lbCurrentView.Size = new System.Drawing.Size(78, 16);
            this.lbCurrentView.TabIndex = 9;
            this.lbCurrentView.Text = "CurrentView";
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.Location = new System.Drawing.Point(969, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(24, 23);
            this.btMinimize.TabIndex = 8;
            this.btMinimize.Text = "➖";
            this.btMinimize.UseVisualStyleBackColor = false;
            // 
            // btMaximize
            // 
            this.btMaximize.BackColor = System.Drawing.Color.YellowGreen;
            this.btMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaximize.Location = new System.Drawing.Point(993, 0);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(24, 23);
            this.btMaximize.TabIndex = 7;
            this.btMaximize.Text = "🔲";
            this.btMaximize.UseVisualStyleBackColor = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.IndianRed;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(1017, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(24, 23);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "❌";
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // roundedPanel
            // 
            this.roundedPanel.AllowVerticalScrolling = true;
            this.roundedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedPanel.Controls.Add(this.button10);
            this.roundedPanel.Controls.Add(this.button9);
            this.roundedPanel.Controls.Add(this.button8);
            this.roundedPanel.Controls.Add(this.tabFlux);
            this.roundedPanel.Controls.Add(this.button6);
            this.roundedPanel.Controls.Add(this.tabDevApp);
            this.roundedPanel.Controls.Add(this.panel4);
            this.roundedPanel.Location = new System.Drawing.Point(15, 21);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.Radius = 30;
            this.roundedPanel.Size = new System.Drawing.Size(85, 461);
            this.roundedPanel.TabIndex = 22;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button10.Location = new System.Drawing.Point(0, 260);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 32);
            this.button10.TabIndex = 35;
            this.button10.Tag = "4";
            this.button10.Text = "Tools";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button9.Location = new System.Drawing.Point(0, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 32);
            this.button9.TabIndex = 34;
            this.button9.Tag = "4";
            this.button9.Text = "Console";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button8.Location = new System.Drawing.Point(0, 196);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 32);
            this.button8.TabIndex = 33;
            this.button8.Tag = "4";
            this.button8.Text = "Todo";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tabFlux
            // 
            this.tabFlux.AutoSize = true;
            this.tabFlux.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFlux.FlatAppearance.BorderSize = 0;
            this.tabFlux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabFlux.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.tabFlux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tabFlux.Location = new System.Drawing.Point(0, 164);
            this.tabFlux.Name = "tabFlux";
            this.tabFlux.Size = new System.Drawing.Size(85, 32);
            this.tabFlux.TabIndex = 32;
            this.tabFlux.Tag = "4";
            this.tabFlux.Text = "Flux";
            this.tabFlux.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button6.Location = new System.Drawing.Point(0, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 32);
            this.button6.TabIndex = 31;
            this.button6.Tag = "4";
            this.button6.Text = "Nagateur";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabDevApp
            // 
            this.tabDevApp.AutoSize = true;
            this.tabDevApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDevApp.FlatAppearance.BorderSize = 0;
            this.tabDevApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabDevApp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.tabDevApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tabDevApp.Location = new System.Drawing.Point(0, 100);
            this.tabDevApp.Name = "tabDevApp";
            this.tabDevApp.Size = new System.Drawing.Size(85, 32);
            this.tabDevApp.TabIndex = 30;
            this.tabDevApp.Tag = "4";
            this.tabDevApp.Text = "Dev-App";
            this.tabDevApp.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btAvatar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 100);
            this.panel4.TabIndex = 29;
            // 
            // btAvatar
            // 
            this.btAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btAvatar.BackColor = System.Drawing.Color.Transparent;
            this.btAvatar.BackgroundImage = global::Exa_Launcher.Properties.Resources.avatar;
            this.btAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAvatar.FlatAppearance.BorderSize = 0;
            this.btAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvatar.Location = new System.Drawing.Point(0, 11);
            this.btAvatar.Name = "btAvatar";
            this.btAvatar.Size = new System.Drawing.Size(85, 79);
            this.btAvatar.TabIndex = 23;
            this.btAvatar.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelTopBar.ResumeLayout(false);
            this.PanelTopBar.PerformLayout();
            this.roundedPanel.ResumeLayout(false);
            this.roundedPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTopBar;
        protected System.Windows.Forms.Button btMinimize;
        protected System.Windows.Forms.Button btMaximize;
        protected System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label lbCurrentView;
        private RoundedPanel roundedPanel;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button tabFlux;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button tabDevApp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btAvatar;
        private System.Windows.Forms.PictureBox pbResize;
    }
}

