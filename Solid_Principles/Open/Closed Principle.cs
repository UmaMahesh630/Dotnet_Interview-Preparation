//Definition: Software entities should be open for extension but closed for modification.

//BadExample
public class PaymentProcesing{
    public void processPayment(string PaymentType){

        if(PaymentType == "CreditCard")
        {

        }
        else if(PaymentType == "paypal"){

        }
    }
}

//Good Exmaple

public interface Ipayment{
    void Processpayment();
}

public class CreditCardPAyment : Ipayment{
    public void Processpayment(){

    }
}

public class PaypalPayment : Ipayment{
    public void Processpayment(){

    }
}


public class PaymentProcessPayment{
    private readonly Ipayment _paymentmethod;
    public PaymentProcessPayment(Ipayment Paymentmethod){
        _paymentmethod = Paymentmethod;
    }
    public void ProcessPayment(){
        _paymentmethod.Processpayment();
    }
}

///Here, the PaymentProcessor class does not need to be
///modified when new payment methods (like ApplePayPayment) are introduced. 
///You simply create a new class that implements IPaymentMethod.