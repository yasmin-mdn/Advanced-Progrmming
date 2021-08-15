using System;
using System.Collections.Generic;
using System.Linq;
using myShared.Models;
namespace myApi
{
    public class UserRepository
    {
        private static UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
            _userContext.users.Add(new User
            {
                UserName = "admin",
                PassWord = "123",
                SearchHistoryString = "",
                id = 0

            });
        }


        public bool CheckUserInfo(User user)
        {
            var result = _userContext.users.FirstOrDefault((t) => t.UserName == user.UserName && t.PassWord == user.PassWord);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        public string GetHistoryList(string user)
        {
            return _userContext.users.Where(t => t.UserName == user).First().SearchHistoryString;
        }
        public void RegisterNewUser(User user)
        {
            if (!IsAMember(user))
            {
                _userContext.Add(user);
                _userContext.SaveChanges();
            }

        }



        public bool IsAMember(User user)
        {
            var res = _userContext.users.Where((t) => t.UserName == user.UserName);
            if (res.Count() == 0)
            {
                return false;
            }
            return true;
        }
        public void AddTOHistory(string st)
        {
            var toks = st.Split(',');
            var toks2 = toks.ToList().Where((t) => !string.IsNullOrEmpty(t)).ToList();
            try
            {
                foreach (var item in _userContext.users)
                {
                    if (item.UserName == toks2[0])
                    {
                        item.SearchHistoryString += "|" + toks2[1];
                        _userContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(st);
            }

        }

    }
}