using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.DAL.Entities;

public partial class UserPlan
{
    [Key]
    public int UserPlanId { get; set; }

    public int SubscriptionPlanId { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [ForeignKey("SubscriptionPlanId")]
    [InverseProperty("UserPlans")]
    public virtual SubscribtionPlan SubscriptionPlan { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserPlans")]
    public virtual User User { get; set; } = null!;
}
