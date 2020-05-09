namespace func_rocket
{
    public class Map
    {
        public int Height { get; private set; }
        public int Weight { get; private set; }

        public Map(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }
        
    }
}