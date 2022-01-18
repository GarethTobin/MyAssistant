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
            this.StopButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.PlayAndPuaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Image = global::MyAssistant.Properties.Resources.StopButton;
            this.StopButton.Location = new System.Drawing.Point(187, 26);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(140, 140);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseEnter);
            this.StopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "My Assistant";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::MyAssistant.Properties.Resources.CloseButton;
            this.closeButton.Location = new System.Drawing.Point(364, 27);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 64);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = global::MyAssistant.Properties.Resources.MinButton;
            this.minButton.Location = new System.Drawing.Point(364, 107);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(64, 64);
            this.minButton.TabIndex = 4;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            this.minButton.MouseEnter += new System.EventHandler(this.minButton_MouseEnter);
            this.minButton.MouseLeave += new System.EventHandler(this.minButton_MouseLeave);
            // 
            // PlayAndPuaseButton
            // 
            this.PlayAndPuaseButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayAndPuaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayAndPuaseButton.FlatAppearance.BorderSize = 0;
            this.PlayAndPuaseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayAndPuaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayAndPuaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAndPuaseButton.Image = global::MyAssistant.Properties.Resources.PlayButton;
            this.PlayAndPuaseButton.Location = new System.Drawing.Point(25, 26);
            this.PlayAndPuaseButton.Name = "PlayAndPuaseButton";
            this.PlayAndPuaseButton.Size = new System.Drawing.Size(140, 140);
            this.PlayAndPuaseButton.TabIndex = 1;
            this.PlayAndPuaseButton.UseVisualStyleBackColor = false;
            this.PlayAndPuaseButton.Click += new System.EventHandler(this.PlayAndPuaseButton_Click);
            this.PlayAndPuaseButton.MouseEnter += new System.EventHandler(this.PlayAndPuaseButton_MouseEnter);
            this.PlayAndPuaseButton.MouseLeave += new System.EventHandler(this.PlayAndPuaseButton_MouseLeave);
            // 
            // MyAssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MyAssistant.Properties.Resources.Backgrond;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayAndPuaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyAssistantForm";
            this.Text = "My Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MyAssistantForm_Load);
            this.SizeChanged += new System.EventHandler(this.MyAssistantForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyAssistantForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private Button StopButton;
        private NotifyIcon notifyIcon;
        private Button closeButton;
        private Button minButton;
        private Button PlayAndPuaseButton;
    }
}