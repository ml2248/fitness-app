namespace CodeBlogFitness.BL.Models;

public class User
{
    public string Name { get; }
    public Gender Gender { get; }
    public DateTime BirthDate { get; }
    public double Height { get; set; }
    public double Weight { get; set; }

    public User(string name,
        Gender gender,
        DateTime birthDate,
        double height,
        double weight)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name), "User name cannot be null or whitespace.");
        if (gender == null)
            throw new ArgumentNullException(nameof(gender), "Gender name cannot be null.");
        if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            throw new ArgumentException("Birth date is invalid.", nameof(birthDate));
        if (height <= 0)
            throw new ArgumentException("Height cannot be less or equal to zero.", nameof(height));
        if (weight <= 0)
            throw new ArgumentException("Weight cannot be less or equal to zero.", nameof(height));
        Name = name;
        Gender = gender;
        BirthDate = birthDate;
        Height = height;
        Weight = weight;
    }
}