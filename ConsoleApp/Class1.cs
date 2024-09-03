namespace ConsoleApp;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<BodyType> BodyTypes { get; set; }
}

public class BodyType
{
    public int Id { get; set; }

    public string Name { get; set; }
}
