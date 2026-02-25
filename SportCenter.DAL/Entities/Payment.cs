using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.DAL.Entities;

public partial class Payment
{
    [Key]
    public int PaymentId { get; set; }

    public int UserId { get; set; }

    public int SubscribtionPlanId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal SummInDollars { get; set; }

    public string? Description { get; set; }

    [ForeignKey("SubscribtionPlanId")]
    [InverseProperty("Payments")]
    public virtual SubscribtionPlan SubscribtionPlan { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Payments")]
    public virtual User User { get; set; } = null!;
}
