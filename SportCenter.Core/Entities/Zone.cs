using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

[Table("Zone")]
public partial class Zone
{
    [Key]
    public int ZoneId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public double? Area { get; set; }

    [InverseProperty("Zone")]
    public virtual ICollection<GymZone> GymZones { get; set; } = new List<GymZone>();

    [InverseProperty("Zone")]
    public virtual ICollection<SubscribtionZone> SubscribtionZones { get; set; } = new List<SubscribtionZone>();
}
