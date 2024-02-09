using BA.Data;

namespace BA.Domain.Contracts
{
    /// <summary>
    /// Interfaz encargada de establecer las reglas de IServiceMember
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          IServiceMember.cs
    /// * Tipo:             Interfaz
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Septiembre 19
    /// * Propósito:        Establecer las reglas del servicio de IServiceMember
    /// *-----------------------------------------------------------------------------------------*
    public interface IServiveMember
    {

        #region [Create]
        Member Create(int Id, int proyectId, string firstName, string lastName, string title);
        #endregion
    }
}
