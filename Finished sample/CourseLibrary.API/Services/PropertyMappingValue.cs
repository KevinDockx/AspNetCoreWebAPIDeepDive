namespace CourseLibrary.API.Services;

public class PropertyMappingValue(IEnumerable<string> destinationProperties,
        bool revert = false)
{
    public IEnumerable<string> DestinationProperties { get; private set; } = destinationProperties
            ?? throw new ArgumentNullException(nameof(destinationProperties));
    public bool Revert { get; private set; } = revert;
}