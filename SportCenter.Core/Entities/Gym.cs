using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

[Table("Gym")]
public partial class Gym
{
    [Key]
    public int GymId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double? Area { get; set; }

    [InverseProperty("Gym")]
    public virtual ICollection<GymZone> GymZones { get; set; } = new List<GymZone>();
}
