
namespace Ankkabase
{
    partial class formMain
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
            this.labelYritys = new System.Windows.Forms.Label();
            this.listYritykset = new System.Windows.Forms.ListBox();
            this.labelNimet = new System.Windows.Forms.Label();
            this.listNimet = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelYritys
            // 
            this.labelYritys.AutoSize = true;
            this.labelYritys.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelYritys.Location = new System.Drawing.Point(12, 9);
            this.labelYritys.Name = "labelYritys";
            this.labelYritys.Size = new System.Drawing.Size(68, 26);
            this.labelYritys.TabIndex = 0;
            this.labelYritys.Text = "Yritys";
            // 
            // listYritykset
            // 
            this.listYritykset.FormattingEnabled = true;
            this.listYritykset.Location = new System.Drawing.Point(17, 38);
            this.listYritykset.Name = "listYritykset";
            this.listYritykset.Size = new System.Drawing.Size(218, 108);
            this.listYritykset.TabIndex = 1;
            this.listYritykset.SelectedIndexChanged += new System.EventHandler(this.listYritykset_SelectedIndexChanged);
            // 
            // labelNimet
            // 
            this.labelNimet.AutoSize = true;
            this.labelNimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelNimet.Location = new System.Drawing.Point(306, 9);
            this.labelNimet.Name = "labelNimet";
            this.labelNimet.Size = new System.Drawing.Size(116, 26);
            this.labelNimet.TabIndex = 2;
            this.labelNimet.Text = "Työntekijät";
            // 
            // listNimet
            // 
            this.listNimet.FormattingEnabled = true;
            this.listNimet.Location = new System.Drawing.Point(311, 38);
            this.listNimet.Name = "listNimet";
            this.listNimet.Size = new System.Drawing.Size(111, 108);
            this.listNimet.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1062, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(1091, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listNimet);
            this.Controls.Add(this.labelNimet);
            this.Controls.Add(this.listYritykset);
            this.Controls.Add(this.labelYritys);
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelYritys;
        private System.Windows.Forms.ListBox listYritykset;
        private System.Windows.Forms.Label labelNimet;
        private System.Windows.Forms.ListBox listNimet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

