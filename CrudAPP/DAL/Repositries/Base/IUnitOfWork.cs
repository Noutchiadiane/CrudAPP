using CrudAPP.BO;
using System;
using System.Threading.Tasks;

namespace CrudAPP.DAL.Repositries.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoyBase<Country> Countries { get; }
        IRepositoyBase<Hotel> Hotels { get; }
        Task Save();
    }
}
