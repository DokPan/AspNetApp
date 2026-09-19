using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetApp.Pages
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Group { get; set; } = "";
    }

    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; } = new();

        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { Id = 1, Name = "Иванов Иван", Group = "ИСПП-34" },
                new Student { Id = 2, Name = "Петров Пётр", Group = "ИСПП-45" },
                new Student { Id = 3, Name = "Сидорова Анна", Group = "ИСПП-45" },
            };
        }
    }
}