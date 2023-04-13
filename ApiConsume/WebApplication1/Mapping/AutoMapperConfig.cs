using AutoMapper;
using EntityLayer.Concrate;
using HotelProject.DtoLayer.Dtos.RoomDto;

namespace HotelReservation.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room,RoomAddDto>().ReverseMap();  

            CreateMap<Room, UpdateRoomDto>().ReverseMap();
        
        }
    }
}
