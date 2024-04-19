namespace Exa_Launcher.Views
{
    partial class DevApp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevApp));
            this.roundedPanel1 = new Exa_Launcher.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddApp = new System.Windows.Forms.Button();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.AllowVerticalScrolling = false;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedPanel1.Controls.Add(this.button1);
            this.roundedPanel1.Controls.Add(this.btAddApp);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 30;
            this.roundedPanel1.Size = new System.Drawing.Size(779, 61);
            this.roundedPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ajouter :";
            // 
            // listViewItems
            // 
            this.listViewItems.AllowDrop = true;
            this.listViewItems.AutoArrange = false;
            this.listViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewItems.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewItems.HideSelection = false;
            this.listViewItems.LabelEdit = true;
            this.listViewItems.Location = new System.Drawing.Point(0, 61);
            this.listViewItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(779, 377);
            this.listViewItems.TabIndex = 12;
            this.listViewItems.TileSize = new System.Drawing.Size(64, 64);
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(104, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 28;
            this.button1.Tag = "4";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btAddApp
            // 
            this.btAddApp.AutoSize = true;
            this.btAddApp.BackgroundImage = global::Exa_Launcher.Properties.Resources.app_exe;
            this.btAddApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddApp.FlatAppearance.BorderSize = 0;
            this.btAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddApp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.btAddApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btAddApp.Location = new System.Drawing.Point(137, 9);
            this.btAddApp.Name = "btAddApp";
            this.btAddApp.Size = new System.Drawing.Size(46, 44);
            this.btAddApp.TabIndex = 27;
            this.btAddApp.Tag = "4";
            this.btAddApp.UseVisualStyleBackColor = true;
            // 
            // DevApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "DevApp";
            this.Size = new System.Drawing.Size(779, 438);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button btAddApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Button button1;
    }
}
