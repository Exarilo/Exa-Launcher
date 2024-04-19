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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Exa_Launcher.RoundedPanel();
            this.btAddApp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 100);
            this.panel1.TabIndex = 9;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedPanel1.Controls.Add(this.btAddApp);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Location = new System.Drawing.Point(27, 18);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 30;
            this.roundedPanel1.Size = new System.Drawing.Size(712, 61);
            this.roundedPanel1.TabIndex = 9;
            // 
            // btAddApp
            // 
            this.btAddApp.AutoSize = true;
            this.btAddApp.BackgroundImage = global::Exa_Launcher.Properties.Resources.app;
            this.btAddApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddApp.FlatAppearance.BorderSize = 0;
            this.btAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddApp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F);
            this.btAddApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btAddApp.Location = new System.Drawing.Point(101, 19);
            this.btAddApp.Name = "btAddApp";
            this.btAddApp.Size = new System.Drawing.Size(29, 27);
            this.btAddApp.TabIndex = 27;
            this.btAddApp.Tag = "4";
            this.btAddApp.UseVisualStyleBackColor = true;
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
            this.listViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewItems.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewItems.HideSelection = false;
            this.listViewItems.LabelEdit = true;
            this.listViewItems.Location = new System.Drawing.Point(0, 100);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(779, 338);
            this.listViewItems.TabIndex = 10;
            this.listViewItems.TileSize = new System.Drawing.Size(64, 64);
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // DevApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.panel1);
            this.Name = "DevApp";
            this.Size = new System.Drawing.Size(779, 438);
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button btAddApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewItems;
    }
}
