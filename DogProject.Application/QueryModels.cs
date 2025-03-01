namespace DogProject;

public static class QueryModels
{
    public class GetAllDogNames
    {
        
    }

    public class GetAllTerrierDogs
    {
        
    }
    
    // nije implementirano
    // ako zelimo da unesemo naziv rase psa
    public class GetDogNamesOfASpecificBreed
    {
        public string BreedName { get; set; }
    }
    public class GetDogNamesOfASpecificSubBreed
    {
        public string SubBreedName { get; set; }
    }
}