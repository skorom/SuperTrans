namespace Firebase.Login
{
    using Newtonsoft.Json;

    public class UserBase
    {
        public string username { get; set; }

        public string password { get; set; }
        public bool online { get; set; }
    }

    public class Register : UserBase
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }

    public class Login : UserBase
    {
        public long Timestamp { get; set; }
    }

    public class ServerTimeStamp
    {
        [JsonProperty(".sv")]
        public string TimestampPlaceholder { get; } = "timestamp";
    }
}