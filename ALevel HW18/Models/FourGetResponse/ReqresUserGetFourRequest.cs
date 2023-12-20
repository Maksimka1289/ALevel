using Newtonsoft.Json;

namespace ALevel_HW18.Models
{
    internal sealed class ReqresUserGetFourRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        [JsonProperty("pantone_value")]
        public string PantoneValue { get; set; }
    }
}
