using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodboldDB_H3DB.Models
{
    public class League : BaseDomainObject
    {
        public string Name { get; set; }
        public string? AgeGroup { get; set; }
        public string? LeagueId { get; set; }
        public List<Match> Matches { get; set; }
    }
}
