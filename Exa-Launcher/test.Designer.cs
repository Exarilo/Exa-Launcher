namespace Exa_Launcher
{
    partial class test
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
            this.roundedPanel1 = new Exa_Launcher.RoundedPanel();
            this.btAddApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedPanel1.Controls.Add(this.btAddApp);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(13, 17);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 30;
            this.roundedPanel1.Size = new System.Drawing.Size(593, 61);
            this.roundedPanel1.TabIndex = 0;
            // 
            // btAddApp
            // 
            this.btAddApp.AutoSize = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ajouter :";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.roundedPanel1);
            this.Name = "test";
            this.Size = new System.Drawing.Size(621, 454);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button btAddApp;
        private System.Windows.Forms.Label label1;
    }
}
