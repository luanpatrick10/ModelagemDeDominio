using System.ComponentModel.DataAnnotations;

namespace LP10.Catalogo.Application.DTOS
{
    public class CategoriaDTO
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Codigo { get; set; }
    }
}
