using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("OpenQuestions")]
public class OpenQuestion
{
    [Key]
    public int Id { get; set; }

    public string QuestionText { get; set; }

    public string QuestionAnswer { get; set; }

    public DateTime CreatedAt { get; set; }

    public Test Test { get; set; }
    [ForeignKey("Test")]
    public int TestId { get; set; }
}