namespace LP10.Core.Domain_Objects
{
    public class Entity
    {
        public Entity()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
