namespace StokTakipMasaüstü
{
    partial class CustomerPanel
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
            this.tboxAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGoToCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Location = new System.Drawing.Point(13, 12);
            this.dgrid.Name = "dgrid";
            this.dgrid.Size = new System.Drawing.Size(775, 150);
            this.dgrid.TabIndex = 0;
            this.dgrid.SelectionChanged += new System.EventHandler(this.dgrid_SelectionChanged);
            // 
            // tboxAddName
            // 
            this.tboxAddName.Location = new System.Drawing.Point(13, 195);
            this.tboxAddName.Name = "tboxAddName";
            this.tboxAddName.Size = new System.Drawing.Size(133, 20);
            this.tboxAddName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Müşteri Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Müşteriyi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tboxUpdateName
            // 
            this.tboxUpdateName.Location = new System.Drawing.Point(408, 197);
            this.tboxUpdateName.Name = "tboxUpdateName";
            this.tboxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(408, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Müşteriyi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGoToCategory
            // 
            this.btnGoToCategory.Location = new System.Drawing.Point(646, 213);
            this.btnGoToCategory.Name = "btnGoToCategory";
            this.btnGoToCategory.Size = new System.Drawing.Size(81, 67);
            this.btnGoToCategory.TabIndex = 10;
            this.btnGoToCategory.Text = "Kategori Panelini Aç";
            this.btnGoToCategory.UseVisualStyleBackColor = true;
            this.btnGoToCategory.Click += new System.EventHandler(this.btnGoToCategory_Click);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.btnGoToCategory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tboxUpdateName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxAddName);
            this.Controls.Add(this.dgrid);
            this.Name = "CustomerPanel";
            this.Text = "CustomerPanel";
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.TextBox tboxAddName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tboxUpdateName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGoToCategory;
    }
}