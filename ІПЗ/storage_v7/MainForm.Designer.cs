namespace storage_v7
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogOut = new System.Windows.Forms.PictureBox();
            this.btnShowAllGoods = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNewGoods = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeachInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.imgLogOut);
            this.panel1.Controls.Add(this.btnShowAllGoods);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddNewGoods);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 71);
            this.panel1.TabIndex = 0;
            // 
            // imgLogOut
            // 
            this.imgLogOut.Image = ((System.Drawing.Image)(resources.GetObject("imgLogOut.Image")));
            this.imgLogOut.Location = new System.Drawing.Point(808, 11);
            this.imgLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLogOut.Name = "imgLogOut";
            this.imgLogOut.Size = new System.Drawing.Size(58, 43);
            this.imgLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogOut.TabIndex = 42;
            this.imgLogOut.TabStop = false;
            this.imgLogOut.Click += new System.EventHandler(this.imgLogOut_Click);
            // 
            // btnShowAllGoods
            // 
            this.btnShowAllGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btnShowAllGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllGoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnShowAllGoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnShowAllGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllGoods.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnShowAllGoods.ForeColor = System.Drawing.Color.White;
            this.btnShowAllGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllGoods.Location = new System.Drawing.Point(207, 11);
            this.btnShowAllGoods.Margin = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnShowAllGoods.Name = "btnShowAllGoods";
            this.btnShowAllGoods.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnShowAllGoods.Size = new System.Drawing.Size(193, 49);
            this.btnShowAllGoods.TabIndex = 41;
            this.btnShowAllGoods.Text = "Товари на складі";
            this.btnShowAllGoods.UseVisualStyleBackColor = false;
            this.btnShowAllGoods.Click += new System.EventHandler(this.btnShowAllGoods_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Trebuchet MS", 16.75F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(605, 20);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(121, 28);
            this.labelUserName.TabIndex = 20;
            this.labelUserName.Text = "UserName";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(405, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 0, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnEdit.Size = new System.Drawing.Size(193, 49);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Редагувати товар";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // btnAddNewGoods
            // 
            this.btnAddNewGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btnAddNewGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewGoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnAddNewGoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnAddNewGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewGoods.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnAddNewGoods.ForeColor = System.Drawing.Color.White;
            this.btnAddNewGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewGoods.Location = new System.Drawing.Point(9, 11);
            this.btnAddNewGoods.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnAddNewGoods.Name = "btnAddNewGoods";
            this.btnAddNewGoods.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnAddNewGoods.Size = new System.Drawing.Size(193, 49);
            this.btnAddNewGoods.TabIndex = 39;
            this.btnAddNewGoods.Text = "Новий товар";
            this.btnAddNewGoods.UseVisualStyleBackColor = false;
            this.btnAddNewGoods.Click += new System.EventHandler(this.btnAddNewGoods_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearchByName);
            this.panel2.Controls.Add(this.btnSearchById);
            this.panel2.Controls.Add(this.inputSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 273);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btnSearchByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchByName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnSearchByName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnSearchByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnSearchByName.ForeColor = System.Drawing.Color.White;
            this.btnSearchByName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByName.Location = new System.Drawing.Point(51, 203);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSearchByName.Size = new System.Drawing.Size(184, 49);
            this.btnSearchByName.TabIndex = 41;
            this.btnSearchByName.Text = "Пошук за назвою";
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchById
            // 
            this.btnSearchById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btnSearchById.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchById.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btnSearchById.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btnSearchById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchById.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.btnSearchById.ForeColor = System.Drawing.Color.White;
            this.btnSearchById.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchById.Location = new System.Drawing.Point(51, 142);
            this.btnSearchById.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSearchById.Size = new System.Drawing.Size(184, 49);
            this.btnSearchById.TabIndex = 40;
            this.btnSearchById.Text = "Пошук за ід";
            this.btnSearchById.UseVisualStyleBackColor = false;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSearch.Location = new System.Drawing.Point(51, 80);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(184, 31);
            this.inputSearch.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 57);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пошук товару";
            // 
            // labelSeachInfo
            // 
            this.labelSeachInfo.AutoSize = true;
            this.labelSeachInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelSeachInfo.ForeColor = System.Drawing.Color.Black;
            this.labelSeachInfo.Location = new System.Drawing.Point(331, 128);
            this.labelSeachInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeachInfo.Name = "labelSeachInfo";
            this.labelSeachInfo.Size = new System.Drawing.Size(167, 24);
            this.labelSeachInfo.TabIndex = 29;
            this.labelSeachInfo.Text = "Товари на складі:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(335, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 246);
            this.dataGridView1.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Назва товару";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 420;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "К-сть на складі";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(896, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSeachInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товари для дому";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewGoods;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeachInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAllGoods;
        private System.Windows.Forms.PictureBox imgLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}