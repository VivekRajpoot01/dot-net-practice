namespace WinDisconArchDemo
{
    partial class Form1
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
            this.lbl_ProdId = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lbl_ProdName = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProdPrice = new System.Windows.Forms.Label();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProdId
            // 
            this.lbl_ProdId.AutoSize = true;
            this.lbl_ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_ProdId.Location = new System.Drawing.Point(83, 35);
            this.lbl_ProdId.Name = "lbl_ProdId";
            this.lbl_ProdId.Size = new System.Drawing.Size(57, 20);
            this.lbl_ProdId.TabIndex = 0;
            this.lbl_ProdId.Text = "ProdId";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(245, 33);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(100, 22);
            this.txtProdId.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(245, 80);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 22);
            this.txtProdName.TabIndex = 3;
            // 
            // lbl_ProdName
            // 
            this.lbl_ProdName.AutoSize = true;
            this.lbl_ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_ProdName.Location = new System.Drawing.Point(83, 82);
            this.lbl_ProdName.Name = "lbl_ProdName";
            this.lbl_ProdName.Size = new System.Drawing.Size(88, 20);
            this.lbl_ProdName.TabIndex = 2;
            this.lbl_ProdName.Text = "ProdName";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(245, 134);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProdPrice.TabIndex = 5;
            // 
            // lbl_ProdPrice
            // 
            this.lbl_ProdPrice.AutoSize = true;
            this.lbl_ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_ProdPrice.Location = new System.Drawing.Point(83, 136);
            this.lbl_ProdPrice.Name = "lbl_ProdPrice";
            this.lbl_ProdPrice.Size = new System.Drawing.Size(83, 20);
            this.lbl_ProdPrice.TabIndex = 4;
            this.lbl_ProdPrice.Text = "ProdPrice";
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(245, 198);
            this.txtProdDescription.Multiline = true;
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(199, 72);
            this.txtProdDescription.TabIndex = 7;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_Desc.Location = new System.Drawing.Point(83, 200);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(95, 20);
            this.lbl_Desc.TabIndex = 6;
            this.lbl_Desc.Text = "Description";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(37, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(103, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(196, 309);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateProduct.TabIndex = 9;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(336, 309);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(147, 23);
            this.btnSearchById.TabIndex = 10;
            this.btnSearchById.Text = "Search By Id";
            this.btnSearchById.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(53, 398);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(137, 23);
            this.btnRemoveProduct.TabIndex = 11;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Location = new System.Drawing.Point(245, 398);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(154, 23);
            this.btnShowAllProduct.TabIndex = 12;
            this.btnShowAllProduct.Text = "Show All Product";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 342);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowAllProduct);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.lbl_ProdPrice);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lbl_ProdName);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.lbl_ProdId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProdId;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lbl_ProdName;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lbl_ProdPrice;
        private System.Windows.Forms.TextBox txtProdDescription;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

