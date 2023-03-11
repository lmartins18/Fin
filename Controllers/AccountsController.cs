using fin.DataAccess.Services.Concrete;
using fin.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace fin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountsService _accountService;

        public AccountsController(AccountsService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost]
        public async Task<IActionResult> AddAccount(AccountDTO account) 
        => await _accountService.InsertAsync(account) ? Ok() : BadRequest();
    }
}