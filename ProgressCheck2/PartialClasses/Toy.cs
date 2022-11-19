using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressCheck2.DatabaseConnection
{
    public partial class Toy
    {
        public string Size => $"{Width}x{Height}";
    }
}
