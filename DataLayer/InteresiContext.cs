using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class InteresiContext : IDB<Interesi, int>
    {
        private OpisanieDBContext _context;

        public InteresiContext(OpisanieDBContext context)
        {
            _context = context;
        }
        public void Create(Interesi item)
        {
            try
            {
                _context.Interesis.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Interesi Read(int key)
        {
            try
            {
                return _context.Interesis.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Interesi> ReadAll()
        {
            try
            {
                return _context.Interesis.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Interesi item)
        {
            try
            {
                Interesi a = Read(item.Id);

                _context.Entry(a).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int key)
        {
            try
            {
                Interesi a = Read(key);

                _context.Interesis.Remove(a);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
