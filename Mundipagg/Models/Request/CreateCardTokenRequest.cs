namespace Mundipagg.Models.Request
{
    public class CreateCardTokenRequest
    {
        public string Brand { get; set; }

        public string Cvv { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderName { get; set; }

        public string Number { get; set; }
    }
}