public class Adapter {

	public static void Run () {
        // PayX
        Payment myPay = new Payment();
        myPay.setCreditCardNum("12345");
        string cardX = myPay.getCreditCardNum();
        Console.WriteLine("PayX : " + cardX);

        // PayY
        myPay.setCustomerCardNum("678910");
        string cardY = myPay.getCustomerCardNum();
        Console.WriteLine("PayY : " + cardY);
    }	
}