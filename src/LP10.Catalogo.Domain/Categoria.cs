using LP10.Core.Domain_Objects;

namespace LP10.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public ICollection<Produto> Produtos { get; private set; }

        protected Categoria() { }
        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }
    }
}