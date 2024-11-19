namespace AlparRP.Models
{
    public class UserActivityLog
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public string Activity {  get; set; }
        public DateTime TimeStamp { get; set; }

        public DiscordUser User { get; set; } // Kapcsolat a DiscordUsers táblával
    }
}
