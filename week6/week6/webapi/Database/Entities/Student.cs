
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
        [Column("student_id")]
        [Key]
        public long student_id {get; set;}

        [Column("email_address")]
        public string email_address {get; set;}

        [Column("person_id")]
        public long person_id {get; set;}

        public Person person { get; set; }
}