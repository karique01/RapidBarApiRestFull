using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Application.Data.DTO
{
    public class barType
    {
        public barType(bar_types bar)
        {
            id = bar.id;
            typeBarName = bar.typeBarName;
        }
        public int id { get; set; }
        public string typeBarName { get; set; }
    }
}