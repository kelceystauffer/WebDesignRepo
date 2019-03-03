using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Person> persons = new List<Person> {
            new Person {
                Id = 198726374,
                Email="kelcey@oit.edu"
            },
            new Person {
                Id = 123456789,
                Email = "stauffer@oit.edu"
            },
        };
    }
}