using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    class SocialMedia
    {
        public SocialMedia() { }
        public SocialMedia(string name)
        {
            social_name = name;
        }
        public string social_name { get; set; }
    }
}
