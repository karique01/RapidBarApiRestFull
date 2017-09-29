using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data.DTO
{
    public class bar
    {
        public bar(bars bar)
        {
            id = bar.id;
            name = bar.name;
            description = bar.description;
            idTypeBar = bar.idTypeBar;
            typeBarName = bar.bar_types.typeBarName;
            latitude = bar.latitude;
            longitude = bar.longitude;
            rate = bar.rate;
            address = bar.address;
            pictureId = bar.pictureId;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int idTypeBar { get; set; }
        public string typeBarName { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public double rate { get; set; }
        public string address { get; set; }
        public string pictureId { get; set; }
    }
}