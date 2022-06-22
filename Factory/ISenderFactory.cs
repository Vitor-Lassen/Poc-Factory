using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Factory.Factory
{
    public interface ISenderFactory
    {
        void Send(Message message);
    }
}
