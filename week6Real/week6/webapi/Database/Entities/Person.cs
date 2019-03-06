using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("person")]
public class Person
{
                [Column("person_id")]
                [Key]
                public long person_id { get; set; }

                [Column("first_name")]
                public string First_name { get; set; }

                [Column("middle_name")]
                public string Middle_name { get; set; }

                [Column("last_name")]
                public string Last_name { get; set; }

                public Student student { get; set; }
}