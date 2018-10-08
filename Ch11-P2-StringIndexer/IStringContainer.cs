using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P2_StringIndexer
{
    interface IStringContainer
    {
        string this[int index] { get; set; }
    }

    class SomeClass : IStringContainer
    {
        public string this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
