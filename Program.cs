// See https://aka.ms/new-console-template for more information
var context = new BalanceInquiryContext();
var request = new BalanceInquiryRequest();

context.SetStrategy(new WumeiBalanceInquiryStrategy());

context.Process(request);

context.SetStrategy(new X9BalanceInquiryStrategy());

context.Process(request);
