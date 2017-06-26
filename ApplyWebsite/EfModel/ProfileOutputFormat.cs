using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileOutputFormat
    {
        public ProfileOutputFormat()
        {
            Profile = new HashSet<Profile>();
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string FormatName { get; set; }
        public string FormatType { get; set; }
        public string FormatDescription { get; set; }
        public string FormatHtml { get; set; }

        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
