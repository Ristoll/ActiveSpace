using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.DAL.Entities;

[Table("TrainingSession")]
public partial class TrainingSession
{
    [Key]
    public int TrainingSessionId { get; set; }

    public int TrainerId { get; set; }

    public int ClientId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartsAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndsAt { get; set; }

    public int StatusId { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("TrainingSessionClients")]
    public virtual User Client { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("TrainingSessions")]
    public virtual TrainingStatus Status { get; set; } = null!;

    [ForeignKey("TrainerId")]
    [InverseProperty("TrainingSessionTrainers")]
    public virtual User Trainer { get; set; } = null!;
}
