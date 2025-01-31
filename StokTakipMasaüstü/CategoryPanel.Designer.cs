namespace StokTakipMasaüstü
{
    partial class CategoryPanel
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
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tboxUpdateName = new System.Windows.Forms.TextBox();
            this.btnGoToCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Location = new System.Drawing.Point(12, 12);
            this.dgrid.Name = "dgrid";
            this.dgrid.Size = new System.Drawing.Size(742, 215);
            this.dgrid.TabIndex = 0;
            this.dgrid.SelectionChanged += new System.EventHandler(this.dgrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı Giriniz";
            // 
            // tboxAddName
            // 
            this.tboxAddName.Location = new System.Drawing.Point(12, 279);
            this.tboxAddName.Name = "tboxAddName";
            this.tboxAddName.Size = new System.Drawing.Size(100, 20);
            this.tboxAddName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori ID\'sini Giriniz";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(493, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tboxUpdateName
            // 
            this.tboxUpdateName.Location = new System.Drawing.Point(493, 244);
            this.tboxUpdateName.Name = "tboxUpdateName";
            this.tboxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateName.TabIndex = 7;
            // 
            // btnGoToCustomer
            // 
            this.btnGoToCustomer.Location = new System.Drawing.Point(653, 253);
            this.btnGoToCustomer.Name = "btnGoToCustomer";
            this.btnGoToCustomer.Size = new System.Drawing.Size(81, 67);
            this.btnGoToCustomer.TabIndex = 9;
            this.btnGoToCustomer.Text = "Müşteri Panelini Aç";
            this.btnGoToCustomer.UseVisualStyleBackColor = true;
            this.btnGoToCustomer.Click += new System.EventHandler(this.btnGoToCustomer_Click);
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(767, 347);
            this.Controls.Add(this.btnGoToCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tboxUpdateName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxAddName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid);
            this.Name = "CategoryPanel";
            this.Text = "CategoryPanel";
            this.Load += new System.EventHandler(this.CategoryPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxAddName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tboxUpdateName;
        private System.Windows.Forms.Button btnGoToCustomer;
    }
}