namespace HW3_2
{
    public abstract class Array
    {
        public int Len { get; set; }

        public bool Init { get; set; }

        public abstract void Write();

        public abstract double Average();

        public Array(int len, string init)
        {
            Init = true;
            if (init == "no")
            {
                Init = false;
            }
            Len = len;
        }
    }
}