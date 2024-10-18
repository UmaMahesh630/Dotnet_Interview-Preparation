//Definition: Subtypes should be substitutable for their base types without affecting the correctness of the program.

//Bad example

public class User{

public virtual void ResetPassword(){

}
}

public class AdminUSer : User{
    public override void ResetPassword()
    {
        //
    }
}
public class GuseUSer : User{
    public override void ResetPassword()
    {
      // throw new not implement exception;
    }
}

//Good Example: Use a more appropriate hierarchy

public abstract class User{

}

public class Admin : User{

public void ResetPassword(){
    //
}
}

public class GusetUser{
// Guest-specific functionality, no need for password reset
}

//Here, AdminUser and GuestUser do not inherit from a class
// that forces unnecessary or inappropriate behavior. The code respects 
//LSP by ensuring all subclasses behave correctly when substituted.