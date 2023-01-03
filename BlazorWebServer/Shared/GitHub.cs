using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebServer.Shared
{
    public class GitHub
    {
        public GitHub() { }

        public string? Name { get; set; }
        public int? Views { get; set; }
        public int? Clones { get; set; }
    }
}
