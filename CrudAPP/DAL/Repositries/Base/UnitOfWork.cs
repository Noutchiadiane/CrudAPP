using CrudAPP.BO;
using System;
using System.Threading.Tasks;

namespace CrudAPP.DAL.Repositries.Base
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly RabbitmqContext _context;
        private IRepositoyBase<Country> _countries;
        private IRepositoyBase<Hotel> _hotels;

        public UnitOfWork(RabbitmqContext context)
        {
            _context = context;
        }
        public IRepositoyBase<Country> Countries => _countries ??= new RepositoryBase<Country>(_context);
        public IRepositoyBase<Hotel> Hotels => _hotels ??= new RepositoryBase<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
