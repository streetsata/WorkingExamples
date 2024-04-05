namespace Streetsata.Restaurant.Web
{
    public static class SD
    {
        public static string ProductAPIBase { get; set; } = string.Empty;
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
