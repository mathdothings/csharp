namespace DemoLibrary;
public class AcessDemo
{
    /*
    * this methos is just for acess trying
    */
    void Demo() { }
    /*
    * private means only code inside his declared scope can acess it
    * in this case only code inside AcessDemo class scope can acess this method
    */
    private void PrivateDemo()
    { System.Console.WriteLine("PrivateDemo"); }

    /*
    * private protected means it can be acessed only by things who inherits this class
    * and also is in the same assembly
    */
    private protected void PrivateProtectedDemo()
    { System.Console.WriteLine("PrivateProtectedDemo"); }

    /*
    * protected means that this method can be acessed by anything
    * inside his declaration scope and also by anything who inherit
    * their declaration class
    * in this case, anything who inheriths the AcessDemo class can call this method
    */
    protected void ProtectedDemo()
    { System.Console.WriteLine("ProtectedDemo"); }

    protected internal void ProtectedInternalDemo()
    { System.Console.WriteLine("ProtectedInternalDemo"); }

    /*
    * internal means instead of just my declaration scope, 
    * i'll be available for anything in my assembly (project)
    * in this case, anything in DemoLibrary can acess any interal modifier
    */
    internal void InternalDemo()
    { System.Console.WriteLine("InternalDemo"); }

    /*
    * public means everything that can refer to this method, 
    * can acess it, even in different assemblies
    */
    public void PublicDemo()
    { System.Console.WriteLine("PublicDemo"); }
}
