using AutoMapper;
using fin.DTOS;

namespace fin.Mapping;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AccountDto, Account>().ReverseMap();
    }
}
