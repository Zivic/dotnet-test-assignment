using DogProject.Domain;

namespace DogProject.Tests;

public class DogEntityTest
{
    [Fact]
    public void Dog_name_should_not_be_too_long()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => 
            DogName.FromString(new string('a', 101)));
    }

    [Fact]
    public void Dog_name_should_not_be_too_short()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            DogName.FromString("a"));
    }

    [Fact]
    public void Dog_id_should_not_be_empty()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new Dog(new DogId(Guid.Empty), DogName.FromString("sop")));
    }
}