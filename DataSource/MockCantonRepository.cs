using DataSource.DataStructures;

namespace DataSource;

public static class MockCantonRepository
{
    private static Dictionary<string, Canton> _cantonCache = new();

    public static void Initialize()
    {
        var lines = File.ReadAllLines("swiss-cities.csv").Skip(1);
        foreach (var line in lines)
        {
            var split = line.Split(",");
            var cityName = split[0];
            var cantonName = split[1];
            var population = int.Parse(split[2]);
            if (_cantonCache.TryGetValue(cantonName, out var canton))
            {
                canton.Cities.Add(new City { Name = cityName, Population = population });
            }
            else
            {
                canton = new Canton
                {
                    Name = cantonName,
                    TotalPopulation = 0,
                    Cities = [new City { Name = cityName, Population = population }]
                };
                _cantonCache.Add(cantonName, canton);
            }
        
            canton.TotalPopulation += population;
        }
    }
    
    public static CantonDto Get(string cantonName)
    {
        if (!_cantonCache.TryGetValue(cantonName, out var canton))
        {
            throw new InvalidOperationException($"Canton {cantonName} does not exist.");
        }
        return new CantonDto(canton.Name, canton.TotalPopulation, canton.Cities.ToList());
    }
    
    public static CantonDto UpdatePopulations(CantonDto updatedCanton)
    {
        if (!_cantonCache.TryGetValue(updatedCanton.Name, out var canton))
        {
            throw new InvalidOperationException($"Canton {updatedCanton.Name} does not exist.");
        }

        foreach (var city in canton.Cities)
        {
            city.Population = updatedCanton.Cities.First(c => c.Name == city.Name).Population;
        }
        canton.TotalPopulation = updatedCanton.Population;

        _cantonCache[canton.Name] = canton;
        
        return new CantonDto(canton.Name, canton.TotalPopulation, canton.Cities.ToList());
    }
}