namespace Proiect2
{
    partial class Magazin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.utilizatoriToolStripMenuItem,
            this.istoricVanzariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.vanzareProduseToolStripMenuItem});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusNouToolStripMenuItem,
            this.adaugareCantitateToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugareToolStripMenuItem.Text = "AdaugareProduse";
            // 
            // adaugareProdusNouToolStripMenuItem
            // 
            this.adaugareProdusNouToolStripMenuItem.Name = "adaugareProdusNouToolStripMenuItem";
            this.adaugareProdusNouToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.adaugareProdusNouToolStripMenuItem.Text = "AdaugareProdusNou";
            this.adaugareProdusNouToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusNouToolStripMenuItem_Click);
            // 
            // adaugareCantitateToolStripMenuItem
            // 
            this.adaugareCantitateToolStripMenuItem.Name = "adaugareCantitateToolStripMenuItem";
            this.adaugareCantitateToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.adaugareCantitateToolStripMenuItem.Text = "AdaugareCantitate";
            this.adaugareCantitateToolStripMenuItem.Click += new System.EventHandler(this.adaugareCantitateToolStripMenuItem_Click);
            // 
            // vanzareProduseToolStripMenuItem
            // 
            this.vanzareProduseToolStripMenuItem.Name = "vanzareProduseToolStripMenuItem";
            this.vanzareProduseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vanzareProduseToolStripMenuItem.Text = "CumparareProduse";
            this.vanzareProduseToolStripMenuItem.Click += new System.EventHandler(this.cumparareProduseToolStripMenuItem_Click);
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareUtilizatoriToolStripMenuItem,
            this.stergereUtilizatoriToolStripMenuItem});
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            // 
            // adaugareUtilizatoriToolStripMenuItem
            // 
            this.adaugareUtilizatoriToolStripMenuItem.Name = "adaugareUtilizatoriToolStripMenuItem";
            this.adaugareUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugareUtilizatoriToolStripMenuItem.Text = "AdaugareUtilizatori";
            this.adaugareUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.adaugareUtilizatoriToolStripMenuItem_Click);
            // 
            // stergereUtilizatoriToolStripMenuItem
            // 
            this.stergereUtilizatoriToolStripMenuItem.Name = "stergereUtilizatoriToolStripMenuItem";
            this.stergereUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereUtilizatoriToolStripMenuItem.Text = "StergereUtilizatori";
            this.stergereUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.stergereUtilizatoriToolStripMenuItem_Click);
            // 
            // istoricVanzariToolStripMenuItem
            // 
            this.istoricVanzariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istoricToolStripMenuItem});
            this.istoricVanzariToolStripMenuItem.Name = "istoricVanzariToolStripMenuItem";
            this.istoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.istoricVanzariToolStripMenuItem.Text = "IstoricVanzari";
            // 
            // istoricToolStripMenuItem
            // 
            this.istoricToolStripMenuItem.Name = "istoricToolStripMenuItem";
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.istoricToolStripMenuItem.Text = "Istoric";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 340);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtSerach
            // 
            this.txtSerach.Location = new System.Drawing.Point(43, 64);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(371, 22);
            this.txtSerach.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(501, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Magazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 453);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Magazin";
            this.Text = "Magazin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Magazin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricVanzariToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSerach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
    }
}