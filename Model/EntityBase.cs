using System.ComponentModel.DataAnnotations;

namespace ConsoleApp27.Model
{
    //TODO: Дописать сущности
    internal abstract class EntityBase
    {
        [Key]
        public Guid Id {get; init;}
        public DateTime CreatData { get; init; }
        public DateTime? ModifiedData { get; init; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            CreatData = DateTime.UtcNow;
            ModifiedData = DateTime.UtcNow;
        }

    }
}