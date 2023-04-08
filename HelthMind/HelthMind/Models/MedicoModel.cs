using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace HelthMind.Models
{
    [Table("MEDICO")]
    public class MedicoModel
    {
        [Key]
        [Column("MEDICOID")]
        public int MedicoId { get; set; }
        
        [Column("NOMEMEDICO")]
        public string NomeMedico { get; set; }

        [Column("CPF")]
        public string Cpf { get; set; }

        [Column("ESPECIALIDADE")]
        public string Especialidade { get; set; }

        [Column("DATANASCIMENTO")]
        public Calendar DataNacimento { get; set; }

        [Column("CRM")]
        public string CRMMedico { get; set; }

        public MedicoModel(string NomeMedico, string cpf, string especialidade, Calendar dataNacimento, string CrmMedico)
        {
            NomeMedico = NomeMedico;
            Cpf = cpf;
            Especialidade = especialidade;
            DataNacimento = dataNacimento;
            CRMMedico = CrmMedico;
        }
    }
    
    

 }

