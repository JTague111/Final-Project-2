using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longlattest2
{
    public class Class1
    {
        var distance = new Coordinates(48.672309, 15.695585)
                .DistanceTo(
                    new Coordinates(48.237867, 16.389477),
                    UnitOfLength.Kilometers);
    }
}
