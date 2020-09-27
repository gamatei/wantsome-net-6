using curs2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace curs2.Interfaces
{
    public interface IPublisherManager
    {
        int Create(Publisher publisher);
        Publisher Read(int id);
        int Update(Publisher publisher);
        int Delete(int id);

        IList<Publisher> GetPublishersWhereNameIsLike(string value);
        }
}
