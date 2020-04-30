using System;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal:EfEntityRepositoryBase<Book,BookStoreContext>,IBookDal
    {
    }
}
