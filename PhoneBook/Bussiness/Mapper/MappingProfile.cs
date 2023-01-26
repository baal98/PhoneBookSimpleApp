using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PhoneBook_DataAccess;
using UsersModels;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //in this case we are mapping from the User model to the UserModelDTO
            //installing the automapper package will allow us to use the CreateMap method
            //the name of Nugget package is AutoMapper
            //with the ReverseMap method we are mapping from the UserModelDTO to the User model and not need to create a new method
            CreateMap<UserModelDTO, User>().ReverseMap();
            //CreateMap<User, UserModelDTO>();
        }
    }
}
