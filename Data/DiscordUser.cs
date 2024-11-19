namespace AlparRP.Data
{
    public class DiscordUser
    {
        public int Id { get; set; }  // Elsődleges kulcs
        public string DiscordId { get; set; }  // A Discord felhasználó egyedi azonosítója
        public string Username { get; set; }  // A felhasználó neve
        public string AvatarUrl { get; set; }  // A felhasználó profilképe
        public string Role { get; set; }  // A felhasználó szerepe/rangja a Discord szerveren
    }
}
