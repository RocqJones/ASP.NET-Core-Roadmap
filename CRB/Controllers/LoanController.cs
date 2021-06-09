using CRB.Models;
using CRB.Services;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;

namespace CRB.Controllers
{
    // Adding CRUD Methods in Loan Controller
    [Route("api/[controller]")]
    [ApiController]

    public class LoanController : ControllerBase
    {
        private readonly IDapper _dapper;

        public LoanController(IDapper dapper)
        {
            _dapper = dapper;
        }

        [HttpPost(nameof(Create))]
        public async Task<int> Create(LoanDataModel loanData)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("AccountID", loanData.AccountID, DbType.Int64);
            var result = await Task.FromResult(_dapper.Insert<int>("r_LoanRepaymentWriter", 
                dbparams, commandType: CommandType.StoredProcedure));
            return result;
        }

        [HttpGet(nameof(GetById))]
        public async Task<LoanDataModel> GetById(int OurBranchID)
        {
            var result = await Task.FromResult(_dapper.Get<LoanDataModel>($"SELECT * FROM t_Loan WHERE OurBranchID = {OurBranchID}", 
                null, commandType: CommandType.StoredProcedure));
            return result;
        }
    }
}