namespace storage_v7
{
    partial class NewProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 93);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новий товар";
            // 
            // inputId
            // 
            this.inputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputId.Location = new System.Drawing.Point(124, 141);
            this.inputId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(240, 31);
            this.inputId.TabIndex = 20;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputName.Location = new System.Drawing.Point(124, 184);
            this.inputName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(240, 31);
            this.inputName.TabIndex = 21;
            // 
            // inputCount
            // 
            this.inputCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCount.Location = new System.Drawing.Point(124, 227);
            this.inputCount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputCount.Name = "inputCount";
            this.inputCount.Size = new System.Drawing.Size(240, 31);
            this.inputCount.TabIndex = 22;
            this.inputCount.TextChanged += new System.EventHandler(this.inputCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ід:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Назва:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Кількість:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(130, 286);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnAddProduct.Size = new System.Drawing.Size(182, 54);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Добавити";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(434, 387);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputCount);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товари для дому";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProduct;
    }
}