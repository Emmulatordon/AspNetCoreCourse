﻿using System.ComponentModel.DataAnnotations;

namespace CitiesInfo.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage ="provied the name")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
