public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing the property instead of the field directly
        this.MyProperty = 10; 
    }
}