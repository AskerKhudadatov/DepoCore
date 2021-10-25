using Entites.Intefaces;


namespace Entites.Model
{
  public  class Categor:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSize { get; set; }

    }
}
