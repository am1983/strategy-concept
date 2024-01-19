public class X9BalanceInquiryStrategy : IBalanceInquiryStrategy
{
    public BalanceInquiryResult Process(BalanceInquiryRequest request)
    {
        // Do whatever magic is required to get the data necessary for the X9 based
        // balance inquiry to work.
        Console.WriteLine("Processing X9 Balance Request");
        return new BalanceInquiryResult();
    }
}