// See https://aka.ms/new-console-template for more information
var context = new BalanceInquiryContext();

context.SetStrategy(new WumeiBalanceInquiryStrategy());

context.Process();

context.SetStrategy(new X9BalanceInquiryStrategy());

context.Process();
