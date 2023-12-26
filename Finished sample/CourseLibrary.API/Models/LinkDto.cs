namespace CourseLibrary.API.Models;

public class LinkDto(string? href, string? rel, string method)
{
    public string? Href { get; private set; } = href;
    public string? Rel { get; private set; } = rel;
    public string Method { get; private set; } = method;
}