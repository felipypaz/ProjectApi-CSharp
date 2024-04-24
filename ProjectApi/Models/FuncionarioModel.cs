using ProjectApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEmun Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEmun Turno { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();

    }
}
