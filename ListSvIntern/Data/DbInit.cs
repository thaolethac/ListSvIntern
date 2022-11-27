using ListSvIntern.Models;

namespace ListSvIntern.Data
{
    public static class DbInit
    {
        public static void Initialize(StudentContext student)
        {
            if (student.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student
                {
                    Msv = 21000234,
                    Name = "Hồ Thị Nghĩa",
                    DateBirth = "20/04/2003",
                    Khoa = "Y dược"
                },
                new Student
                {
                    Msv = 21000546,
                    Name = "Vũ Văn Trí",
                    DateBirth = "16/06/2003",
                    Khoa = "Công nghệ thông tin"
                },
                new Student
                {
                    Msv = 21000543,
                    Name = "Lê Thạc Nhật",
                    DateBirth = "06/02/2005",
                    Khoa = "Tự động hóa"
                },
                new Student
                {
                    Msv = 21000645,
                    Name = "Lê Thạc Thao",
                    DateBirth = "05/09/2003",
                    Khoa = "Công nghệ thông tin"
                }
            };
            foreach (Student s in students)
            {
                student.Students.Add(s);
            }
            student.SaveChanges();
        }
    }
}
