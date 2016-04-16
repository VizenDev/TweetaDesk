namespace TweetaDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tweetsPage = new System.Windows.Forms.TabPage();
            this.dumbTweets = new MaterialSkin.Controls.MaterialRaisedButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshTweets = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loadTweets = new MaterialSkin.Controls.MaterialRaisedButton();
            this.posttweetPage = new System.Windows.Forms.TabPage();
            this.fileBrowse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.clearTweetBox = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tweetButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.characterCount = new MaterialSkin.Controls.MaterialLabel();
            this.tweetBox = new System.Windows.Forms.RichTextBox();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.userLogin = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.setUserCredentials = new MaterialSkin.Controls.MaterialRaisedButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tweetsPage.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.posttweetPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.userLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.materialTabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 438);
            this.panel1.TabIndex = 1;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tweetsPage);
            this.materialTabControl1.Controls.Add(this.posttweetPage);
            this.materialTabControl1.Controls.Add(this.settingsPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 0);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(634, 438);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tweetsPage
            // 
            this.tweetsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.tweetsPage.Controls.Add(this.materialRaisedButton1);
            this.tweetsPage.Controls.Add(this.dumbTweets);
            this.tweetsPage.Controls.Add(this.webBrowser1);
            this.tweetsPage.Controls.Add(this.richTextBox1);
            this.tweetsPage.Controls.Add(this.listBox1);
            this.tweetsPage.Controls.Add(this.refreshTweets);
            this.tweetsPage.Controls.Add(this.loadTweets);
            this.tweetsPage.Location = new System.Drawing.Point(4, 22);
            this.tweetsPage.Name = "tweetsPage";
            this.tweetsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tweetsPage.Size = new System.Drawing.Size(626, 412);
            this.tweetsPage.TabIndex = 0;
            this.tweetsPage.Text = "Tweets";
            // 
            // dumbTweets
            // 
            this.dumbTweets.Depth = 0;
            this.dumbTweets.Location = new System.Drawing.Point(25, 380);
            this.dumbTweets.MouseState = MaterialSkin.MouseState.HOVER;
            this.dumbTweets.Name = "dumbTweets";
            this.dumbTweets.Primary = true;
            this.dumbTweets.Size = new System.Drawing.Size(123, 32);
            this.dumbTweets.TabIndex = 7;
            this.dumbTweets.Text = "Dump Tweets";
            this.dumbTweets.UseVisualStyleBackColor = true;
            this.dumbTweets.Visible = false;
            this.dumbTweets.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.materialContextMenuStrip1;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(633, 371);
            this.webBrowser1.TabIndex = 6;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.materialContextMenuStrip1.ShowImageMargin = false;
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(169, 120);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Open URL";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Refresh Tweets";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem4.Text = "Copy Text";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem5.Text = "Select All";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem3.Text = "About TweetaDesk";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.richTextBox1.Location = new System.Drawing.Point(11, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(622, 364);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(610, 315);
            this.listBox1.TabIndex = 4;
            // 
            // refreshTweets
            // 
            this.refreshTweets.Depth = 0;
            this.refreshTweets.Location = new System.Drawing.Point(485, 377);
            this.refreshTweets.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshTweets.Name = "refreshTweets";
            this.refreshTweets.Primary = true;
            this.refreshTweets.Size = new System.Drawing.Size(133, 35);
            this.refreshTweets.TabIndex = 3;
            this.refreshTweets.Text = "Refresh Tweets";
            this.refreshTweets.UseVisualStyleBackColor = true;
            this.refreshTweets.Click += new System.EventHandler(this.refreshTweets_Click);
            // 
            // loadTweets
            // 
            this.loadTweets.Depth = 0;
            this.loadTweets.Location = new System.Drawing.Point(369, 377);
            this.loadTweets.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadTweets.Name = "loadTweets";
            this.loadTweets.Primary = true;
            this.loadTweets.Size = new System.Drawing.Size(110, 35);
            this.loadTweets.TabIndex = 2;
            this.loadTweets.Text = "Load Tweets";
            this.loadTweets.UseVisualStyleBackColor = true;
            this.loadTweets.Click += new System.EventHandler(this.materialRaisedButton1_Click_2);
            // 
            // posttweetPage
            // 
            this.posttweetPage.BackColor = System.Drawing.Color.White;
            this.posttweetPage.Controls.Add(this.fileBrowse);
            this.posttweetPage.Controls.Add(this.clearTweetBox);
            this.posttweetPage.Controls.Add(this.tweetButton);
            this.posttweetPage.Controls.Add(this.characterCount);
            this.posttweetPage.Controls.Add(this.tweetBox);
            this.posttweetPage.Location = new System.Drawing.Point(4, 22);
            this.posttweetPage.Name = "posttweetPage";
            this.posttweetPage.Padding = new System.Windows.Forms.Padding(3);
            this.posttweetPage.Size = new System.Drawing.Size(626, 412);
            this.posttweetPage.TabIndex = 1;
            this.posttweetPage.Text = "Post A Tweet";
            // 
            // fileBrowse
            // 
            this.fileBrowse.Depth = 0;
            this.fileBrowse.Hint = "Click To Browse";
            this.fileBrowse.Location = new System.Drawing.Point(17, 318);
            this.fileBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileBrowse.Name = "fileBrowse";
            this.fileBrowse.PasswordChar = '\0';
            this.fileBrowse.SelectedText = "";
            this.fileBrowse.SelectionLength = 0;
            this.fileBrowse.SelectionStart = 0;
            this.fileBrowse.Size = new System.Drawing.Size(417, 23);
            this.fileBrowse.TabIndex = 4;
            this.fileBrowse.UseSystemPasswordChar = false;
            this.fileBrowse.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // clearTweetBox
            // 
            this.clearTweetBox.Depth = 0;
            this.clearTweetBox.Location = new System.Drawing.Point(17, 373);
            this.clearTweetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearTweetBox.Name = "clearTweetBox";
            this.clearTweetBox.Primary = true;
            this.clearTweetBox.Size = new System.Drawing.Size(157, 32);
            this.clearTweetBox.TabIndex = 3;
            this.clearTweetBox.Text = "Clear Tweet Box";
            this.clearTweetBox.UseVisualStyleBackColor = true;
            this.clearTweetBox.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // tweetButton
            // 
            this.tweetButton.Depth = 0;
            this.tweetButton.Location = new System.Drawing.Point(290, 373);
            this.tweetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Primary = true;
            this.tweetButton.Size = new System.Drawing.Size(133, 32);
            this.tweetButton.TabIndex = 2;
            this.tweetButton.Text = "Tweet";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Click += new System.EventHandler(this.tweetButton_Click);
            // 
            // characterCount
            // 
            this.characterCount.AutoSize = true;
            this.characterCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.characterCount.Depth = 0;
            this.characterCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.characterCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.characterCount.Location = new System.Drawing.Point(283, 277);
            this.characterCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.characterCount.Name = "characterCount";
            this.characterCount.Size = new System.Drawing.Size(140, 19);
            this.characterCount.TabIndex = 1;
            this.characterCount.Text = "Characters left: 140";
            // 
            // tweetBox
            // 
            this.tweetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.tweetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tweetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tweetBox.Location = new System.Drawing.Point(17, 22);
            this.tweetBox.MaxLength = 140;
            this.tweetBox.Name = "tweetBox";
            this.tweetBox.Size = new System.Drawing.Size(417, 290);
            this.tweetBox.TabIndex = 0;
            this.tweetBox.Text = "";
            this.tweetBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.White;
            this.settingsPage.Controls.Add(this.materialTabControl2);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(626, 412);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "settings";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.userLogin);
            this.materialTabControl2.Controls.Add(this.tabPage2);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(626, 412);
            this.materialTabControl2.TabIndex = 0;
            // 
            // userLogin
            // 
            this.userLogin.Controls.Add(this.materialTabSelector2);
            this.userLogin.Controls.Add(this.setUserCredentials);
            this.userLogin.Controls.Add(this.linkLabel1);
            this.userLogin.Controls.Add(this.materialLabel3);
            this.userLogin.Controls.Add(this.materialLabel2);
            this.userLogin.Controls.Add(this.materialLabel1);
            this.userLogin.Controls.Add(this.pictureBox1);
            this.userLogin.Controls.Add(this.loginUser);
            this.userLogin.Location = new System.Drawing.Point(4, 22);
            this.userLogin.Margin = new System.Windows.Forms.Padding(0);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(618, 386);
            this.userLogin.TabIndex = 0;
            this.userLogin.Text = "Login";
            this.userLogin.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-4, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(690, 34);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // setUserCredentials
            // 
            this.setUserCredentials.Depth = 0;
            this.setUserCredentials.Location = new System.Drawing.Point(6, 344);
            this.setUserCredentials.Margin = new System.Windows.Forms.Padding(0);
            this.setUserCredentials.MouseState = MaterialSkin.MouseState.HOVER;
            this.setUserCredentials.Name = "setUserCredentials";
            this.setUserCredentials.Primary = true;
            this.setUserCredentials.Size = new System.Drawing.Size(286, 36);
            this.setUserCredentials.TabIndex = 20;
            this.setUserCredentials.Text = "Set User Credentials";
            this.setUserCredentials.UseVisualStyleBackColor = true;
            this.setUserCredentials.Click += new System.EventHandler(this.setUserCredentials_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(431, 181);
            this.linkLabel1.MaximumSize = new System.Drawing.Size(180, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 19;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(429, 141);
            this.materialLabel3.MaximumSize = new System.Drawing.Size(180, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 18;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoEllipsis = true;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(429, 88);
            this.materialLabel2.MaximumSize = new System.Drawing.Size(180, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 17;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(429, 50);
            this.materialLabel1.MaximumSize = new System.Drawing.Size(180, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TweetaDesk.Properties.Resources.default_profile_5_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(6, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // loginUser
            // 
            this.loginUser.Depth = 0;
            this.loginUser.Location = new System.Drawing.Point(431, 344);
            this.loginUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginUser.Name = "loginUser";
            this.loginUser.Primary = true;
            this.loginUser.Size = new System.Drawing.Size(181, 36);
            this.loginUser.TabIndex = 13;
            this.loginUser.Text = "User Login";
            this.loginUser.UseVisualStyleBackColor = true;
            this.loginUser.Click += new System.EventHandler(this.loginUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.materialCheckBox1);
            this.tabPage2.Controls.Add(this.materialTabSelector3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Settings";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(180, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Number of tweets to load";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.materialCheckBox1.FlatAppearance.BorderSize = 5;
            this.materialCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(12, 37);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(141, 27);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Advanced View";
            this.materialCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(-4, 0);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(675, 34);
            this.materialTabSelector3.TabIndex = 1;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider1.Location = new System.Drawing.Point(0, 24);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(152, 36);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(140, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(495, 38);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider2.Location = new System.Drawing.Point(625, 63);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(10, 34);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider3.Location = new System.Drawing.Point(0, 63);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(10, 34);
            this.materialDivider3.TabIndex = 3;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(235, 377);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(128, 35);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "Clear Tweets";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 502);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TweetaDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tweetsPage.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.posttweetPage.ResumeLayout(false);
            this.posttweetPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.userLogin.ResumeLayout(false);
            this.userLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tweetsPage;
        private System.Windows.Forms.TabPage posttweetPage;
        private System.Windows.Forms.TabPage settingsPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.RichTextBox tweetBox;
        private MaterialSkin.Controls.MaterialLabel characterCount;
        private MaterialSkin.Controls.MaterialRaisedButton tweetButton;
        private MaterialSkin.Controls.MaterialRaisedButton clearTweetBox;
        private MaterialSkin.Controls.MaterialRaisedButton refreshTweets;
        private MaterialSkin.Controls.MaterialRaisedButton loadTweets;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField fileBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage userLogin;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton loginUser;
        private MaterialSkin.Controls.MaterialRaisedButton setUserCredentials;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton dumbTweets;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

