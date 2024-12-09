using System.Collections.Generic;

namespace DataSource.DataStructures;
public class Canton
{
    public required string Name { get; set; }
    public required uint TotalPopulation { get; set; }
    public required List<City> Cities { get; set; } = [];
}
