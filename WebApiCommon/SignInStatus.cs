using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCommon
{
    public class SigninStatus
    {
        public string Status { get; set; }
        public string StatusDetails { get; set; }
        public int PersonId { get; set; }
        public int MessageId { get; set; }
        public string NeedAccountInfo { get; set; }
        public string RoleOkay { get; set; }
    }
}
