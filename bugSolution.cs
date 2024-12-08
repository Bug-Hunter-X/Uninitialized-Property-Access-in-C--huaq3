public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 10; 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); 
    }
}