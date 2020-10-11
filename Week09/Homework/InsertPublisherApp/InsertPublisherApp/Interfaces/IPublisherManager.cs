using System;
using System.Collections.Generic;
using System.Text;
using InsertPublisherApp.Entities;

namespace InsertPublisherApp.Interfaces
{
    interface IPublisherManager
    {
        int Create(Publisher publisher);       
    }
}
