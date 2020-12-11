﻿using AutoMapper;
using Online_Clinic.Common.ViewModels;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Common.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Randevu, RandevuVM>().ReverseMap();
            CreateMap<BağışTalebi, BağışTalebiVM>().ReverseMap();
            CreateMap<Hasta, HastaVM>().ReverseMap();
            CreateMap<Doktor, DoktorVM>().ReverseMap();
        }
    }
}
