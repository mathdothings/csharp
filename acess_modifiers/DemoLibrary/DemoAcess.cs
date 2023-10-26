namespace DemoLibrary;
public class DemoAcess
{
    /*
    * this methos is only for acess-try
    */
    void Demo()
    {
        PrivateDemo();
    }
    
    /*
    * private members can only be acessible inside his scope declaration
    * in this case, he only can be acessible in DemoClass class scope
    * this means only things inside DemoClass can call the PrivateDemo method
    */
    private void PrivateDemo() { }
    private protected void PrivateProtectedDemo() { }
    protected void ProtectedDemo() { }
    protected internal void ProtectedInternal() { }
    internal void InternalDemo() { }
    public void PublicDemo() { }
}
