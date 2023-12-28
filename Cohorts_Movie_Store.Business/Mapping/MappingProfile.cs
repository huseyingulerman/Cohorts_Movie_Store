using AutoMapper;
using Cohorts_Movie_Store.Dtos.Actor;
using Cohorts_Movie_Store.Dtos.Customer;
using Cohorts_Movie_Store.Dtos.Director;
using Cohorts_Movie_Store.Dtos.Movie;
using Cohorts_Movie_Store.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieResponse>().ForMember(dest => dest.Director, config => config.MapFrom(src => src.Director.Firstname+" "+src.Director.Lastname))
                .ForMember(dest => dest.Customer, config => config.MapFrom(src => src.Customer.Firstname+" "+src.Customer.Lastname));
            CreateMap<MovieRequest, Movie>();

            CreateMap<Actor, ActorResponse>();
            CreateMap<ActorRequest, Actor>();

            CreateMap<Director, DirectorResponse>();
            CreateMap<DirectorRequest, Director>();

            CreateMap<CustomerRequest, Customer>();

        }
    }
}
