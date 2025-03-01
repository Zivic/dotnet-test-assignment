namespace DogProject.Domain;

public record DogId
{
    public Guid Value { get; init; }

    public DogId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentNullException(nameof(Value), "Dog id cannot be empty");
        Value = id;
    }
    
    public static implicit operator Guid(DogId self) => self.Value;
}