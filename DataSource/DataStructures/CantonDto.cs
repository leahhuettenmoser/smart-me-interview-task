using System.Collections.Generic;

namespace DataSource.DataStructures;

public readonly record struct CantonDto(string Name, int Population, List<City> Cities);