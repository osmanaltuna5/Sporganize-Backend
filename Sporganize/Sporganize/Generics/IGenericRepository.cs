namespace Sporganize.Generics
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        public Entity GetById(int id);
        public List<Entity> GetAll();
        public Entity Add(Entity entity);
        public Entity Update(Entity entity);
        public void DeleteById(int id);
        public void DeleteByEntity(Entity entity);

    }

}
