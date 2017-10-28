
namespace YesPojiUtmLib.Models
{
    public class Quota
    {
        public int QuotaId { get; set; }
        public double Available { get; set; }

        public int AccountId { get; set; }
        public virtual YesAccount Account { get; set; }
    }
}
