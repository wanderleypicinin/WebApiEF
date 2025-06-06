using System.ComponentModel.DataAnnotations;

namespace WebApiEF.Moldes
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string Estado { get; set; }
        [Required]
        [StringLength(70)]
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
