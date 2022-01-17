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
            this.PlayAndPuaseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayAndPuaseButton
            // 
            this.PlayAndPuaseButton.Location = new System.Drawing.Point(12, 12);
            this.PlayAndPuaseButton.Name = "PlayAndPuaseButton";
            this.PlayAndPuaseButton.Size = new System.Drawing.Size(106, 179);
            this.PlayAndPuaseButton.TabIndex = 1;
            this.PlayAndPuaseButton.Text = "button2";
            this.PlayAndPuaseButton.UseVisualStyleBackColor = true;
            this.PlayAndPuaseButton.Click += new System.EventHandler(this.PlayAndPuaseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(130, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(102, 179);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "button1";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MyAssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 203);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayAndPuaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyAssistantForm";
            this.ShowIcon = false;
            this.Text = "My Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MyAssistantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button PlayAndPuaseButton;
        private Button StopButton;
    }
}