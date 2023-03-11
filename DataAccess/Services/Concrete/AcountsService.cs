using AutoMapper;
using fin.DataAccess.Repositories;
using fin.DTOS;

namespace fin.DataAccess.Services.Concrete;
public class AccountService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AccountDto>> GetaccountAsync()
    {
        var accounts = await _unitOfWork.Accounts.GetAll();

        return _mapper.Map<IEnumerable<AccountDto>>(accounts);
    }

    public async Task<bool> InsertAsync(AccountDto AccountDto)
    {
        var account = _mapper.Map<Account>(AccountDto);
        return await _unitOfWork.Accounts.Add(account);
    }

    public async Task<int> CompletedAsync()
    {
        return await _unitOfWork.CompletedAsync();
    }
}