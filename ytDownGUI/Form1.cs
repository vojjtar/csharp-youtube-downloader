using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using System.Diagnostics;

namespace ytDownGUI
{
    public partial class MainWindow : Form
    {
        private ComboBox myCombBox;

        private List<string> information = new List<string>();

        private IEnumerable<VideoOnlyStreamInfo> videoStreams;

        string loading = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/35771931234507.564a1d2403b3a.gif";
        string placeHolder = "https://www.signfix.com.au/wp-content/uploads/2017/09/placeholder-600x400.png";
        string path;
        string videoName;

        bool fetcherino = false;
        bool? video = null;

        public MainWindow()
        {
            InitializeComponent();
            myCombBox = this.resolutionSelection;
            thumbnailImage.ImageLocation = placeHolder;
        }


        private async void downloadButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (System.IO.Directory.Exists(path))
                {
                    var youtube = new YoutubeClient();
                    
                    if (video == true)
                    {
                        await youtube.Videos.Streams.DownloadAsync(videoStreams.ToList()[resolutionSelection.SelectedIndex], $"{path}\\{videoName}.mp4");
                    }
                    else if (video == false)
                    {
                        await youtube.Videos.Streams.DownloadAsync(videoStreams.ToList()[resolutionSelection.SelectedIndex], $"{path}\\{videoName}.mp3");
                    }
                }
                else
                {
                    MessageBox.Show("You need to enter a path");
                }
            //}
            /*catch
            {
                MessageBox.Show("You have to fill in all the info.");
            }*/
        }

        private void videoSelectButton_Click(object sender, EventArgs e)
        {
            video = true;
            getData();
            /*if (fetcherino)
                Console.WriteLine($"Video is already fetched, fetcherino: {fetcherino}");
            else getData();*/
        }

        private void audioSelectButton_Click(object sender, EventArgs e)
        {
            video = false;
            getData();
            /*if (fetcherino)
                Console.WriteLine($"Video is already fetched, fetcherino: {fetcherino}");
            else getData();*/
        }


        private async void getData()
        {
            loadingImage.ImageLocation = loading;
            
            //try
            //{
                if (urlInput.Text == string.Empty) MessageBox.Show("url input cannot be empty!");
                if (video == null) MessageBox.Show("You gotta choose a file format");


                videoStreams = await fetch.fetchVideoData(myCombBox, urlInput.Text, information, video);

                thumbnailImage.ImageLocation = information[0];
                videoAuthorLabel.Text = information[1];
                videoNameLabel.Text = information[2];
    
                loadingImage.ImageLocation = string.Empty;

                fetcherino = true;

                videoName = fetch.trimString(information[2]);
                Console.WriteLine(videoName);
            //}
            /*catch
            {
                MessageBox.Show("You entered a wrong URL");
                loadingImage.ImageLocation = string.Empty;
            }*/
        }

        private void urlInput_TextChanged(object sender, EventArgs e)
        {
            if (fetcherino == true)
            {
                fetcherino = false;
                Console.WriteLine($"Url changed, Fetcherino: {fetcherino}");
            }
        }

        private void setPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                path = browser.SelectedPath;
            }
        }

        private void openPathButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("Wrong path");
            }
        }
    }
}
