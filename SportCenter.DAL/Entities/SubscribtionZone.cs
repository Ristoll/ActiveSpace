using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.DAL.Entities;

public partial class SubscribtionZone
{
    [Key]
    public int SubscribtionZoneId { get; set; }

    public int SubscribtionId { get; set; }

    public int ZoneId { get; set; }

    [ForeignKey("SubscribtionId")]
    [InverseProperty("SubscribtionZones")]
    public virtual Subscribtion Subscribtion { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("SubscribtionZones")]
    public virtual Zone Zone { get; set; } = null!;
}
