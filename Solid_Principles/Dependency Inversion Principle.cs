//Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions.

//BadExmple High-level class depends on low-level implementation

public class CustomerNotification{
    private EmailService emialservice;

    public CustomerNotification()
    {
        emialservice = new EmailService();
    }
    public void NoitifyCustomer()
    {
        emialservice.SendEmail();
    }
}

public class EmailService
{
    public void SendEmail()
    {

    }
  
}

//Good Exmaple

public interface INotificationService{
    void Notify();
}

public class EmailService: INotificationService{
    public void Notify(){

    }
}

public class SMSService: INotificationService{
    public void Notify(){

    }
}

public class CustomerNotification{
    private readonly INotificationService _notification;

    public CustomerNotification(INotificationService notification){
            _notification = notification;
    }

    public void NotifyCustomer()
    {
        _notification.Notify();
    }
}

//In the good example, the CustomerNotification class depends on 
//the abstraction INotificationService. You can easily switch between EmailService and SMSService without modifying the CustomerNotification class.