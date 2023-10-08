namespace BlazorServerTutorial.Data;

public interface IPerson
{
    string Name { get; set; }
}

public class Student : IPerson
{
    public string Name { get; set; } = "";
}

public class Teacher : IPerson
{
    public string Name { get; set; } = "";
}
