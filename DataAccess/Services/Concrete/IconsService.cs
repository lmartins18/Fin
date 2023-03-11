using AutoMapper;
using fin.DataAccess.Repositories;
using fin.DTOS;

namespace fin.DataAccess.Services.Concrete;
public class IconsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public IconsService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<IconDTO>> GeticonAsync()
    {
        var icons = await _unitOfWork.Icons.GetAll();

        return _mapper.Map<IEnumerable<IconDTO>>(icons);
    }

    public async Task<bool> InsertAsync(IconDTO iconDto)
    {
        var icon = _mapper.Map<Icon>(iconDto);
        return await _unitOfWork.Icons.Add(icon);
    }

    public async Task<int> CompletedAsync()
    {
        return await _unitOfWork.CompletedAsync();
    }
}