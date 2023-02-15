var CreateWordFilterFn = (string[] filterWords) =>
{
    return (string input) =>
    {
        return string.Join(" ", input.Split(" ").Except(filterWords));
    };
};

var badWords = new string[] { "shit", "fuck", "idiot" };
var FilterBadWords = CreateWordFilterFn(badWords);
Console.WriteLine(FilterBadWords("Sikke en gang shit"));
// Udskriver: "Sikke en gang"
