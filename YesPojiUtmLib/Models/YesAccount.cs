
namespace YesPojiUtmLib.Models
{
    public class YesAccount
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Quota Quota { get; set; }

        public YesAccount()
        {

        }

        public YesAccount(string u, string p = "")
        {
            Username = u;
            Password = p;
        }
    }
}
