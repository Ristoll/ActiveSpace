using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

public partial class TrainerPlan
{
    [Key]
    public int TrainerPlanId { get; set; }

    public int TrainerId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public int NumberOfSessions { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    public double? DiscountInPercents { get; set; }

    public string? Description { get; set; }

    [ForeignKey("TrainerId")]
    [InverseProperty("TrainerPlans")]
    public virtual User Trainer { get; set; } = null!;
}
