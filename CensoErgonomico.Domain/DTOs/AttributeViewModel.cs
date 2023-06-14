using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class AttributeViewModel<T>
    {
        public Dictionary<string, string> AttributeDictionary { get; set; }
        public T Model { get; set; }
    }
}
