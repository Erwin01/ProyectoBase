using System.ComponentModel.DataAnnotations;

namespace BA.WebApi.Models
{
    /// <summary>
    /// Modelo usado para serializar y deserializar los datos de los clientes/usuarios
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          Member.cs
    /// * Tipo:             Model
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Septiembre 29
    /// * Propósito:        Serializar y deserializar los datos de los clientes/usuarios.
    /// *-----------------------------------------------------------------------------------------*
    /// 
    public class MemberModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, ErrorMessage = "The length for field {0} debe estar entre {1} caracteres")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "La longitud para este campo {0} debe estar entre {1} caracteres")]
        public string LastName { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        public ProjectModel Project { get; set; }
    }
}