using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;

using TriNimbus_SimpleAPI.Models;

namespace TriNimbus_SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly AccountContext _dbContext;
        
        public AccountsController(AccountContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/accounts
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _dbContext.Accounts;
        }

        // GET api/accounts/5
        [HttpGet("{id}")]
        public Account Get(int id)
        {
            return _dbContext.Accounts.Find(id);
        }

        // POST api/accounts
        [HttpPost]
        public void Post([FromBody]Account value)
        {
            var account = new TriNimbus_SimpleAPI.Models.Account(){ Name = value.Name};

            _dbContext.Accounts.Update(account);
            _dbContext.SaveChanges();
        }

        // PUT api/accounts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Account value)
        {
            var account = _dbContext.Accounts.First(c => c.Id == id);

            account.Name = value.Name;

            _dbContext.Accounts.Update(account);
            _dbContext.SaveChanges();
        }

        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var account = new Account(){Id = id};

            _dbContext.Accounts.Remove(account);
            _dbContext.SaveChanges();
        }
    }
}
