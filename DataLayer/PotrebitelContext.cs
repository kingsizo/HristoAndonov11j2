using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PotrebitelContext : IDB<Potrebitel, int>
    {
        private OpisanieDBContext _context;

        public PotrebitelContext(OpisanieDBContext context)
        {
            _context = context;
        }
        public void Create(Potrebitel item)
        {
            try
            {
                _context.Potrebitels.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Potrebitel Read(int key)
        {
            try
            {
                return _context.Potrebitels.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Potrebitel> ReadAll()
        {
            try
            {
                return _context.Potrebitels.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Potrebitel item)
        {
            try
            {
                Potrebitel a = Read(item.Id);

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
                Potrebitel a = Read(key);

                _context.Potrebitels.Remove(a);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public void Delete(Potrebitel item)
        {
            try
            {
                _context.Potrebitels.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
