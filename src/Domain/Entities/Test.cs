using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Test
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    
    public TestCategory Category { get; set; }
    [ForeignKey("TestCategory")]
    public int CategoryId { get; set; }
}