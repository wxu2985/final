using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace _106_Quiz4
{
    class Quadrilateral
    {
        public Point[] ptArr2 = new Point[4];
        public const double Tol = 1e-10;

        public void isNotCross()
        {
            Point temp = new Point();
            for (int i = 0; i < 3; i++)
            {
                if (Point.DoEdgesIntersect(ptArr2[i % 4], ptArr2[(i + 1) % 4], ptArr2[(i + 2) % 4], ptArr2[(i + 3) % 4]))
                {
                    temp = ptArr2[(i + 1) % 4];
                    ptArr2[(i + 1) % 4] = ptArr2[(i + 2) % 4];
                    ptArr2[(i + 2) % 4] = temp;
                }
            }
        }
        private void SideLengths(double[] side)
        {
            isNotCross();
            for (int i = 0; i <= 3; i++)
                side[i] = ptArr2[i].Distance(ptArr2[(i + 1) % 4]);
        }
        public void CreatePoints()
        {
            for (int i = 0; i <= 3; i++)
                ptArr2[i] = new Point();
           
        }
        private double DiagonalLine(int a, int b)
        {
            double Dia1 = ptArr2[0].Distance(ptArr2[2]);  // 對角線\  (左上到右下)
            double Dia2 = ptArr2[1].Distance(ptArr2[3]);  // 對角線/  (右上到左下)
            if (a == 0 && b == 2)// ptArr2[0] 和 ptArr2[2]的距離
                return Dia1;
            else if (a == 1 && b == 3)// ptArr2[1] 和 ptArr2[3]的距離
                return Dia2;
            else
                return 0;
        }


        private double Angle(double a, double b, double c)
        {
            // 使用餘弦定理計算角度
            return Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
        }

        private double InteriorAngle(int num) //計算四邊形內角
        {
            double[] s = new double[4];  // 用來存儲四個邊的長度
            SideLengths(s);  // 計算四邊長度

            double[] angle = new double[4];  // 用來存儲四個角度
            angle[0] = Angle(s[0], s[1], DiagonalLine(0, 2));
            angle[1] = Angle(s[1], s[2], DiagonalLine(1, 3));
            angle[2] = Angle(s[2], s[3], DiagonalLine(0, 2));
            angle[3] = Angle(s[3], s[0], DiagonalLine(1, 3));
            return angle[num];
        }


        private bool isEqualAngle() // 判斷四個角是否為直角
        {
            double[] s = new double[4];  // 用來存儲四個邊的長度
            SideLengths(s);  // 計算四邊長度

            // 判斷所有角度是否為直角
            if (Math.Abs(InteriorAngle(0) - 90) < Tol && Math.Abs(InteriorAngle(1) - 90) < Tol && Math.Abs(InteriorAngle(2) - 90) < Tol && Math.Abs(InteriorAngle(3) - 90) < Tol)
                return true;
            else
                return false;
        }
        private bool isEqualSide() // 判斷是否為4個邊等長
        {
            double[] side = new double[4];
            // 改為只傳遞陣列，並讓 SideLengths 方法將邊長填入陣列
            SideLengths(side);

            return Math.Abs(side[0] - side[1]) < Tol && Math.Abs(side[1] - side[2]) < Tol &&
                   Math.Abs(side[2] - side[3]) < Tol && Math.Abs(side[3] - side[0]) < Tol;
        }

        private bool isEqualOppsiteAngle() // 判斷是否對角相等
        {
            double[] s = new double[4];
            SideLengths(s); // 計算四條邊的長度

            return Math.Abs(InteriorAngle(0) - InteriorAngle(2)) < Tol && Math.Abs(InteriorAngle(1) - InteriorAngle(3)) < Tol;
        }

        private bool hasParallelSide() // 判斷是否有一組對邊平行
        {
            double[] s = new double[4];
            SideLengths(s); // 計算四條邊的長度


            // 檢查是否有一組對邊平行
            return Math.Abs(InteriorAngle(0) + InteriorAngle(1) - 180) < Tol && Math.Abs(InteriorAngle(2) + InteriorAngle(3) - 180) < Tol;
        }

        private bool hasEqualAdjacentSide() //是否具有相等的相鄰邊
        {
            double[] s = new double[4];
            SideLengths(s);

            return (Math.Abs(s[0] - s[1]) < Tol && Math.Abs(s[2] - s[3]) < Tol) ||
                   (Math.Abs(s[1] - s[2]) < Tol && Math.Abs(s[3] - s[0]) < Tol);
        }



        public double Area() // 計算面積 (分兩個三角形來計算)
        {
            double[] s = new double[4];
            SideLengths(s);

            double diagonal = ptArr2[0].Distance(ptArr2[2]); // 對角線

            // 用海龍公式計算兩個三角形的面積
            double p1 = (s[0] + s[1] + diagonal) / 2;
            double area1 = Math.Sqrt(p1 * (p1 - s[0]) * (p1 - s[1]) * (p1 - diagonal));

            double p2 = (s[2] + s[3] + diagonal) / 2;
            double area2 = Math.Sqrt(p2 * (p2 - s[2]) * (p2 - s[3]) * (p2 - diagonal));

            return area1 + area2;
        }
        public bool isSquare()//判斷是否為正方形
        {
            if (isEqualAngle() && isEqualSide())
                return true;
            else
                return false;
        }
        public bool isRectangle()//判斷是否為長方形
        {
            if (isEqualAngle() && !isEqualSide())
                return true;
            else
                return false;
        }
        public bool isDiamond() //判斷是否為菱形
        {
            if (!isEqualAngle() && isEqualOppsiteAngle() && isEqualSide())
                return true;
            else
                return false;
        }
        public bool isParallelogram()//判斷是否為平行四邊形
        {
            if (!isEqualAngle() && isEqualOppsiteAngle() && !isEqualSide())
                return true;
            else
                return false;
        }
        public bool isTrapezoid()//判斷是否為梯形
        {
            if (!isEqualAngle() && !isEqualOppsiteAngle() && hasParallelSide())
                return true;
            else
                return false;
        }
        public bool isKite()//判斷是否為箏形
        {
            if (!isEqualAngle() && !isEqualOppsiteAngle() && !hasParallelSide() && hasEqualAdjacentSide())
                return true;
            else
                return false;
        }


        public bool isValid()
        {
            double[] s = new double[4];
            SideLengths(s);

            // 檢查四條邊的長度是否為正數
            for (int i = 0; i < 4; i++)
            {
                if (s[i] <= 0)
                    return false;  // 邊長為零或負數，四邊形不合法
            }

            // 檢查任意三邊之和是否大於第四邊
            for (int i = 0; i < 4; i++)
            {
                if (s[i] >= s[(i + 1) % 4] + s[(i + 2) % 4] + s[(i + 3) % 4])
                    return false;  // 若任意一邊大於或等於其餘三邊之和，則不合法
            }

            // 檢查是否存在三點共線
            for (int i = 0; i < 4; i++)
            {
                double cross = Point.CrossProduct(ptArr2[i], ptArr2[(i + 1) % 4], ptArr2[(i + 2) % 4]);
                if (Math.Abs(cross) < Tol) // 若外積接近 0，則三點共線
                    return false; // 若存在任意三點共線，則不合法
            }
            
                
            double totalAngle = 0;
            for (int i = 0; i < 4; i++)
            {
                // 計算當前角度
                double angle = InteriorAngle(i);
                totalAngle += angle;
            }
            if (Math.Abs(totalAngle - 360) > Tol)
                return false; // 內角總和不等於 360 度


            return true;  // 四邊形合法
        }


        public double Perimeter()
        {
            double[] s = new double[4];
            SideLengths(s);
            double sum = 0;

            foreach (var element in s)
                sum += element;

            return (sum);
        }
        public int ShapeType()
        {
            if (isSquare())
                return 1;
            else if (isRectangle())
                return 2;
            else if (isDiamond())
                return 3;
            else if (isParallelogram())
                return 4;
            else if (isTrapezoid())
                return 5;
            else if (isKite())
                return 6;
            else
                return 7;
        }
    }


}
