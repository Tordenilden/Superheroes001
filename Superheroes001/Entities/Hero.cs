using NodaTime;
using System.ComponentModel.DataAnnotations;

namespace Superheroes001.Entities
{
    public class Hero
    {
        [Key] // Attribute / Dataannotation => PK
        public int Id { get; set; }
      //  public int HeroId { get; set; }

        public string Name { get; set; }
        public string RealName { get; set; }
        public string Place { get; set; }
        //public DateTime DebutYear { get; set; }
        public DateTime DebutYear { get; set; }
    }
}
