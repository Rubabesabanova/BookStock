
namespace BookStock.Controls
{
    partial class ProductControl
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
            this.tbxProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.btnProductSelect = new System.Windows.Forms.Button();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.rtbxProductData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxProductId
            // 
            this.tbxProductId.Location = new System.Drawing.Point(56, 76);
            this.tbxProductId.Name = "tbxProductId";
            this.tbxProductId.Size = new System.Drawing.Size(208, 20);
            this.tbxProductId.TabIndex = 0;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(52, 53);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(35, 20);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Id : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(52, 119);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 20);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Name : ";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(56, 142);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(208, 20);
            this.tbxProductName.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(52, 187);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(56, 20);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Price : ";
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.Location = new System.Drawing.Point(56, 210);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(208, 20);
            this.tbxProductPrice.TabIndex = 4;
            // 
            // btnProductSelect
            // 
            this.btnProductSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSelect.Location = new System.Drawing.Point(69, 272);
            this.btnProductSelect.Name = "btnProductSelect";
            this.btnProductSelect.Size = new System.Drawing.Size(129, 56);
            this.btnProductSelect.TabIndex = 6;
            this.btnProductSelect.Text = "Select";
            this.btnProductSelect.UseVisualStyleBackColor = true;
            this.btnProductSelect.Click += new System.EventHandler(this.btnProductSelect_Click);
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(244, 272);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(129, 56);
            this.btnProductCreate.TabIndex = 7;
            this.btnProductCreate.Text = "Create";
            this.btnProductCreate.UseVisualStyleBackColor = true;
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(432, 272);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(129, 56);
            this.btnProductUpdate.TabIndex = 8;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(606, 272);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(129, 56);
            this.btnProductDelete.TabIndex = 9;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // rtbxProductData
            // 
            this.rtbxProductData.Location = new System.Drawing.Point(311, 53);
            this.rtbxProductData.Name = "rtbxProductData";
            this.rtbxProductData.Size = new System.Drawing.Size(424, 202);
            this.rtbxProductData.TabIndex = 10;
            this.rtbxProductData.Text = "";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.rtbxProductData);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductCreate);
            this.Controls.Add(this.btnProductSelect);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.tbxProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.tbxProductId);
            this.Name = "ProductControl";
            this.Text = "ProductControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.Button btnProductSelect;
        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.RichTextBox rtbxProductData;
    }
}