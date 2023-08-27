using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class BaseCountryDto
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}