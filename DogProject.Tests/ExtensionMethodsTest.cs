namespace DogProject.Tests;

public class ExtensionMethodsTest
{
    private List<string> mockData = new List<string>
    {
        "cde", "cd","c","bcd","bc","b", "abc","ab","a"
    };
    private List<string> expectedResult = new List<string>
    {
        "a","ab","abc","b","bc","bcd","c","cd","cde"
    };
    [Fact]
    public void Bubble_sort_returns_correct_order()
    {
        Assert.Equal(mockData.BubbleSortByNameAndLength(),expectedResult);
    }
}