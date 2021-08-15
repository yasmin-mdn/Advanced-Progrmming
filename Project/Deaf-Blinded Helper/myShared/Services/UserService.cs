using myShared.Models;
namespace myShared.Services
{
    public class UserService
    {
        public User user;

        public UserService()
        {
        }

        public void UserServicePass(User user)
        {
            this.user = user;
            this.user.SearchHistoryString = user.SearchHistoryString;
        }
    }
}