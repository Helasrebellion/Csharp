public class Person
{
    private string name; // Private field to store the person's name
    private int age; // Private field to store the person's age

    // Public method to set the person's name
    public void SetName(string name)
    {
        this.name = name;
    }

    // Public method to get the person's name
    public string GetName()
    {
        return name;
    }

    // Public method to set the person's age
    public void SetAge(int age)
    {
        this.age = age;
    }

    // Public method to get the person's age
    public int GetAge()
    {
        return age;
    }
}
