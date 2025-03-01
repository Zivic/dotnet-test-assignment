namespace DogProject.Domain;

//value object
public record DogName
{
    public string Value { get; init; }

    internal DogName(string value)
    {
        Value = value;
    }

    //factory metoda
    public static DogName FromString(string dogName)
    {
        CheckValidity(dogName);
        return new DogName(dogName);
    }

    private static void CheckValidity(string dogName)
    {
        if (dogName.Length > 100) //primer
        {
            throw new ArgumentOutOfRangeException("Dog name cannot be longer than 100 characters.");
        }
        if (dogName.Length < 3) 
        {
            throw new ArgumentOutOfRangeException("Dog name cannot be shorter than 3 characters.");
        }
    }
    
    //implicitna konverzija u string
    public static implicit operator string(DogName self) => self.Value;
}