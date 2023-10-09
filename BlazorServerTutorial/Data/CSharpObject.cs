using Microsoft.JSInterop;

namespace BlazorServerTutorial.Data;

public class CSharpObject
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }

    [JSInvokable]
    public static string StaticMethod() => "Static Method called!!!";
    [JSInvokable]
    public string ProxyMethod() => "Proxy Method called!!!";
    [JSInvokable]
    public CSharpObject ReturnCSharpObject() => new()
    {
        Name = "return new CSharpObject",
        Age = 2000,
        BirthDate = DateTime.Now
    };

    [JSInvokable]
    public void MethodWithPrimitiveParameters(string name, int age, DateTime birthDate)
    {
        Name = name;
        Age = age;
        BirthDate = birthDate;
    }

    [JSInvokable]
    public void MethodWithReferenceParameters(CSharpObject self)
    {
        Name = self.Name;
        Age = self.Age;
        BirthDate = self.BirthDate;
    }
}
