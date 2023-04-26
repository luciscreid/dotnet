using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public interface IRobo
    {
        Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 50);
    }
}
