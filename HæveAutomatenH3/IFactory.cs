using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    interface IFactory<T>
    {
        T Generate(Person person);
    }
}
