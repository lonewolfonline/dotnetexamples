namespace UserControls
{
    partial class Form1
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
            this.userControl12 = new UserControls.UserControl1();
            this.userControl11 = new UserControls.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.ButtonText = "button1";
            this.userControl12.LabelText = "label1";
            this.userControl12.Location = new System.Drawing.Point(216, 32);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(150, 150);
            this.userControl12.TabIndex = 1;
            this.userControl12.TextBoxText = "";
            // 
            // userControl11
            // 
            this.userControl11.ButtonText = "my button text";
            this.userControl11.LabelText = "label1";
            this.userControl11.Location = new System.Drawing.Point(40, 32);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            this.userControl11.TextBoxText = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 229);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

