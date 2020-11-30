namespace Demo.AngularWeb.Models
{
    public class UserSettings
    {
        public UserSettings()
        {

        }

        public UserSettings(int id, string displayName, string timeZone)
        {
            Id = id;
            DisplayName = displayName;
            TimeZone = timeZone;
        }

        public UserSettings(DefaultUserSettings defaultUserSettings)
        {
            Id = defaultUserSettings.Id;
            DisplayName = defaultUserSettings.DisplayName;
            TimeZone = defaultUserSettings.TimeZone;
        }

        public int Id { get; set; }

        public string DisplayName { get; set; }

        public string TimeZone { get; set; }
    }
}
