namespace Mundipagg.Models.Response
{
    public class GetUsagesDetailsResponse
    {
        public GetPeriodResponse Period { get; set; }

        public string SubscriptionId { get; set; }

        public int TotalAmount { get; set; }

        public int? TotalDiscount { get; set; }

        public int? TotalIncrement { get; set; }

        public ListUsagesDetailsResponse Usages { get; set; }
    }
}