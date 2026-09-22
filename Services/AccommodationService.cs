using varsity_nest_dotnet_backend.Models;

namespace varsity_nest_dotnet_backend.Services;

public class AccommodationService
{
    public List<Accommodation> GetAll()
    {
        var accommodations = new List<Accommodation>
        {
            new Accommodation
            {
                Id = 1,
                Name = "Campus View",
                Description = "Student accommodation near campus",
                Address = "Universitas",
                Price = 4500,
                IsActive = true,
                Featured = true,
                AccreditationStatus = "Accredited",
                Rating = 4.3m,
                ReviewCount = 27,
                CreatedAt = DateTime.UtcNow
            },

            new Accommodation
            {
                Id = 2,
                Name = "Student Haven",
                Description = "Affordable student accommodation",
                Address = "Willows",
                Price = 3800,
                IsActive = true,
                Featured = false,
                AccreditationStatus = "Provisionally Accredited",
                Rating = 4.0m,
                ReviewCount = 14,
                CreatedAt = DateTime.UtcNow
            }
        };

        return accommodations;
    }
}