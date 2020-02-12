namespace Library.Forms
{
    partial class ClientAddForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNewClientName = new System.Windows.Forms.TextBox();
            this.TxtNewClientLastname = new System.Windows.Forms.TextBox();
            this.TxtNewClientEmail = new System.Windows.Forms.TextBox();
            this.TxtNewClientPassword = new System.Windows.Forms.TextBox();
            this.BtnAddNewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // TxtNewClientName
            // 
            this.TxtNewClientName.Location = new System.Drawing.Point(106, 80);
            this.TxtNewClientName.Name = "TxtNewClientName";
            this.TxtNewClientName.Size = new System.Drawing.Size(207, 26);
            this.TxtNewClientName.TabIndex = 4;
            // 
            // TxtNewClientLastname
            // 
            this.TxtNewClientLastname.Location = new System.Drawing.Point(106, 223);
            this.TxtNewClientLastname.Name = "TxtNewClientLastname";
            this.TxtNewClientLastname.Size = new System.Drawing.Size(207, 26);
            this.TxtNewClientLastname.TabIndex = 5;
            // 
            // TxtNewClientEmail
            // 
            this.TxtNewClientEmail.Location = new System.Drawing.Point(471, 80);
            this.TxtNewClientEmail.Name = "TxtNewClientEmail";
            this.TxtNewClientEmail.Size = new System.Drawing.Size(216, 26);
            this.TxtNewClientEmail.TabIndex = 6;
            // 
            // TxtNewClientPassword
            // 
            this.TxtNewClientPassword.Location = new System.Drawing.Point(471, 223);
            this.TxtNewClientPassword.Name = "TxtNewClientPassword";
            this.TxtNewClientPassword.Size = new System.Drawing.Size(216, 26);
            this.TxtNewClientPassword.TabIndex = 7;
            // 
            // BtnAddNewClient
            // 
            this.BtnAddNewClient.Location = new System.Drawing.Point(308, 320);
            this.BtnAddNewClient.Name = "BtnAddNewClient";
            this.BtnAddNewClient.Size = new System.Drawing.Size(170, 62);
            this.BtnAddNewClient.TabIndex = 8;
            this.BtnAddNewClient.Text = "Add";
            this.BtnAddNewClient.UseVisualStyleBackColor = true;
            this.BtnAddNewClient.Click += new System.EventHandler(this.BtnAddNewClient_Click);
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddNewClient);
            this.Controls.Add(this.TxtNewClientPassword);
            this.Controls.Add(this.TxtNewClientEmail);
            this.Controls.Add(this.TxtNewClientLastname);
            this.Controls.Add(this.TxtNewClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientAddForm";
            this.Text = "ClientAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNewClientName;
        private System.Windows.Forms.TextBox TxtNewClientLastname;
        private System.Windows.Forms.TextBox TxtNewClientEmail;
        private System.Windows.Forms.TextBox TxtNewClientPassword;
        private System.Windows.Forms.Button BtnAddNewClient;
    }
}