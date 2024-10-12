using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class TestCategory
{
    [Key]
    public int Id { get; set; }

    public string CategoryName { get; set; }
    
    public string CategoryDescription { get; set; }
}