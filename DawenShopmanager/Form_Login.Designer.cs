
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
            this.uiLabel_SystemTitle = new Sunny.UI.UILabel();
            this.uiTextBox_LoginAccount = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox_LoginPassword = new Sunny.UI.UITextBox();
            this.uiSymbolButton_Login = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Exit = new Sunny.UI.UISymbolButton();
            this.uiCheckBox_AutoLogin = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // uiLabel_SystemTitle
            // 
            this.uiLabel_SystemTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel_SystemTitle.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel_SystemTitle.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold);
            this.uiLabel_SystemTitle.Location = new System.Drawing.Point(113, 79);
            this.uiLabel_SystemTitle.Name = "uiLabel_SystemTitle";
            this.uiLabel_SystemTitle.Size = new System.Drawing.Size(525, 63);
            this.uiLabel_SystemTitle.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_SystemTitle.TabIndex = 0;
            this.uiLabel_SystemTitle.Text = "系统名称";
            this.uiLabel_SystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox_LoginAccount
            // 
            this.uiTextBox_LoginAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTextBox_LoginAccount.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBox_LoginAccount.ButtonSymbol = 61761;
            this.uiTextBox_LoginAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_LoginAccount.FillColor = System.Drawing.Color.White;
            this.uiTextBox_LoginAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_LoginAccount.Location = new System.Drawing.Point(305, 202);
            this.uiTextBox_LoginAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_LoginAccount.Maximum = 2147483647D;
            this.uiTextBox_LoginAccount.Minimum = -2147483648D;
            this.uiTextBox_LoginAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_LoginAccount.Name = "uiTextBox_LoginAccount";
            this.uiTextBox_LoginAccount.Size = new System.Drawing.Size(215, 29);
            this.uiTextBox_LoginAccount.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_LoginAccount.TabIndex = 1;
            this.uiTextBox_LoginAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_LoginAccount.Watermark = "请输入账号";
            this.uiTextBox_LoginAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_LoginAccount_KeyPress);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(230, 205);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(68, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
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
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "密  码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_LoginPassword
            // 
            this.uiTextBox_LoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTextBox_LoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.uiTextBox_LoginPassword.ButtonSymbol = 361552;
            this.uiTextBox_LoginPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 2);
            this.uiTextBox_LoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_LoginPassword.FillColor = System.Drawing.Color.White;
            this.uiTextBox_LoginPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_LoginPassword.Location = new System.Drawing.Point(305, 243);
            this.uiTextBox_LoginPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_LoginPassword.Maximum = 2147483647D;
            this.uiTextBox_LoginPassword.Minimum = -2147483648D;
            this.uiTextBox_LoginPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_LoginPassword.Name = "uiTextBox_LoginPassword";
            this.uiTextBox_LoginPassword.PasswordChar = '*';
            this.uiTextBox_LoginPassword.Size = new System.Drawing.Size(215, 29);
            this.uiTextBox_LoginPassword.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_LoginPassword.TabIndex = 3;
            this.uiTextBox_LoginPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_LoginPassword.Watermark = "请输入密码";
            // 
            // uiSymbolButton_Login
            // 
            this.uiSymbolButton_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton_Login.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Login.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Login.ForeSelectedColor = System.Drawing.Color.Empty;
            this.uiSymbolButton_Login.Location = new System.Drawing.Point(254, 319);
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
            this.uiSymbolButton_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton_Exit.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Exit.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_Exit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiSymbolButton_Exit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiSymbolButton_Exit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Exit.Location = new System.Drawing.Point(397, 319);
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
            // uiCheckBox_AutoLogin
            // 
            this.uiCheckBox_AutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox_AutoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_AutoLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox_AutoLogin.Location = new System.Drawing.Point(391, 278);
            this.uiCheckBox_AutoLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_AutoLogin.Name = "uiCheckBox_AutoLogin";
            this.uiCheckBox_AutoLogin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_AutoLogin.Size = new System.Drawing.Size(129, 29);
            this.uiCheckBox_AutoLogin.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_AutoLogin.TabIndex = 82;
            this.uiCheckBox_AutoLogin.Text = "下次自动登录";
            // 
            // Form_Login
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DawenShopmanager.Properties.Resources.LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiCheckBox_AutoLogin);
            this.Controls.Add(this.uiSymbolButton_Exit);
            this.Controls.Add(this.uiSymbolButton_Login);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiTextBox_LoginPassword);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBox_LoginAccount);
            this.Controls.Add(this.uiLabel_SystemTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Movable = false;
            this.Name = "Form_Login";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "用户登录";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.Transparent;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel_SystemTitle;
        private Sunny.UI.UITextBox uiTextBox_LoginAccount;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox_LoginPassword;
        private Sunny.UI.UISymbolButton uiSymbolButton_Login;
        private Sunny.UI.UISymbolButton uiSymbolButton_Exit;
        private Sunny.UI.UICheckBox uiCheckBox_AutoLogin;
    }
}