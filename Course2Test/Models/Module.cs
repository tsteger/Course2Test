using System.Linq;

namespace Course2Test.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IQueryable<Activity> Activitys { get; set; }
    }
}
