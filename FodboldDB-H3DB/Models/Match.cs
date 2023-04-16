using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodboldDB_H3DB.Models
{
    public class Match : BaseDomainObject
    {
        public DateTime MatchStart { get; set; }
        public DateTime MatchEnd { get; set; }
        public string Winner { get; set; }
        public List<Team> Teams { get; set; }
    }
}
