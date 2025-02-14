namespace CodeBlogFitness.BL.Models;

public class Gender
{
    public string Name { get; }

    public Gender(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name), "Gender name cannot be null or whitespace.");
        Name = name;
    }

    public override string ToString() => Name;
}