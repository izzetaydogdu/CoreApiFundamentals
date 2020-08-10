﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Models
{
    public class CampModel
    {       
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Moniker { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        [Range(1,100)]
        public int Length { get; set; } = 1;

        public string Venue { get; set; }
        public string locationAddress1 { get; set; }
        public string locationAddress2 { get; set; }
        public string locationAddress3 { get; set; }
        public string locationCityTown { get; set; }
        public string locationStateProvince { get; set; }
        public string locationPostalCode { get; set; }
        public string locationCountry { get; set; }

        public ICollection<TalkModel> Talks { get; set; }
    }
}
