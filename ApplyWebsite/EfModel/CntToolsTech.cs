using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntToolsTech
    {
        public int ToolsTechId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetToolsAndTechnology ToolsTech { get; set; }
    }
}
