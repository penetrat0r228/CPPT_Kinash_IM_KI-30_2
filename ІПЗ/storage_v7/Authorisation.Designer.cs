namespace storage_v7
{
    partial class Authorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorisation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationLink = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизація";
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLink.ForeColor = System.Drawing.Color.Blue;
            this.registrationLink.Location = new System.Drawing.Point(125, 365);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(183, 25);
            this.registrationLink.TabIndex = 1;
            this.registrationLink.Text = "Зареєструватись";
            this.registrationLink.Click += new System.EventHandler(this.registrationLink_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(123, 151);
            this.email.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(182, 31);
            this.email.TabIndex = 5;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(123, 208);
            this.password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(182, 31);
            this.password.TabIndex = 11;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(145, 277);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.loginBtn.Size = new System.Drawing.Size(143, 54);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "Ввійти";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(434, 426);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.registrationLink);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorisation";
            this.Text = "Товари для дому";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registrationLink;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

