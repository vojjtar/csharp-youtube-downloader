using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace ytDownGUI
{
    class fetch
    {
        public static async Task<IEnumerable<YoutubeExplode.Videos.Streams.VideoOnlyStreamInfo>> fetchVideoData(ComboBox myCombBox, string url, List<string> information, bool? videoBool)
        {
            information.Clear();
            myCombBox.Items.Clear();

            var youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
            var video = await youtube.Videos.GetAsync(url);

            information.Add(video.Thumbnails.HighResUrl);
            information.Add(video.Author);
            information.Add(video.Title);

            //var streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();
            if (videoBool == true)
            {
                var videoStreams = streamManifest
                    .GetVideoOnly()
                    .OrderByDescending(v => v.VideoQuality)
                    .Where(s => s.Container.Name == "mp4");

                int i = 0;
                foreach (var streamInfo in videoStreams)
                {
                    i++;
                    Console.WriteLine($"{i}. " + streamInfo.VideoQualityLabel + $", {streamInfo.Size}");
                    myCombBox.Items.Add($"{i}. " + streamInfo.VideoQualityLabel + $", {streamInfo.Size}");
                }
                return (IEnumerable<VideoOnlyStreamInfo>)videoStreams;
            }
            else
            {
                var audioStreams = streamManifest.GetAudioOnly();

                int i = 0;
                foreach (var streamAudio in audioStreams)
                {
                    i++;
                    Console.WriteLine($"{i}. " + streamAudio.Bitrate + $", {streamAudio.Size}");
                    myCombBox.Items.Add($"{i}. " + streamAudio.Bitrate + $", {streamAudio.Size}");
                }
                return (IEnumerable<VideoOnlyStreamInfo>)audioStreams;
            }
        }

        public static string trimString(string name)
        {
            List<string> charsToRemove = new List<string> { " ", "<", ">", ":", "\"", "/", "\\", "|", "?", "*" };
            foreach (var chr in charsToRemove) name = name.Replace(chr, string.Empty);
            return name;
        }


    }
}
