public class WumeiBalanceInquiryStrategy : IBalanceInquiryStrategy
{
    public BalanceInquiryResult Process(BalanceInquiryRequest request)
    {
        // Do whatever magic is required to get the data necessary for Wumei's
        // balance inquiry to work.
        Console.WriteLine("Processing WUMEI Balance Request");
        return new BalanceInquiryResult();
    }
}