using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}