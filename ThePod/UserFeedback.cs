﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ThePod
{
    public partial class UserFeedback
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EpisodeId { get; set; }
        public string Tags { get; set; }
        public byte? Rating { get; set; }
        public string Review { get; set; }
        public string EpisodeName { get; set; }
        public string PodcastName { get; set; }
        public string Description { get; set; }
        public string AudioPreviewUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ExternalUrls { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}