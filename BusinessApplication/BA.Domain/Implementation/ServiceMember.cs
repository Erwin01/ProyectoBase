using BA.Data;
using BA.Data.Contracts;
using BA.Data.Repository;
using BA.Domain.Contracts;

namespace BA.Domain.Implementation
{

    /// <summary>
    /// Servicio encargado de acceder al repositorio de Member
    /// </summary>
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          ServiceMember.cs
    /// * Tipo:             Servicio
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Setiembre 19
    /// * Propósito:        Acceder al repositorio de Member.
    /// *-----------------------------------------------------------------------------------------*
    public class ServiceMember : IServiveMember
    {

        readonly IRepositoryMember repository = new RepositoryMember();

        #region [Create]
        public Member Create(int Id, int proyectId, string firstName, string lastName, string title)
        {
            Member entity = new Member();
            {
                entity.Id = Id;
                entity.ProjectId = proyectId;
                entity.FirstName = firstName;
                entity.LastName = lastName;
                entity.Title = title;
            };

            return repository.Create(entity);
        }
        #endregion


    }
}
