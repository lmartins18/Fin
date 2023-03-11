using AutoMapper;
using fin.DTOS;
using Microsoft.EntityFrameworkCore;

namespace fin.Mapping;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
       CreateMap<Transaction, TransactionDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom<CategoryNameResolver>())
            .ForMember(dest => dest.IconName, opt => opt.MapFrom<IconNameResolver>());
    }
}
public class CategoryNameResolver : IValueResolver<Transaction, TransactionDto, string>
{
    private readonly FinContext _dbContext;

    public CategoryNameResolver(FinContext dbContext)
    {
        _dbContext = dbContext;
    }

    public string Resolve(Transaction source, TransactionDto destination, string destMember, ResolutionContext context)
    {
        var category = _dbContext.Categories.FirstOrDefault(c => c.Id == source.CategoryId);
        return category?.Name;
    }
}
public class IconNameResolver : IValueResolver<Transaction, TransactionDto, string>
{
    private readonly FinContext _dbContext;

    public IconNameResolver(FinContext dbContext)
    {
        _dbContext = dbContext;
    }

    public string Resolve(Transaction source, TransactionDto destination, string destMember, ResolutionContext context)
    {
        var icon = _dbContext.Icons.FirstOrDefault(c => c.Id == source.);
        return icon?.Name;
    }
}