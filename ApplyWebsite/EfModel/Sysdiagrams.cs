﻿using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Sysdiagrams
    {
        public string Name { get; set; }
        public int PrincipalId { get; set; }
        public int DiagramId { get; set; }
        public int? Version { get; set; }
        public byte[] Definition { get; set; }
    }
}
