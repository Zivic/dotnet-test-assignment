namespace DogProject;

//odgovara formatu payload-a iz eksternog api-a
public class DogNameListDto
{
    public List<string> message { get; set; }
    public string status { get; set; }
}