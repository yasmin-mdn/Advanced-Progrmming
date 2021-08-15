using System.Collections.Generic;

namespace myShared.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int id { get; set; }

        public string SearchHistoryString { get; set; }

        public User()
        {
        }
        public User(User t)
        {
            UserName = t.UserName;
            PassWord = t.PassWord;
            SearchHistoryString = "";
        }

        // public void AddToHistory(string st)
        // {
        //     SearchHistoryString += "|" + st;
        // }

    }
}