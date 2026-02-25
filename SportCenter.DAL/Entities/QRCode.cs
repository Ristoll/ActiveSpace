using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportCenter.DAL.Entities;

public partial class QRCode
{
    [Key]
    public Guid Token { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime GeneratedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiresAt { get; set; }

    public bool IsUsed { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("QRCodes")]
    public virtual User User { get; set; } = null!;
}
