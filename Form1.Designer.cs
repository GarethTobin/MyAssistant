namespace MyAssistant
{
    partial class MyAssistantForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAssistantForm));
            this.PlayAndPuaseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // PlayAndPuaseButton
            // 
            this.PlayAndPuaseButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayAndPuaseButton.BackgroundImage = global::MyAssistant.Properties.Resources.Play;
            this.PlayAndPuaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayAndPuaseButton.FlatAppearance.BorderSize = 0;
            this.PlayAndPuaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAndPuaseButton.Location = new System.Drawing.Point(14, 12);
            this.PlayAndPuaseButton.Name = "PlayAndPuaseButton";
            this.PlayAndPuaseButton.Size = new System.Drawing.Size(130, 130);
            this.PlayAndPuaseButton.TabIndex = 1;
            this.PlayAndPuaseButton.UseVisualStyleBackColor = false;
            this.PlayAndPuaseButton.Click += new System.EventHandler(this.PlayAndPuaseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.BackgroundImage = global::MyAssistant.Properties.Resources.Stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(169, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(130, 130);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "My Assistant";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MyAssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 152);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayAndPuaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyAssistantForm";
            this.Text = "My Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MyAssistantForm_Load);
            this.SizeChanged += new System.EventHandler(this.MyAssistantForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private Button PlayAndPuaseButton;
        private Button StopButton;
        private NotifyIcon notifyIcon;
    }
}