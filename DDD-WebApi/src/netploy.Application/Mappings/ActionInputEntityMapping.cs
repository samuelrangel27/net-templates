using System;
using AutoMapper;
using netploy.Common.Models.Inputs;
using netploy.Domain.Entitites;

namespace netploy.Application.Mappings;

public class ActionInputEntityMapping : Profile
{
    public ActionInputEntityMapping()
    {
        CreateMap<TestActionInput, TestEntity>()
            .ForMember(x => x.Foo, opt => opt.MapFrom(x => x.Fizz))
            .ForMember(x => x.Bar, opt => opt.MapFrom(x => x.Buzz));
    }
}

