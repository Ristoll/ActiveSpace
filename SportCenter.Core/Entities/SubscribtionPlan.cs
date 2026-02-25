using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

public partial class SubscribtionPlan
{
    [Key]
    public int SubscribtionPlanId { get; set; }

    public int SubscribtionId { get; set; }

    public int DurationDays { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal PriceInDollars { get; set; }

    public double? DiscountInPercents { get; set; }

    public int MaxParticipants { get; set; }

    public bool IsRelevant { get; set; }

    public int? TrainerId { get; set; }

    [InverseProperty("SubscribtionPlan")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("SubscribtionId")]
    [InverseProperty("SubscribtionPlans")]
    public virtual Subscribtion Subscribtion { get; set; } = null!;

    [InverseProperty("SubscriptionPlan")]
    public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();
}
