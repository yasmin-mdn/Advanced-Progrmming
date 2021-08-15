using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myShared.Repositories;
using myShared.Models;
namespace myApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        UserRepository _myrepo;

        public UserController(UserRepository repo)
        {
            _myrepo = repo;
        }

        [HttpGet("SearchHistory/{user}")]
        public ActionResult<string> GetHistory(string user)
        {
            return _myrepo.GetHistoryList(user);
        }


        [HttpPost("AddHistory/{st}")]
        public void AddHistory(string st)
        {
            _myrepo.AddTOHistory(st);
        }


        [HttpPost]
        public bool Register(User user)
        {
            if (_myrepo.IsAMember(user))
            {
                return false;
            }
            _myrepo.RegisterNewUser(user);
            return true;
        }

        [HttpPost("login")]
        public bool Login(User user)
        {
            return (_myrepo.CheckUserInfo(user));
        }


    }
}