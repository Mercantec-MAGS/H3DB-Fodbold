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
    public class Coach : BaseDomainObject
    {
        public string Name { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
