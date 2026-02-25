using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

public partial class Subscribtion
{
    [Key]
    public int SubscribtionId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    [InverseProperty("Subscribtion")]
    public virtual ICollection<SubscribtionPlan> SubscribtionPlans { get; set; } = new List<SubscribtionPlan>();

    [InverseProperty("Subscribtion")]
    public virtual ICollection<SubscribtionZone> SubscribtionZones { get; set; } = new List<SubscribtionZone>();
}
