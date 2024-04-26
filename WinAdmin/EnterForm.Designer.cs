namespace WinAdmin
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            labelButtonEnter = new Label();
            labelButtonCancel = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // labelButtonEnter
            // 
            labelButtonEnter.BackColor = Color.Transparent;
            labelButtonEnter.Cursor = Cursors.Hand;
            labelButtonEnter.Location = new Point(152, 284);
            labelButtonEnter.Name = "labelButtonEnter";
            labelButtonEnter.Size = new Size(123, 23);
            labelButtonEnter.TabIndex = 0;
            // 
            // labelButtonCancel
            // 
            labelButtonCancel.BackColor = Color.Transparent;
            labelButtonCancel.Cursor = Cursors.Hand;
            labelButtonCancel.Location = new Point(296, 284);
            labelButtonCancel.Name = "labelButtonCancel";
            labelButtonCancel.Size = new Size(123, 23);
            labelButtonCancel.TabIndex = 1;
            labelButtonCancel.Click += labelButtonCancel_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(220, 127);
            textBoxUserName.MaxLength = 30;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(249, 22);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.WordWrap = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(220, 179);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(249, 22);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.WordWrap = false;
            // 
            // EnterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.UBWCEnterForm;
            ClientSize = new Size(568, 328);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelButtonCancel);
            Controls.Add(labelButtonEnter);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(568, 328);
            MinimumSize = new Size(568, 328);
            Name = "EnterForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelButtonEnter;
        private Label labelButtonCancel;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
    }
}
