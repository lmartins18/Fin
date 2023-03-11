using fin.DataAccess.Services.Concrete;
using fin.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace fin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Accounts : ControllerBase
    {
        private readonly AccountService _accountService;

        public Accounts(AccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost]
        public async Task<IActionResult> AddAccount(AccountDto account) 
        => await _accountService.InsertAsync(account) ? Ok() : BadRequest();
    }
}