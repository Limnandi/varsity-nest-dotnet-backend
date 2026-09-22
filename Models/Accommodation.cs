namespace varsity_nest_dotnet_backend.Models;

// Represents one accommodation listing in Varsity Nest.
public class Accommodation
{
    // Unique identifier for this accommodation.
    public int Id { get; set; }

    // Name displayed to students.
    public string Name { get; set; } = string.Empty;

    // Description of the accommodation.
    public string Description { get; set; } = string.Empty;

    // Physical address of the accommodation.
    public string Address { get; set; } = string.Empty;

    // Monthly rental price.
    public decimal Price { get; set; }

    // Whether students can currently see this listing.
    public bool IsActive { get; set; }

    // Whether the accommodation is featured on Varsity Nest.
    public bool Featured { get; set; }

    // Current accreditation status.
    public string AccreditationStatus { get; set; } = string.Empty;

    // Average rating calculated from student reviews.
    public decimal Rating { get; set; }

    // Number of reviews received.
    public int ReviewCount { get; set; }

    // When the accommodation was created.
    public DateTime CreatedAt { get; set; }
}