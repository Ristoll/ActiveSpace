using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.Core.Entities;

[Index("Email", Name = "UQ__Users__A9D10534B812BE82", IsUnique = true)]
public partial class User
{
    [Key]
    public int UserId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    public string Surname { get; set; } = null!;

    [StringLength(50)]
    public string? MiddleName { get; set; }

    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public string? Description { get; set; }

    public string PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public bool IsActive { get; set; }

    public string? TrainerSessions { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("User")]
    public virtual ICollection<QRCode> QRCodes { get; set; } = new List<QRCode>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;

    [InverseProperty("Trainer")]
    public virtual ICollection<TrainerPlan> TrainerPlans { get; set; } = new List<TrainerPlan>();

    [InverseProperty("Client")]
    public virtual ICollection<TrainingSession> TrainingSessionClients { get; set; } = new List<TrainingSession>();

    [InverseProperty("Trainer")]
    public virtual ICollection<TrainingSession> TrainingSessionTrainers { get; set; } = new List<TrainingSession>();

    [InverseProperty("User")]
    public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();
}
