using Interface_and_Abstract_in_Real_Life_Example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract_in_Real_Life_Example.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
