
namespace pp04
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LLogin = new System.Windows.Forms.Label();
            this.tBlogin = new System.Windows.Forms.TextBox();
            this.BSetLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(748, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Success";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(12, 42);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(889, 246);
            this.DG.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол во сообщений:";
            // 
            // LCount
            // 
            this.LCount.AutoSize = true;
            this.LCount.Location = new System.Drawing.Point(125, 9);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(0, 13);
            this.LCount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Логин:";
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(216, 9);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(0, 13);
            this.LLogin.TabIndex = 10;
            // 
            // tBlogin
            // 
            this.tBlogin.Location = new System.Drawing.Point(618, 6);
            this.tBlogin.Multiline = true;
            this.tBlogin.Name = "tBlogin";
            this.tBlogin.Size = new System.Drawing.Size(153, 30);
            this.tBlogin.TabIndex = 11;
            // 
            // BSetLogin
            // 
            this.BSetLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BSetLogin.FlatAppearance.BorderSize = 0;
            this.BSetLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSetLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSetLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BSetLogin.Location = new System.Drawing.Point(777, 6);
            this.BSetLogin.Name = "BSetLogin";
            this.BSetLogin.Size = new System.Drawing.Size(124, 30);
            this.BSetLogin.TabIndex = 13;
            this.BSetLogin.Text = "Установить";
            this.BSetLogin.UseVisualStyleBackColor = false;
            this.BSetLogin.Click += new System.EventHandler(this.BSetLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSetLogin);
            this.Controls.Add(this.tBlogin);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingToTray);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TextBox tBlogin;
        private System.Windows.Forms.Button BSetLogin;
        private System.Windows.Forms.Label label1;
    }
}

