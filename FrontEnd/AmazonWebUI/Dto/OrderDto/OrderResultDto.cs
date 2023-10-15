namespace AmazonWebUI.Dto.OrderDto
{
    public class OrderResultDto
    {
        public int OrderID { get; set; }
        public int SiparisNumarasi { get; set; }
        public int BuyTry { get; set; }
        public int BuyUsd { get; set; }
        public int SellUsd { get; set; }
        public int SellTry { get; set; }
        public int SellForCountry { get; set; }
        public string Country { get; set; }

    }
}
