using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac8
{
   public interface SQLAzure
    {
        Task<bool> Authenticate();
    }
}
