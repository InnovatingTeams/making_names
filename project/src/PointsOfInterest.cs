using System;
using System.Collections.Generic;
using System.Linq;

namespace project
{
    public class PointsOfInterest
    {
        private class Point
        {
            private double _x;
            private double _y;
            private double _radius;

            public bool OverlapsEnough(Point other)
            {
                var distance = Math.Sqrt(Math.Pow(_x - other._x, 2) + Math.Pow(_y - other._y, 2));
                return distance < (_radius + other._radius) / 2;
            }

            public static Point Smaller(Point lhs, Point rhs)
            {
                return lhs._radius < rhs._radius ? lhs : rhs;
            }

            public bool SmallEnough()
            {
                return _radius < 250;
            }
        }

        private List<Point> _points = new List<Point>();

        public void RemoveUninterestingPoints()
        {
            _points = _points.Where(p => p.SmallEnough()).ToList();
            var keepers = new List<Point>();
            Point maybe = null;
            foreach (var point in _points)
            {
                if (maybe is null)
                {
                    maybe = point;
                }
                else if (maybe.OverlapsEnough(point))
                {
                    maybe = Point.Smaller(maybe, point);
                }
                else
                {
                    keepers.Add(maybe);
                    maybe = null;
                }
            }

            _points = keepers;
        }
    }
}