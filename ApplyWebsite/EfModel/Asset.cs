using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Asset
    {
        public Asset()
        {
            AssetItem = new HashSet<AssetItem>();
            Person = new HashSet<Person>();
            Task = new HashSet<Task>();
            TaskPhase = new HashSet<TaskPhase>();
            TaskResource = new HashSet<TaskResource>();
            Track = new HashSet<Track>();
            TrackPageContent = new HashSet<TrackPageContent>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<AssetItem> AssetItem { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<TaskPhase> TaskPhase { get; set; }
        public virtual ICollection<TaskResource> TaskResource { get; set; }
        public virtual ICollection<Track> Track { get; set; }
        public virtual ICollection<TrackPageContent> TrackPageContent { get; set; }
    }
}
