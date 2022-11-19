using System.ComponentModel.DataAnnotations.Schema;

namespace dbProj.Data.Identity
{
    [Table("Students",Schema ="data")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        
    }
}
