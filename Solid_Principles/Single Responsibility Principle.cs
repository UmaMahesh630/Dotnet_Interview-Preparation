
//Definition: A class should have only one reason to change, meaning it should only have one job or responsibility.

//Bad Example
public class OrderService{
    public void ProcessOrder(OrderService order){
        SendEmail(order);
        LogError("Error processing ");
    }

    public void SendEmail(OrderService order)
    {

    }
    public void LogError(string name)
    {

    }
}

//Good Example

public class OrderService{
    private readonly OrderService order;
    private readonly LoggingService logging;

    OrderService(OrderService _order,LoggingService _logging){
        order = _order;
        logging = _logging;
    }
    public void ProcessORder(){
        order.SendEmail();
    }
}
public class EmailService{
    public void SendEmail(OrderService order){

    }
}
public class LoggingService{
    public void LogError(string message){

    }
}

//Now, the OrderService class is only responsible for processing orders,
// while EmailService handles emails, and LoggingService handles error logging, adhering to the SRP.