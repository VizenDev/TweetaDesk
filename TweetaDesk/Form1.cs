using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using Tweetinvi;
using Tweetinvi.Controllers;
using Tweetinvi.Credentials;
using Tweetinvi.Core;
using System.IO;
using Tweetinvi.Core.Parameters;
using System.Threading;
using Tweetinvi.Core.Exceptions;
using Tweetinvi.Core.Credentials;
using System.Diagnostics;
using System.Net;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Interfaces.DTO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace TweetaDesk
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        //ck, cs, at, ats are the string name for the credentials
        #region devCredentials
        /// <summary>
        /// strings ck, cs, at, ats are only used for testing purposes during development or to log in faster
        /// </summary>
        string
            ck = "Consumer Key goes here",
            cs = "Consumer Secret goes here",
            at = "Access Token goes here",
            ats = "Access Token Secret goes here",
            ip = "your ip goes here";

        #endregion

        string space = " ";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string count = tweetBox.Text;
            characterCount.Text = "Characters left: " + (140 - count.Length);
        }

        private void tweetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tweetBox.Text))
            {
                MessageBox.Show("Please make sure to insert text before trying to tweet something.");
            }

            else if (!string.IsNullOrWhiteSpace(tweetBox.Text))
            {
                //byte[] image = File.ReadAllBytes(fileBrowse.Text);
                var video = File.ReadAllBytes(fileBrowse.Text);
                var media = Upload.UploadVideo(video);
                Tweet.PublishTweet(tweetBox.Text, new PublishTweetOptionalParameters
                {
                    Medias = new List<IMedia> { media }
                });
            }
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            tweetBox.Clear();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Media Files (*.png, *.gif, *.jpg, *.mp4)| *.gif; *.png; *.jpg; *.mp4";
            if (result == DialogResult.OK) // Test result.
            {
                fileBrowse.Text = openFileDialog1.FileName;
            }
            else if (result == DialogResult.Cancel)
            {
                if (fileBrowse.Text == string.Empty)
                {
                    fileBrowse.Text = "";
                }
                else
                {
                    fileBrowse.Text = openFileDialog1.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private string ConvertUrlsToLinks(string msg)
        {
            string regex = @"((www\.|(http|https|ftp|news|file)+\:\/\/)[&#95;.a-z0-9-]+\.[a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)])";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);
            return r.Replace(msg, "<a href=\"$1\" title=\"Click to open in a new window or tab\" target=\"&#95;blank\">$1</a>").Replace("href=\"www", "href=\"http://www");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SendKeys.SendWait("^(c)");
            string strClip = Clipboard.GetText().Trim();
            if (Clipboard.GetText().Trim() == string.Empty)
            {
                return;
            }
            Process.Start(strClip);
            Clipboard.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var auth = User.GetAuthenticatedUser();
            var userTweets = auth.GetUserTimeline();
            var homeTimelineParameter = new HomeTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 100,
            };
            var timeline = Timeline.GetHomeTimeline(homeTimelineParameter);
            foreach (var tweet in timeline)
            {
                richTextBox1.AppendText("<b>" + tweet.CreatedBy + "</b>" + ": " + tweet.Text + "<br></br>");
                webBrowser1.DocumentText = richTextBox1.Text;
                webBrowser1.DocumentText = richTextBox1.Text;
                //listBox1.Items.Add(tweet.CreatedBy + ": " + tweet.Text);

                foreach (var media in tweet.Media)
                {
                    //media.MediaURL allows me to retrieve the images attached to a tweet.
                }
            }

        }

        private void refreshTweets_Click(object sender, EventArgs e)
        {


            var authenticatedUser = User.GetAuthenticatedUser();
            var userTweets = authenticatedUser.GetUserTimeline();
            var homeTimelineParameter = new HomeTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = 100,
            };
            var timeline = Timeline.GetHomeTimeline(homeTimelineParameter);
            foreach (var tweet in timeline)
            {
                richTextBox1.AppendText("<b>" + tweet.CreatedBy + "</b>" + ": " + tweet.Text + "<br><br>");
                webBrowser1.DocumentText = richTextBox1.Text;
                webBrowser1.DocumentText = richTextBox1.Text;
                //listBox1.Items.Add(tweet.CreatedBy + ": " + tweet.Text);

                foreach (var media in tweet.Media)
                {
                    //media.MediaURL allows me to retrieve the images attached to a tweet.
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("Copy", false, null);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.ExecCommand("SelectAll", false, null);

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.CheckState == CheckState.Checked)
            {
                dumbTweets.Visible = true;
            }

            else if (materialCheckBox1.CheckState == CheckState.Unchecked)
            {
                dumbTweets.Visible = false;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("dumbed tweets.txt", richTextBox1.Text.Replace("<b>", "").Replace("</b>", "").Replace("<br>", "\n"));
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 0 || materialTabControl1.SelectedIndex == 1)
            {
                materialDivider2.Visible = false;
                materialDivider3.Visible = false;
            }
            if (materialTabControl1.SelectedIndex == 2)
            {
                materialDivider2.Visible = true;
                materialDivider3.Visible = true;
            }
        }

        private void materialRaisedButton1_Click_3(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "";
            richTextBox1.Text = "";
        }

        private void loginUser_Click(object sender, EventArgs e)
        {
            var appCredentials = new TwitterCredentials(ck, cs);
            var url = Tweetinvi.CredentialsCreator.GetAuthorizationURL(appCredentials);

            Process.Start(url);

            string UserAnswer = Interaction.InputBox("Please enter your pincode you received.", "Pincode", "");

            if (UserAnswer == string.Empty)
            {
                return;
            }

                var userCredentials = Tweetinvi.CredentialsCreator.GetCredentialsFromVerifierCode(UserAnswer, appCredentials);
                Auth.SetCredentials(userCredentials);

                tweetButton.Enabled = true;
                loadTweets.Enabled = true;
                refreshTweets.Enabled = true;
                userLogin.Enabled = false;

                var user = User.GetAuthenticatedUser();

                var accountSettings = user.GetAccountSettings();
                var screenName = accountSettings.ScreenName;
                var followerCount = user.FollowersCount;

                pictureBox1.ImageLocation = user.ProfileImageUrl400x400;
                materialLabel1.Text = user.Name;
                materialLabel2.Text = user.Description;
                materialLabel3.Text = user.Location;
                linkLabel1.Text = user.Url;
                string follow = "follower";
                if (followerCount > 1)
                {
                    follow = "followers";
                }
                MessageBox.Show("Welcome to TweetaDesk: " + screenName + ", with a whopping " + followerCount + space + follow);

        }

        private void setUserCredentials_Click(object sender, EventArgs e)
        {
            WebRequest.Create("https://api.ipify.org/");
            var verifyip = new WebClient().DownloadString("https://api.ipify.org/");

            if (verifyip == ip)
            {
                Auth.SetUserCredentials(ck, cs, at, ats);

                var user = User.GetAuthenticatedUser();
                var accountSettings = user.GetAccountSettings();
                var screenName = accountSettings.ScreenName;
                var followerCount = user.FollowersCount;
                MessageBox.Show("Welcome to TweetaDesk: " + screenName + ", with a whopping " + followerCount + " followers");

                pictureBox1.ImageLocation = user.ProfileImageUrl400x400;
                materialLabel1.Text = user.Name;
                materialLabel2.Text = user.Description;
                materialLabel3.Text = user.Location;
                linkLabel1.Text = user.Url;
                loadTweets.Enabled = true;
            }
            else if (verifyip != ip)
            {
                setUserCredentials.Visible = false;
            }
        }

        private void materialRaisedButton1_Click_2(object sender, EventArgs e)
        {
            var authenticatedUser = User.GetAuthenticatedUser();
            var userTweets = authenticatedUser.GetUserTimeline();
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = 100;
            }
            var homeTimelineParameter = new HomeTimelineParameters
            {
                MaximumNumberOfTweetsToRetrieve = Convert.ToInt32(numericUpDown1.Value),
            };
            var timeline = Timeline.GetHomeTimeline(homeTimelineParameter);
            foreach (var tweet in timeline)
            {
                richTextBox1.AppendText("<b>" + tweet.CreatedBy + "</b>" + ": " + tweet.Text + "<br><br>");
                webBrowser1.DocumentText = richTextBox1.Text;
                webBrowser1.DocumentText = richTextBox1.Text;
                //listBox1.Items.Add(tweet.CreatedBy + ": " + tweet.Text);

                foreach (var media in tweet.Media)
                {
                    //media.MediaURL allows me to retrieve the images attached to a tweet.
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media Files (*.png, *.gif, *.jpg, *.mp4)| *.gif; *.png; *.jpg; *.mp4";
            string count = tweetBox.Text;
            characterCount.Text = "Characters left: " + (140 - count.Length);
            tweetButton.Enabled = false;
            loadTweets.Enabled = false;
            refreshTweets.Enabled = false;
            materialTabControl1.SelectTab(2);
            webBrowser1.DocumentText = "";

            WebRequest.Create("https://api.ipify.org/");
            var verifyip = new WebClient().DownloadString("https://api.ipify.org/");
            if (verifyip == ip)
            {
                setUserCredentials.Visible = true;
            }
            else if (verifyip != ip)
            {
                setUserCredentials.Visible = false;

            }
        }
    }
}
