using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public string CarBrand { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }
}
