using System.Linq;

namespace Course2Test.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IQueryable<Module> Modules { get; set; }
    }
}
