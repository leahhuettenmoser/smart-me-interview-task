namespace DataSource.DataStructures;

public readonly record struct CantonDto(string Name, uint Population, List<City> Cities);