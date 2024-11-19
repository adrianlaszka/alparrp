namespace AlparRP.Data
{
    public class UserActivityLog
    {
    // LogId lesz az elsődleges kulcs, így szükséges a HasKey használata a DbContext-ben
        public int LogId { get; set; } // Elsődleges kulcs: LogId
        public int UserId { get; set; } // Hivatkozás a felhasználóra (DiscordUser)
        public string Activity { get; set; } // Az aktivitás leírása
        public DateTime Timestamp { get; set; } // Időpont, amikor az aktivitás történt
        public DiscordUser User { get; set; } // Kapcsolat a DiscordUsers táblával
    }
}
