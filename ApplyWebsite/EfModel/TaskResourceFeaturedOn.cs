using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceFeaturedOn
    {
        public TaskResourceFeaturedOn()
        {
            TaskResourceFeatured = new HashSet<TaskResourceFeatured>();
        }

        public int Id { get; set; }
        public string FeaturedOnName { get; set; }

        public virtual ICollection<TaskResourceFeatured> TaskResourceFeatured { get; set; }
    }
}
