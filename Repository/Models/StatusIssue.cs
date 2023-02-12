using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models;

[Table("StatusIssue")]
public partial class StatusIssue
{
    [Key]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [InverseProperty("Status")]
    public virtual ICollection<Issue> Issues { get; } = new List<Issue>();
}
