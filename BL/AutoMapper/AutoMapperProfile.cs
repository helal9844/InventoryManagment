using AutoMapper;
using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Store, StoreWriteDTO>().ReverseMap();
            CreateMap<Store, StoreReadDTO>().ReverseMap();

            CreateMap<Item, ItemWriteDTO>().ReverseMap();
            CreateMap<Item, ItemReadDTO>().ReverseMap();

            CreateMap<StoreItem, StoreItemWriteDTO>().ReverseMap();
            CreateMap<StoreItem, StoreItemReadDTO>().ReverseMap();
        }
    }
}
