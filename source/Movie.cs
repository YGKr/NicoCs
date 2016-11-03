using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NicoCs
{
    namespace Movie
    {
        public class MovieInfo
        {
            public string VideoID;
            public string Title;
            public string Description;
            public string ThumbnailURL;
            public string FirstRetrieve;
            public string Length;
            public string MovieType;
            public string Size;
            public string Size_Low;
            public string ViewCount;
            public string CommentNumber;
            public string MylistCount;
            public string LatestComment;
            public string WatchURL;
            public string ThumbnailType;
            public string Embeddable;
            public string NoLivePlay;
            public string UserID;
            public string UserNickName;
            public string UserIconURL;
            public string ChannelID;
            public string ChannelName;
            public string ChannelIconURL;
            public string[] Tags = new string[10];

            public void GetMovieInfo(string ID)
            {
                string URL = "http://ext.nicovideo.jp/api/getthumbinfo/" + ID;
                string NameBuffer = "";
                int i = 0;

                XmlTextReader reader = new XmlTextReader(URL);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            NameBuffer = reader.Name;

                            break;

                        case XmlNodeType.Text:

                            if (NameBuffer == "video_id") this.VideoID = reader.Value;

                            if (NameBuffer == "title") this.Title = reader.Value;

                            if (NameBuffer == "description") this.Description = reader.Value;

                            if (NameBuffer == "thumbnail_url") this.ThumbnailURL = reader.Value;

                            if (NameBuffer == "first_retrieve") this.FirstRetrieve = reader.Value;

                            if (NameBuffer == "length") this.Length = reader.Value;

                            if (NameBuffer == "movie_type") this.MovieType = reader.Value;

                            if (NameBuffer == "size_high") this.Size = reader.Value;

                            if (NameBuffer == "size_low") this.Size_Low = reader.Value;

                            if (NameBuffer == "view_counter") this.ViewCount = reader.Value;

                            if (NameBuffer == "comment_num") this.CommentNumber = reader.Value;

                            if (NameBuffer == "mylist_counter") this.MylistCount = reader.Value;

                            if (NameBuffer == "last_res_body") this.LatestComment = reader.Value;

                            if (NameBuffer == "watch_url") this.WatchURL = reader.Value;

                            if (NameBuffer == "thumb_type") this.ThumbnailURL = reader.Value;

                            if (NameBuffer == "embeddable") this.Embeddable = reader.Value;

                            if (NameBuffer == "no_live_play") this.NoLivePlay = reader.Value;

                            if (NameBuffer == "user_id") this.UserID = reader.Value;

                            if (NameBuffer == "user_nickname") this.UserNickName = reader.Value;

                            if (NameBuffer == "user_icon_url") this.UserIconURL = reader.Value;

                            if (NameBuffer == "ch_id") this.ChannelID = reader.Value;

                            if (NameBuffer == "ch_name") this.ChannelName = reader.Value;

                            if (NameBuffer == "ch_icon_url") this.ChannelIconURL = reader.Value;

                            if (NameBuffer == "tag lock=\"1\"" || NameBuffer == "tag")
                            {
                                Tags[i] = reader.Value;
                                i++;
                            }

                            break;

                        default: break;
                    }
                }
            }
        }
    }
}
