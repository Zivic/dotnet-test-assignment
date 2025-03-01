using System.Net.Http.Json;

namespace DogProject;

public static class Queries
{
    //svaka metoda ima isti naziv, razliku odredjuje tip argumenta
    public static async Task<ReadModels.DogNames> Query(QueryModels.GetAllTerrierDogs query)
    {
        var httpClient = new HttpClient();
        //TODO: check validity
        var dto =  await httpClient.GetFromJsonAsync<DogNameListDto>("https://dog.ceo/api/breed/terrier/list");
        
        //zovemo extension metodu koju smo definisali za List<string> type
        var sortedList = dto.message.BubbleSortByNameAndLength();
        return new ReadModels.DogNames{DogNamesList = sortedList};
    }
    //ovo nije trazeno u zadatku, jedina razlika je url, u principu i ovo moze jos da se sredi
    public static async Task<ReadModels.DogNames> Query(QueryModels.GetAllDogNames query)
    {
        var httpClient = new HttpClient();
        //TODO: check validity
        var dto =  await httpClient.GetFromJsonAsync<DogNameListDto>("https://dog.ceo/api/breeds/list");
        var sortedList = dto.message.BubbleSortByNameAndLength();
        return new ReadModels.DogNames{DogNamesList = sortedList};
    }
}