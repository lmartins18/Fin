using AutoMapper;
using fin.DataAccess.Repositories;
using fin.DTOS;

namespace fin.DataAccess.Services.Concrete;
public class AccountsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AccountsService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AccountDTO>> GetaccountAsync()
    {
        var accounts = await _unitOfWork.Accounts.GetAll();

        return _mapper.Map<IEnumerable<AccountDTO>>(accounts);
    }

    public async Task<bool> InsertAsync(AccountDTO AccountDto)
    {
        var account = _mapper.Map<Account>(AccountDto);
        return await _unitOfWork.Accounts.Add(account);
    }

    public async Task<int> CompletedAsync()
    {
        return await _unitOfWork.CompletedAsync();
    }
}