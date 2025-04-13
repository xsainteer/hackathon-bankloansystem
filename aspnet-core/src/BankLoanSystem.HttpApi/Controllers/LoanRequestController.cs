using System.Threading.Tasks;
using BankLoanSystem.Entities;
using BankLoanSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BankLoanSystem.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class LoanRequestController : BankLoanSystemController
{
    private readonly ILoanService _loanService;

    public LoanRequestController(ILoanService loanService)
    {
        _loanService = loanService;
    }

    [HttpPost]
    [Route("/loan/request")]
    public async Task<IActionResult> AddLoanRequest([FromBody]LoanRequest loanRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var scoring = await _loanService.AddRequestAsync(loanRequest);
        return Ok(scoring);
    }
}