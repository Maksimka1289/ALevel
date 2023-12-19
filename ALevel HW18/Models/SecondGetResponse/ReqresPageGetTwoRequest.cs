using ALevel_HW18.Models.FirstGetResponse;
using ALevel_HW18.Models.FiveGetResponse;

namespace ALevel_HW18.Models.SecondGetResponse
{
    internal sealed class ReqresPageGetTwoRequest
    {
        public ReqresUserFiveRequest Data { get; set; }
        public ReqresUserTwoRequest Support { get; set; }
    }
}
