//Definition: No client should be forced to depend on methods it does not use.
// Split interfaces so that clients only implement what they need.

//BadExample: One large interface forcing all implementing classes to provide unused functionality

public interface IDocument {
   public void Print();
   public void Scan();
   public void Fax();
}

public class ModernPRinter : IDocument{
    public void Print()
    {
        //
    }
    public void Scan()
    {
        //
    }
    public void Fax()
    {
        throw new notImpemetexaception();// don't use printer
    }
}

//Good Exmaple


public interface IPrint{
    void Print();
}
public interface IScan{
    void Scan();
}
public interface IFax{
    void Fax();
}

public class ModernPrinter : IPrint, IScan
{
    public void Print(){}
    public void Scan(){}
}
public class OldPrinter:IPrint,IScan,IFax{
    public void Print(){}
    public void Scan(){}
    public void Fax(){}
}
//In the good example, the printer classes only implement 
//the interfaces they actually need, ensuring that no class is forced to implement methods it doesn’t use.