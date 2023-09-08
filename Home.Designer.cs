
namespace ChatApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.chatsPictureBox = new System.Windows.Forms.PictureBox();
            this.btnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLocalIP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFriendPort = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFriendIP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLocalPort = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.listMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtMessageBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblChats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chatsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // chatsPictureBox
            // 
            this.chatsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("chatsPictureBox.Image")));
            this.chatsPictureBox.Location = new System.Drawing.Point(127, 6);
            this.chatsPictureBox.Name = "chatsPictureBox";
            this.chatsPictureBox.Size = new System.Drawing.Size(57, 45);
            this.chatsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chatsPictureBox.TabIndex = 5;
            this.chatsPictureBox.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Activecolor = System.Drawing.Color.Teal;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.BorderRadius = 7;
            this.btnConnect.ButtonText = "Connect";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConnect.Iconimage")));
            this.btnConnect.Iconimage_right = null;
            this.btnConnect.Iconimage_right_Selected = null;
            this.btnConnect.Iconimage_Selected = null;
            this.btnConnect.IconMarginLeft = 25;
            this.btnConnect.IconMarginRight = 0;
            this.btnConnect.IconRightVisible = true;
            this.btnConnect.IconRightZoom = 0D;
            this.btnConnect.IconVisible = true;
            this.btnConnect.IconZoom = 70D;
            this.btnConnect.IsTab = false;
            this.btnConnect.Location = new System.Drawing.Point(65, 160);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.OnHovercolor = System.Drawing.Color.Teal;
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnect.selected = false;
            this.btnConnect.Size = new System.Drawing.Size(181, 40);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Textcolor = System.Drawing.Color.White;
            this.btnConnect.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtLocalIP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalIP.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtLocalIP.BorderThickness = 1;
            this.txtLocalIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalIP.Enabled = false;
            this.txtLocalIP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLocalIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalIP.isPassword = false;
            this.txtLocalIP.Location = new System.Drawing.Point(19, 73);
            this.txtLocalIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(129, 33);
            this.txtLocalIP.TabIndex = 11;
            this.txtLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFriendPort
            // 
            this.txtFriendPort.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtFriendPort.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendPort.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtFriendPort.BorderThickness = 1;
            this.txtFriendPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFriendPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFriendPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendPort.isPassword = false;
            this.txtFriendPort.Location = new System.Drawing.Point(166, 118);
            this.txtFriendPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtFriendPort.Name = "txtFriendPort";
            this.txtFriendPort.Size = new System.Drawing.Size(129, 31);
            this.txtFriendPort.TabIndex = 14;
            this.txtFriendPort.Text = "Port";
            this.txtFriendPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendPort.Enter += new System.EventHandler(this.txtFriendPort_Enter);
            this.txtFriendPort.Leave += new System.EventHandler(this.txtFriendPort_Leave);
            // 
            // txtFriendIP
            // 
            this.txtFriendIP.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtFriendIP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendIP.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtFriendIP.BorderThickness = 1;
            this.txtFriendIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFriendIP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFriendIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendIP.isPassword = false;
            this.txtFriendIP.Location = new System.Drawing.Point(166, 73);
            this.txtFriendIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtFriendIP.Name = "txtFriendIP";
            this.txtFriendIP.Size = new System.Drawing.Size(129, 33);
            this.txtFriendIP.TabIndex = 13;
            this.txtFriendIP.Text = "Friend\'s IP";
            this.txtFriendIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendIP.Enter += new System.EventHandler(this.txtFriendIP_Enter);
            this.txtFriendIP.Leave += new System.EventHandler(this.txtFriendIP_Leave);
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.BorderColorFocused = System.Drawing.Color.Teal;
            this.txtLocalPort.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalPort.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.txtLocalPort.BorderThickness = 1;
            this.txtLocalPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLocalPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalPort.isPassword = false;
            this.txtLocalPort.Location = new System.Drawing.Point(19, 116);
            this.txtLocalPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(129, 33);
            this.txtLocalPort.TabIndex = 17;
            this.txtLocalPort.Text = "Port";
            this.txtLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLocalPort.Enter += new System.EventHandler(this.txtLocalPort_Enter);
            this.txtLocalPort.Leave += new System.EventHandler(this.txtLocalPort_Leave);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblConnection.Location = new System.Drawing.Point(99, 54);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(121, 15);
            this.lblConnection.TabIndex = 21;
            this.lblConnection.Text = "Establish Connection";
            // 
            // homeTimer
            // 
            this.homeTimer.Enabled = true;
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(7, 210);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(301, 355);
            this.listMessage.TabIndex = 23;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageActive = null;
            this.btnSend.Location = new System.Drawing.Point(268, 573);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 33);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSend.TabIndex = 27;
            this.btnSend.TabStop = false;
            this.btnSend.Zoom = 10;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(240, 576);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 26;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMessageBox.BackgroundImage")));
            this.txtMessageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtMessageBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMessageBox.Icon = ((System.Drawing.Image)(resources.GetObject("txtMessageBox.Icon")));
            this.txtMessageBox.Location = new System.Drawing.Point(-1, 571);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(239, 37);
            this.txtMessageBox.TabIndex = 25;
            this.txtMessageBox.text = "";
            // 
            // lblChats
            // 
            this.lblChats.AutoSize = true;
            this.lblChats.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChats.Location = new System.Drawing.Point(122, 16);
            this.lblChats.Name = "lblChats";
            this.lblChats.Size = new System.Drawing.Size(0, 27);
            this.lblChats.TabIndex = 2;

            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(314, 615);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lblChats);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.txtFriendPort);
            this.Controls.Add(this.txtFriendIP);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chatsPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chatsPictureBox;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnect;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFriendPort;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFriendIP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLocalIP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLocalPort;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Timer homeTimer;
        public System.Windows.Forms.ListBox listMessage;
        private Bunifu.Framework.UI.BunifuImageButton btnSend;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTextbox txtMessageBox;
        private System.Windows.Forms.Label lblChats;
    }
}