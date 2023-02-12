using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

[Table("Area")]
public partial class Area
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string CreateUserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreate { get; set; }

    [InverseProperty("Area")]
    public virtual ICollection<Issue> Issues { get; } = new List<Issue>();
}
