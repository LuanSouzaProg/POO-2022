namespace pasta3.Atv1
{
    public class Atv01
    {
        
        public int A;
        public int B;
        public int C;

        public Atv01(int b, int c)
        {
            this.B = b;
            this.C = c;
        }

        public int Total(){
        A = (B * C)/2;

            return A;
        }
    }
}