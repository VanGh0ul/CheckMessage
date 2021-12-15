
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
            this.tBlogin = new System.Windows.Forms.TextBox();
            this.BSetLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBLoginColTabName = new System.Windows.Forms.TextBox();
            this.tBCountColName = new System.Windows.Forms.TextBox();
            this.BDel = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.CbMessageTypes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBTableName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBDBpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBDBname = new System.Windows.Forms.TextBox();
            this.tBDBport = new System.Windows.Forms.TextBox();
            this.tBSrvIp = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // tBlogin
            // 
            this.tBlogin.Location = new System.Drawing.Point(79, 6);
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
            this.BSetLogin.Location = new System.Drawing.Point(229, 6);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tBLoginColTabName);
            this.panel1.Controls.Add(this.tBCountColName);
            this.panel1.Controls.Add(this.BDel);
            this.panel1.Controls.Add(this.BAdd);
            this.panel1.Controls.Add(this.CbMessageTypes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tBTableName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tBUsername);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBDBpass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBDBname);
            this.panel1.Controls.Add(this.tBDBport);
            this.panel1.Controls.Add(this.tBSrvIp);
            this.panel1.Location = new System.Drawing.Point(12, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 286);
            this.panel1.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(308, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 40);
            this.label10.TabIndex = 45;
            this.label10.Text = "Название таблицы\r\nс логином\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(308, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 40);
            this.label12.TabIndex = 46;
            this.label12.Text = "Название поля \r\nтаблицы с сообщениями";
            // 
            // tBLoginColTabName
            // 
            this.tBLoginColTabName.Location = new System.Drawing.Point(308, 109);
            this.tBLoginColTabName.Multiline = true;
            this.tBLoginColTabName.Name = "tBLoginColTabName";
            this.tBLoginColTabName.Size = new System.Drawing.Size(153, 25);
            this.tBLoginColTabName.TabIndex = 44;
            // 
            // tBCountColName
            // 
            this.tBCountColName.Location = new System.Drawing.Point(308, 180);
            this.tBCountColName.Multiline = true;
            this.tBCountColName.Name = "tBCountColName";
            this.tBCountColName.Size = new System.Drawing.Size(153, 25);
            this.tBCountColName.TabIndex = 48;
            // 
            // BDel
            // 
            this.BDel.BackColor = System.Drawing.Color.DarkRed;
            this.BDel.FlatAppearance.BorderSize = 0;
            this.BDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BDel.Location = new System.Drawing.Point(467, 235);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(266, 44);
            this.BDel.TabIndex = 50;
            this.BDel.Text = "Удалить";
            this.BDel.UseVisualStyleBackColor = false;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAdd.FlatAppearance.BorderSize = 0;
            this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BAdd.Location = new System.Drawing.Point(195, 235);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(266, 44);
            this.BAdd.TabIndex = 33;
            this.BAdd.Text = "Добавить ";
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // CbMessageTypes
            // 
            this.CbMessageTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMessageTypes.FormattingEnabled = true;
            this.CbMessageTypes.Location = new System.Drawing.Point(521, 38);
            this.CbMessageTypes.Name = "CbMessageTypes";
            this.CbMessageTypes.Size = new System.Drawing.Size(153, 21);
            this.CbMessageTypes.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(517, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Тип сообщений";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(304, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Имя таблицы";
            // 
            // tBTableName
            // 
            this.tBTableName.Location = new System.Drawing.Point(308, 38);
            this.tBTableName.Multiline = true;
            this.tBTableName.Name = "tBTableName";
            this.tBTableName.Size = new System.Drawing.Size(153, 25);
            this.tBTableName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(53, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Права";
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(114, 108);
            this.tBUsername.Multiline = true;
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(150, 25);
            this.tBUsername.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Пароль БД";
            // 
            // tBDBpass
            // 
            this.tBDBpass.Location = new System.Drawing.Point(114, 146);
            this.tBDBpass.Multiline = true;
            this.tBDBpass.Name = "tBDBpass";
            this.tBDBpass.Size = new System.Drawing.Size(150, 25);
            this.tBDBpass.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(43, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Имя БД";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(62, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ip Сервера";
            // 
            // tBDBname
            // 
            this.tBDBname.Location = new System.Drawing.Point(114, 74);
            this.tBDBname.Multiline = true;
            this.tBDBname.Name = "tBDBname";
            this.tBDBname.Size = new System.Drawing.Size(150, 25);
            this.tBDBname.TabIndex = 34;
            // 
            // tBDBport
            // 
            this.tBDBport.Location = new System.Drawing.Point(114, 182);
            this.tBDBport.Multiline = true;
            this.tBDBport.Name = "tBDBport";
            this.tBDBport.Size = new System.Drawing.Size(150, 25);
            this.tBDBport.TabIndex = 33;
            // 
            // tBSrvIp
            // 
            this.tBSrvIp.Location = new System.Drawing.Point(114, 38);
            this.tBSrvIp.Multiline = true;
            this.tBSrvIp.Name = "tBSrvIp";
            this.tBSrvIp.Size = new System.Drawing.Size(150, 25);
            this.tBSrvIp.TabIndex = 32;
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(12, 42);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(990, 246);
            this.DG.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSetLogin);
            this.Controls.Add(this.tBlogin);
            this.Controls.Add(this.DG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingToTray);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBlogin;
        private System.Windows.Forms.Button BSetLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbMessageTypes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBLoginColTabName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBTableName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBDBpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBDBname;
        private System.Windows.Forms.TextBox tBDBport;
        private System.Windows.Forms.TextBox tBSrvIp;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBCountColName;
        private System.Windows.Forms.Button BDel;
    }
}

