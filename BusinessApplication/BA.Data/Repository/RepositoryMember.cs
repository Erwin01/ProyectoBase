using BA.Data.Contracts;
using System;

namespace BA.Data.Repository
{
    /// <summary>
    /// Repositorio encargado de acceder a la tabla Member
    /// *-----------------------------------------------------------------------------------------*
    /// * Archivo:          RepositoryMember.cs
    /// * Tipo:             Repositorio
    /// * Autor:            Erwin Parales - Algar Tech
    /// * Fecha:            2019 Septiembre 29
    /// * Propósito:        Acceder a la tabla Member
    /// *-----------------------------------------------------------------------------------------*
    public class RepositoryMember : IRepositoryMember
    {

        #region [Create]
        /// <summary>
        /// Access Data Member
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Member Create(Member entity)
        {
            using (var context = new baServiciosVirtualesEntities())
            {
                try
                {
                    var result = context.Members.Add(entity);
                    context.SaveChanges();

                    return result;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return null;
                }
            } 
        }
        #endregion


    }
}
