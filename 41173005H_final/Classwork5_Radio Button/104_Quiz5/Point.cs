using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz4
{
    class Point
    {
        public double xCoord;
        public double yCoord;
        public const double Tol = 1e-10;

        // 計算點到另一個點的距離
        public double Distance(Point target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target), "輸入的目標點不能為 null。");

            return Math.Sqrt((this.xCoord - target.xCoord) * (this.xCoord - target.xCoord) +
                             (this.yCoord - target.yCoord) * (this.yCoord - target.yCoord));
        }

        // 計算向量的外積
        public static double CrossProduct(Point p1, Point p2, Point p3)
        {
            if (p1 == null || p2 == null || p3 == null)
            {
                throw new ArgumentNullException("輸入的點中存在 null 值，無法計算。");
            }

            if (double.IsNaN(p1.xCoord) || double.IsNaN(p1.yCoord) ||
                double.IsNaN(p2.xCoord) || double.IsNaN(p2.yCoord) ||
                double.IsNaN(p3.xCoord) || double.IsNaN(p3.yCoord))
            {
                throw new ArgumentException("輸入的點包含無效數值 (NaN)，無法計算。");
            }

            return (p2.xCoord - p1.xCoord) * (p3.yCoord - p1.yCoord) -
                   (p2.yCoord - p1.yCoord) * (p3.xCoord - p1.xCoord);
        }

        // 判斷兩條線段是否相交
        public static bool DoEdgesIntersect(Point a, Point b, Point c, Point d)
        {
            if (a == null || b == null || c == null || d == null)
            {
                throw new ArgumentNullException("輸入的點中存在 null 值，無法計算。");
            }

            // 判斷點是否在線段上
            bool IsPointOnSegment(Point p1, Point p2, Point p3)
            {
                return Math.Min(p1.xCoord, p2.xCoord) - Tol <= p3.xCoord && p3.xCoord <= Math.Max(p1.xCoord, p2.xCoord) + Tol &&
                       Math.Min(p1.yCoord, p2.yCoord) - Tol <= p3.yCoord && p3.yCoord <= Math.Max(p1.yCoord, p2.yCoord) + Tol;
            }

            // 計算外積值
            double d1 = CrossProduct(c, d, a);
            double d2 = CrossProduct(c, d, b);
            double d3 = CrossProduct(a, b, c);
            double d4 = CrossProduct(a, b, d);

            // 判斷是否相交
            if (d1 * d2 < 0 && d3 * d4 < 0)
                return true;

            // 判斷是否共線且重疊
            if (Math.Abs(d1) < Tol && IsPointOnSegment(c, d, a)) return true;
            if (Math.Abs(d2) < Tol && IsPointOnSegment(c, d, b)) return true;
            if (Math.Abs(d3) < Tol && IsPointOnSegment(a, b, c)) return true;
            if (Math.Abs(d4) < Tol && IsPointOnSegment(a, b, d)) return true;

            return false;
        }
    }

}
