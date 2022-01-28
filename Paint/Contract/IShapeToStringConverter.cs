using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IShapeToStringConverter
    {
        public string Name { get; }

        public string ConvertToData(IShape shape);

        public IShape ConvertToUI(string buffer);
    }
}
