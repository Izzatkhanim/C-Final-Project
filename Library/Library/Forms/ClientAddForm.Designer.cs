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
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNewtClientPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // TxtNewClientName
            // 
            this.TxtNewClientName.Location = new System.Drawing.Point(187, 74);
            this.TxtNewClientName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtNewClientName.Name = "TxtNewClientName";
            this.TxtNewClientName.Size = new System.Drawing.Size(320, 37);
            this.TxtNewClientName.TabIndex = 4;
            // 
            // TxtNewClientLastname
            // 
            this.TxtNewClientLastname.Location = new System.Drawing.Point(187, 222);
            this.TxtNewClientLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtNewClientLastname.Name = "TxtNewClientLastname";
            this.TxtNewClientLastname.Size = new System.Drawing.Size(320, 37);
            this.TxtNewClientLastname.TabIndex = 5;
            // 
            // TxtNewClientEmail
            // 
            this.TxtNewClientEmail.Location = new System.Drawing.Point(733, 74);
            this.TxtNewClientEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtNewClientEmail.Name = "TxtNewClientEmail";
            this.TxtNewClientEmail.Size = new System.Drawing.Size(334, 37);
            this.TxtNewClientEmail.TabIndex = 6;
            // 
            // TxtNewClientPassword
            // 
            this.TxtNewClientPassword.Location = new System.Drawing.Point(733, 222);
            this.TxtNewClientPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtNewClientPassword.Name = "TxtNewClientPassword";
            this.TxtNewClientPassword.Size = new System.Drawing.Size(334, 37);
            this.TxtNewClientPassword.TabIndex = 7;
            // 
            // BtnAddNewClient
            // 
            this.BtnAddNewClient.BackColor = System.Drawing.Color.LightBlue;
            this.BtnAddNewClient.Location = new System.Drawing.Point(478, 483);
            this.BtnAddNewClient.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAddNewClient.Name = "BtnAddNewClient";
            this.BtnAddNewClient.Size = new System.Drawing.Size(264, 90);
            this.BtnAddNewClient.TabIndex = 8;
            this.BtnAddNewClient.Text = "Add";
            this.BtnAddNewClient.UseVisualStyleBackColor = false;
            this.BtnAddNewClient.Click += new System.EventHandler(this.BtnAddNewClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // TxtNewtClientPhone
            // 
            this.TxtNewtClientPhone.Location = new System.Drawing.Point(448, 363);
            this.TxtNewtClientPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtNewtClientPhone.Name = "TxtNewtClientPhone";
            this.TxtNewtClientPhone.Size = new System.Drawing.Size(320, 37);
            this.TxtNewtClientPhone.TabIndex = 4;
            // 
            // ClientAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Library.Properties.Resources.Addlient;
            this.ClientSize = new System.Drawing.Size(1244, 653);
            this.Controls.Add(this.BtnAddNewClient);
            this.Controls.Add(this.TxtNewClientPassword);
            this.Controls.Add(this.TxtNewClientEmail);
            this.Controls.Add(this.TxtNewClientLastname);
            this.Controls.Add(this.TxtNewtClientPhone);
            this.Controls.Add(this.TxtNewClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNewtClientPhone;
    }
}