using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class VideoInfo
    {
        public VideoInfo() { }
        public VideoInfo(int id, string title, string sh_date, string pub_date) 
        {
            video_id = id;
            video_title = title;
            shooting_date = sh_date;
            publication_date = pub_date;
        }
        public int video_id {get; set; }
        public string video_title { get; set; }
        public string shooting_date { get; set; }
        public string publication_date { get; set; }

    }
}
