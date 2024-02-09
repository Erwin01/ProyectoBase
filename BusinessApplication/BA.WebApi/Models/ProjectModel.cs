using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BA.WebApi.Models
{
    /// <summary>
    /// Modelo usado para serializar y deserializar los datos de los proyectos.
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          Proyect.cs
    /// * Tipo:             Model
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Agosto 29
    /// * Propósito:        Serializar y deserializar los datos de los proyectos.
    /// *-----------------------------------------------------------------------------------------*
    /// 
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre Proyecto")]
        public string ProjectName { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Fecha Inicial")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Fecha Final")]
        public DateTime EndDate { get; set; }
        public ICollection<MemberModel> Members { get; set; }
    }
}