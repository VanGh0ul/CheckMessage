
namespace pp04
{
    partial class Form_Alert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.BApp = new System.Windows.Forms.Button();
            this.BWeb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMsg.Location = new System.Drawing.Point(216, 46);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(116, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Text";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pp04.Properties.Resources.icons8_secured_letter_50px;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::pp04.Properties.Resources.icons8_cancel_50px;
            this.button1.Location = new System.Drawing.Point(405, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 56);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messages count:";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LTitle.Location = new System.Drawing.Point(12, 5);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(41, 21);
            this.LTitle.TabIndex = 4;
            this.LTitle.Text = "Title";
            // 
            // BApp
            // 
            this.BApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BApp.Location = new System.Drawing.Point(74, 86);
            this.BApp.Name = "BApp";
            this.BApp.Size = new System.Drawing.Size(129, 28);
            this.BApp.TabIndex = 5;
            this.BApp.Text = "Приложение";
            this.BApp.UseVisualStyleBackColor = true;
            this.BApp.Click += new System.EventHandler(this.BApp_Click);
            // 
            // BWeb
            // 
            this.BWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BWeb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BWeb.Location = new System.Drawing.Point(74, 86);
            this.BWeb.Name = "BWeb";
            this.BWeb.Size = new System.Drawing.Size(178, 28);
            this.BWeb.TabIndex = 6;
            this.BWeb.Text = "Перейти на сайт";
            this.BWeb.UseVisualStyleBackColor = true;
            this.BWeb.Click += new System.EventHandler(this.BWeb_Click);
            // 
            // Form_Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(479, 135);
            this.Controls.Add(this.BWeb);
            this.Controls.Add(this.BApp);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Alert";
            this.Text = "Form_Alert";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Button BApp;
        private System.Windows.Forms.Button BWeb;
    }
}