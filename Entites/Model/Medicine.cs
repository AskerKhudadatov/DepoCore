

using Entites.Intefaces;

namespace Entites.Model
{
    public class Medicine : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Amount { get; set; }

    }
}