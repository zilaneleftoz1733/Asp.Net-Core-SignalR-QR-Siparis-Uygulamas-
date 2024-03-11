using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {

        private readonly IAboutDal _aboutDal;


        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public object TGetListAll()
        {
            throw new NotImplementedException();
        }

        void IGenericService< About>.TAdd( About entity)
        {
           _aboutDal.Add(entity);
        }

        void IGenericService< About>.TDelete( About entity)
        {
          _aboutDal.Delete(entity);
        }

        List< About> IGenericService< About>.TGetAll()
        {
            return _aboutDal.GetAll();
        }

         About IGenericService< About>.TGetByID(int id)
        {
           return _aboutDal.GetByID(id);
        }

        void IGenericService< About>.TUpdate( About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
