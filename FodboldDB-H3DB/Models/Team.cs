using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodboldDB_H3DB.Models
{
    public class Team : BaseDomainObject
    {
       
        public string Name { get; set; }
        public string? State { get; set; }
        public Coach Coach { get; set; }
        public List<Match> Matches { get; set; }
    }
}
