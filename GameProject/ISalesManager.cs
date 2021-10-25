using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ISalesManager
    {
        void Selling(Customer customer, Campaign campaign);
    }
}