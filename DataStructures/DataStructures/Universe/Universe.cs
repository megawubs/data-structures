using System;
using System.Collections.Generic;
namespace DataStructures.Universe
{
    public class Universe
    {
        private HashSet<HashSet<HashSet<List<Vector>>>> _points;

        public Universe()
        {
            _points = new HashSet<HashSet<HashSet<List<Vector>>>>();
        }

        public void Add(Vector point)
        {
            var xList = _points.Get(point.X);
            var yList = xList.Get(point.Y);
            var zList = yList.Get(point.Z);
            zList.Add(point);
        }

        public List<Vector> Find(Vector point)
        {
            var xList = _points.Get(point.X);
            var yList = xList.Get(point.Y);
            return yList.Get(point.Z);
        }

//        public Vector FindNearest(Vector position, int radius)
//        {
//            Vector smallest = default (Vector);
//            for (int i = Math.Max(0, position.X - radius); i <= position.X + radius; i++)
//            {
//                for (int j = Math.Max(0, position.Y - radius); j < position.Y + radius; j++)
//                {
//                    for (int k = Math.Max(0, position.Z - radius); k < position.Y + radius; k++)
//                    {
//                        var vector = new Vector(i, j, k);
//                        var vectors = Find(vector);
//                        for (var i1 = 0; i1 < vectors.Count; i1++)
//                        {
//
//                        }
//                    }
//                }
//            }
//        }
    }
}