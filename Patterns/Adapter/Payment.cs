public class Payment : PayY, PayX {

    // for PayY
    private string customerCardNum = null!;

	public string getCustomerCardNum() {
		Console.WriteLine("PayY (Get)");
		return customerCardNum;
	}

	public void setCustomerCardNum (string customerCardNum) {
		Console.WriteLine("PayY (Set)");
		this.customerCardNum = customerCardNum;
	}

	// ------------------------------------------------------

	// for PayX Method
    public string getCreditCardNum()
    {
        Console.WriteLine("PayX (Get)");
        return getCustomerCardNum();
    }

    public void setCreditCardNum(string creditCardNum)
    {
        Console.WriteLine("PayX (Set)");
        setCustomerCardNum(creditCardNum);
    }
}