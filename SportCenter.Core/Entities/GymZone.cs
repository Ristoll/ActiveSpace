using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

[PrimaryKey("GymId", "ZoneId")]
public partial class GymZone
{
    [Key]
    public int GymId { get; set; }

    [Key]
    public int ZoneId { get; set; }

    public double? Area { get; set; }

    [ForeignKey("GymId")]
    [InverseProperty("GymZones")]
    public virtual Gym Gym { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("GymZones")]
    public virtual Zone Zone { get; set; } = null!;
}
