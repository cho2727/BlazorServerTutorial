using Microsoft.JSInterop;

namespace BlazorServerTutorial.Data;

public class CSharpObject
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }

    [JSInvokable]
    public static string StaticMethod() => "Static Method called!!!";
}
