﻿namespace Proiect2
{
    partial class AddProduct
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataValabilitate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataIntrare = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.Denumire = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantitate:";
            // 
            // dtpDataValabilitate
            // 
            this.dtpDataValabilitate.Location = new System.Drawing.Point(142, 167);
            this.dtpDataValabilitate.Name = "dtpDataValabilitate";
            this.dtpDataValabilitate.Size = new System.Drawing.Size(200, 22);
            this.dtpDataValabilitate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "DataValabilitate:";
            // 
            // dtpDataIntrare
            // 
            this.dtpDataIntrare.Location = new System.Drawing.Point(142, 133);
            this.dtpDataIntrare.Name = "dtpDataIntrare";
            this.dtpDataIntrare.Size = new System.Drawing.Size(200, 22);
            this.dtpDataIntrare.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "DataIntrare:";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(142, 76);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(200, 51);
            this.txtDescriere.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "DescriereProdus:";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(142, 33);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(200, 22);
            this.txtDenumire.TabIndex = 13;
            // 
            // Denumire
            // 
            this.Denumire.AutoSize = true;
            this.Denumire.Location = new System.Drawing.Point(22, 33);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(68, 16);
            this.Denumire.TabIndex = 12;
            this.Denumire.Text = "Denumire:";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(142, 200);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(200, 22);
            this.txtCantitate.TabIndex = 24;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 296);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataValabilitate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataIntrare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.Denumire);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataValabilitate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataIntrare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label Denumire;
        private System.Windows.Forms.TextBox txtCantitate;
    }
}