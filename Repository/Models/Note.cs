using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

[Table("Note")]
public partial class Note
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreate { get; set; }

    [StringLength(50)]
    public string CreateUserId { get; set; } = null!;

    [StringLength(500)]
    public string Text { get; set; } = null!;

    [StringLength(50)]
    public string IssueId { get; set; } = null!;
}
