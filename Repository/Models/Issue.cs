using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

[Table("Issue")]
[Index("Id", Name = "IX_Issue", IsUnique = true)]
public partial class Issue
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

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

    [InverseProperty("Issue")]
    public virtual ICollection<Note> Notes { get; } = new List<Note>();

    [ForeignKey("StatusId")]
    [InverseProperty("Issues")]
    public virtual StatusIssue Status { get; set; } = null!;
}
