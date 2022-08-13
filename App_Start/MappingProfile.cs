using AutoMapper;
using MvcLearning.Dtos;
using MvcLearning.Models;

namespace MvcLearning.App_Start
{
    public class MappingProfile : Profile
    {
        //install-package automapper -version:4.1
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}