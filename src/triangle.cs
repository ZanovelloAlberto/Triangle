using System;


namespace Triangle
{

    class Triangle{
        public int[] sides;

        public Triangle(int[] sides){
            this.sides = sides;
            
        }
        public int GetPerimeters(){
            int a = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                a+=sides[i];
            }
            return a;   
        }
        public double GetArea(){
            // semiperimeters
            var p = GetPerimeters()/2;
            
            // @@@ Erone formula @@@
            return Math.Pow(p*(p-sides[0])*(p-sides[1])*(p-sides[2]),0.5);
        }
        
        public int GetMaxSide(){
            // not efficent just readable
            int i = 3;
            int res = 0;
            while(--i>0){
                res = res > sides[i] ? res : sides[i];
            }
            return res;
        }
    }

    
}