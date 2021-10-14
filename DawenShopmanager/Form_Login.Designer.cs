
namespace DawenShopmanager
{
    partial class Form_Login
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiSymbolButton_Login = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Exit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.Location = new System.Drawing.Point(113, 79);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(525, 63);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Dawen 实体店面收银系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBox1.ButtonSymbol = 61761;
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(305, 202);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(215, 29);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "请输入账号";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(230, 205);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(68, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "账  户：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(230, 246);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(68, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "密  码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBox2.ButtonSymbol = 61761;
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(305, 243);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.PasswordChar = '*';
            this.uiTextBox2.Size = new System.Drawing.Size(215, 29);
            this.uiTextBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox2.TabIndex = 3;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "请输入密码";
            // 
            // uiSymbolButton_Login
            // 
            this.uiSymbolButton_Login.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Login.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Login.ForeSelectedColor = System.Drawing.Color.Empty;
            this.uiSymbolButton_Login.Location = new System.Drawing.Point(254, 299);
            this.uiSymbolButton_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Login.Name = "uiSymbolButton_Login";
            this.uiSymbolButton_Login.Radius = 10;
            this.uiSymbolButton_Login.RectSelectedColor = System.Drawing.Color.Empty;
            this.uiSymbolButton_Login.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton_Login.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Login.StyleCustomMode = true;
            this.uiSymbolButton_Login.TabIndex = 80;
            this.uiSymbolButton_Login.Text = "登  录";
            this.uiSymbolButton_Login.Click += new System.EventHandler(this.uiSymbolButton_Login_Click);
            // 
            // uiSymbolButton_Exit
            // 
            this.uiSymbolButton_Exit.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Exit.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Exit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiSymbolButton_Exit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Exit.Location = new System.Drawing.Point(397, 299);
            this.uiSymbolButton_Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Exit.Name = "uiSymbolButton_Exit";
            this.uiSymbolButton_Exit.Radius = 10;
            this.uiSymbolButton_Exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton_Exit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiSymbolButton_Exit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton_Exit.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Exit.StyleCustomMode = true;
            this.uiSymbolButton_Exit.Symbol = 61453;
            this.uiSymbolButton_Exit.TabIndex = 81;
            this.uiSymbolButton_Exit.Text = "退  出";
            this.uiSymbolButton_Exit.Click += new System.EventHandler(this.uiSymbolButton_Exit_Click);
            // 
            // Form_Login
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DawenShopmanager.Properties.Resources.LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiSymbolButton_Exit);
            this.Controls.Add(this.uiSymbolButton_Login);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Movable = false;
            this.Name = "Form_Login";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Text = "用户登录";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UISymbolButton uiSymbolButton_Login;
        private Sunny.UI.UISymbolButton uiSymbolButton_Exit;
    }
}