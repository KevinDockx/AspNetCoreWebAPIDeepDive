namespace CourseLibrary.API.Services;

public class PropertyMapping<TSource, TDestination>(
    Dictionary<string, PropertyMappingValue> mappingDictionary) : IPropertyMapping
{
    public Dictionary<string, PropertyMappingValue> MappingDictionary
    { get; private set; } = mappingDictionary ??
            throw new ArgumentNullException(nameof(mappingDictionary));
}