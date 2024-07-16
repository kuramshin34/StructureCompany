using AutoMapper;
using StructureCompany.DTO;
using StructureCompany.Models;

namespace StructureCompany.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Person, CreatePersonDTO>().ReverseMap();
            CreateMap<Node, NodeDTO>().ReverseMap();
            CreateMap<Node, CreateNodeDTO>().ReverseMap();

        }
    }
}
