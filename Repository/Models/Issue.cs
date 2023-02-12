using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

[Table("Issue")]
public partial class Issue
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [StringLength(50)]
    public string AreaId { get; set; } = null!;

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Description { get; set; } = null!;

    [StringLength(50)]
    public string CreateUserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreate { get; set; }

    [StringLength(50)]
    public string StatusId { get; set; } = null!;

    [ForeignKey("AreaId")]
    [InverseProperty("Issues")]
    public virtual Area Area { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Issues")]
    public virtual StatusIssue Status { get; set; } = null!;
}
