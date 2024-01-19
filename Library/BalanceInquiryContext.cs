public class BalanceInquiryContext
{
    private IBalanceInquiryStrategy _strategy;

    public BalanceInquiryContext()
    { }

    public BalanceInquiryContext(IBalanceInquiryStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IBalanceInquiryStrategy strategy) {
        _strategy = strategy;
    }

    public BalanceInquiryResult Process() {
        return this._strategy.Process();
    }
}