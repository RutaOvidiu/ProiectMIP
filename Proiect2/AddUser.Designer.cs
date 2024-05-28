namespace Proiect2
{
    partial class AddUser
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
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeAddUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenumeAddUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameAddUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordAddUser = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(57, 43);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(291, 69);
            this.Login.TabIndex = 3;
            this.Login.Text = "New User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume:";
            // 
            // txtNumeAddUser
            // 
            this.txtNumeAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumeAddUser.Location = new System.Drawing.Point(44, 197);
            this.txtNumeAddUser.Name = "txtNumeAddUser";
            this.txtNumeAddUser.Size = new System.Drawing.Size(291, 27);
            this.txtNumeAddUser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenume:";
            // 
            // txtPrenumeAddUser
            // 
            this.txtPrenumeAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrenumeAddUser.Location = new System.Drawing.Point(44, 284);
            this.txtPrenumeAddUser.Name = "txtPrenumeAddUser";
            this.txtPrenumeAddUser.Size = new System.Drawing.Size(291, 27);
            this.txtPrenumeAddUser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(40, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // txtUsernameAddUser
            // 
            this.txtUsernameAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsernameAddUser.Location = new System.Drawing.Point(44, 372);
            this.txtUsernameAddUser.Name = "txtUsernameAddUser";
            this.txtUsernameAddUser.Size = new System.Drawing.Size(291, 27);
            this.txtUsernameAddUser.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(40, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // txtPasswordAddUser
            // 
            this.txtPasswordAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasswordAddUser.Location = new System.Drawing.Point(44, 461);
            this.txtPasswordAddUser.Name = "txtPasswordAddUser";
            this.txtPasswordAddUser.Size = new System.Drawing.Size(291, 27);
            this.txtPasswordAddUser.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 507);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPasswordAddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsernameAddUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenumeAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenumeAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordAddUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}