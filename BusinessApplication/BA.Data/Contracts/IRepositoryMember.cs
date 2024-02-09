namespace BA.Data.Contracts
{
    /// <summary>
    /// Interfaz encargada de establecer las reglas del RepositoryMember
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          IRepositoryMember.cs
    /// * Tipo:             Interfaz
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Septiembre 29
    /// * Propósito:        Establecer las reglas del repositorio de RepositoryMember
    /// *-----------------------------------------------------------------------------------------*
    public interface IRepositoryMember
    {

        #region [Create]
        Member Create(Member entity);
        #endregion


    }
}
