using System.ComponentModel.DataAnnotations;

namespace BA.WebApi.Models
{
    /// <summary>
    /// Modelo usado para serializar y deserializar los datos de los miembros con proyectos
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          MemberProyect.cs
    /// * Tipo:             Model
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Agosto 29
    /// * Propósito:        Serializar y deserializar los datos de los miembros con proyectos.
    /// *-----------------------------------------------------------------------------------------*
    /// 
    public class MemberProyectModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Título")]
        [StringLength(20, ErrorMessage = "La longitud para este campo {0} debe estar entre {1} caracteres")]
        public string Title { get; set; }
        [Display(Name = "Nombre Proyecto")]
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        [Display(Name = "Nombres")]
        [StringLength(20, ErrorMessage = "La longitud para este campo {0} debe estar entre {1} caracteres")]
        public string FirstName { get; set; }
        [Display(Name = "Apellidos")]
        [StringLength(20, ErrorMessage = "La longitud para este campo {0} debe estar entre {1} caracteres")]
        public string LastName { get; set; }
    }
}