using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic
{
    public class Filter
    {
        public Filter()
        {
            Field = string.Empty;
            Operator = string.Empty;
        }

        public Filter(string field, string @operator)
        {
            Field = field;
            Operator = @operator;
        }
        public String Field { get; set; }
        public String? Value { get; set; }

        public String Operator { get; set; }
        public String? Logic { get; set; }
        public IEnumerable<Filter>? Filters { get; set; }

     
    }
}
