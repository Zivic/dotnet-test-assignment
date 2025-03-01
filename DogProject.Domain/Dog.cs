namespace DogProject.Domain;

/* nema smisla praviti entitete za ovaj zadatak jer ne persistiramo podatke
 ali sam napravio da bih pokazao dobre prakse 
*/
public class Dog
{
    public DogId Id { get; private set; }
    public DogName Name { get; }

    public Dog(DogId id, DogName name)
    {
        Id = id;
        Name = name;
    }
}