using System;


namespace Triangle
{

    class Triangle
    {
        public int[] sides;

        public Triangle(int[] sides)
        {
            this.sides = sides;
        }
        public int GetPerimeters()
        {
            int a = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                a += sides[i];
            }
            return a;
        }
        public double GetArea()
        {
            // semiperimeters
            var p = GetPerimeters() / 2;

            // @@@ Erone formula @@@
            return Math.Pow(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]), 0.5);
        }

        public int GetMaxSide()
        {
            // not efficent just readable
            int i = 3;
            int res = 0;
            while (i-- > 0)
            {
                res = res > sides[i] ? res : sides[i];
            }
            return res;
        }

        public bool IsTriangle()
        {
            int i = 3;
            while (i-- > 0)
            {
                if (sides[i] > sides[(i + 1) % 3] + sides[(i + 1) % 3])
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsIsosceles()
        {
            int i = 3;
            if(IsEquilateral()){
                return false;
            }
            while (i-- > 0)
            {
                if (sides[i] == sides[(i + 1) % 3])
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEquilateral()
        {

                if (sides[0] == sides[1] && sides[1] == sides[2])
                {
                    return true;
                }
            
            return false;
        }
        
        

    }


}