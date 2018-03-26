namespace PasswordManager
{
    partial class PassMan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SiteTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.MasterPassTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MasPasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website/Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(106, 161);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.TabStop = false;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(106, 191);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.TabStop = false;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(106, 221);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(106, 251);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.TabStop = false;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(106, 426);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SiteTxt
            // 
            this.SiteTxt.Location = new System.Drawing.Point(106, 49);
            this.SiteTxt.Name = "SiteTxt";
            this.SiteTxt.Size = new System.Drawing.Size(100, 20);
            this.SiteTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(106, 86);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 3;
            // 
            // MasterPassTxt
            // 
            this.MasterPassTxt.Location = new System.Drawing.Point(106, 12);
            this.MasterPassTxt.Name = "MasterPassTxt";
            this.MasterPassTxt.Size = new System.Drawing.Size(100, 20);
            this.MasterPassTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Master Password:";
            // 
            // MasPasBtn
            // 
            this.MasPasBtn.Location = new System.Drawing.Point(106, 329);
            this.MasPasBtn.Name = "MasPasBtn";
            this.MasPasBtn.Size = new System.Drawing.Size(75, 50);
            this.MasPasBtn.TabIndex = 4;
            this.MasPasBtn.TabStop = false;
            this.MasPasBtn.Text = "Create A Master Password";
            this.MasPasBtn.UseVisualStyleBackColor = true;
            this.MasPasBtn.Click += new System.EventHandler(this.MasPasBtn_Click);
            // 
            // PassMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.MasPasBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MasterPassTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.SiteTxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassMan";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox SiteTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox MasterPassTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MasPasBtn;
    }
}

