using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data.Profiles
{
    public class CampProfile :Profile
    {
        public CampProfile()
        {
            //From -> To
            this.CreateMap<Camp, CampModel>(); 
        }
    }
}
