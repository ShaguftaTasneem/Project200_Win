namespace Project200_Win
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPackProdSupplier = new System.Windows.Forms.Button();
            this.btnProdSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please Make a selection to go to the Required Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Travel Expert Data Management Application ";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(277, 355);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(170, 32);
            this.btnSuppliers.TabIndex = 11;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnPackProdSupplier
            // 
            this.btnPackProdSupplier.Location = new System.Drawing.Point(277, 303);
            this.btnPackProdSupplier.Name = "btnPackProdSupplier";
            this.btnPackProdSupplier.Size = new System.Drawing.Size(170, 35);
            this.btnPackProdSupplier.TabIndex = 10;
            this.btnPackProdSupplier.Text = "Packages Product Suppliers";
            this.btnPackProdSupplier.UseVisualStyleBackColor = true;
            // 
            // btnProdSuppliers
            // 
            this.btnProdSuppliers.Location = new System.Drawing.Point(277, 251);
            this.btnProdSuppliers.Name = "btnProdSuppliers";
            this.btnProdSuppliers.Size = new System.Drawing.Size(170, 34);
            this.btnProdSuppliers.TabIndex = 9;
            this.btnProdSuppliers.Text = "Product Suppliers";
            this.btnProdSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(277, 194);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 33);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(277, 141);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(170, 32);
            this.btnPackages.TabIndex = 7;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnPackProdSupplier);
            this.Controls.Add(this.btnProdSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnPackages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnPackProdSupplier;
        private System.Windows.Forms.Button btnProdSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPackages;
    }
}

