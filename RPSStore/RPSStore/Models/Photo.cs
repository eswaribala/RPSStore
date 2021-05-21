using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.Models
{
   public class Photo
    { 
        public int AlbumId { get; set; }
        public int Id { get; set; }
    
        public String Title { get; set; }

        public String Url { get; set; }

        public String ThumbnailUrl { get; set; }

    }
}
