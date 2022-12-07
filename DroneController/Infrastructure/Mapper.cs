using AutoMapper;
using DroneController.DA.Models;
using DroneController.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroneController.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Drone, DroneModel>();
            CreateMap<DroneModel, Drone>();

            //CreateMap<UserModel, AppUser>();
            //CreateMap<AppUser, UserModel>();

            //CreateMap<UserManager<UserModel>, UserManager<AppUser>>();
            //CreateMap<UserManager<AppUser>, UserManager<UserModel>>();
        }

    }
}
