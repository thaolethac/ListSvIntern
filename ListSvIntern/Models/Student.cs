using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListSvIntern.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Msv { get; set; }

        public string Name { get; set; }

        public string DateBirth { get; set; }

        public string Khoa { get; set; }
    }
}
