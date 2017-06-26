using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AttrMapping
    {
        public int Id { get; set; }
        public int? MappedId { get; set; }
        public int? MappedToId { get; set; }

        public virtual Attr Mapped { get; set; }
        public virtual Attr MappedTo { get; set; }
    }
}
