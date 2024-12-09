using DataSource;
using DataSource.DataStructures;
using Microsoft.AspNetCore.Mvc;

namespace SwissCitiesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CantonsController
{
    /// <summary>
    /// Gets the canton and all it's cities.
    /// </summary>
    /// <param name="cantonName">The name of the canton.</param>
    /// <returns>A dto describing the canton.</returns>
    [HttpGet]
    public ActionResult<CantonDto> Get([FromQuery] string cantonName)
    {
        return InMemoryCantonRepository.Get(cantonName);
    }

    /// <summary>
    /// Updates the population of a canton and all it's cities.
    /// </summary>
    /// <param name="updatedCanton">The updated population of a canton and all it's cities.</param>
    /// <returns>A dto describing the updated canton.</returns>
    [HttpPut("[action]")]
    public ActionResult<CantonDto> UpdateCantonPopulation([FromBody] CantonDto updatedCanton)
    {
        return InMemoryCantonRepository.UpdatePopulations(updatedCanton);
    }
}