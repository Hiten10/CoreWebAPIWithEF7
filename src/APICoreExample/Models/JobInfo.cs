using System;
using System.Collections.Generic;

namespace APICoreExample.Models
{
    public partial class JobInfo
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public DateTime LastExecutionDate { get; set; }
        public string Status { get; set; }
    }
}
