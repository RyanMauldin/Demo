namespace Demo.AngularWeb.Models
{
    public class DefaultUserSettings : UserSettings
    {
        public DefaultUserSettings()
        {
            Id = 0;
            DisplayName = "Default";
            TimeZone = "UTC";
        }

        public DefaultUserSettings(int id, string displayName, string timeZone)
        {
            Id = id;
            DisplayName = displayName;
            TimeZone = timeZone;
        }
    }
}
