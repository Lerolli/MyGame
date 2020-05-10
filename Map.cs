using System;

namespace Asteroids
{
    public class Map
    {
        public int Height { get; private set; }
        public int Weight { get; private set; }

        public Map(int height, int weight)
        {
            Height = height;
            Weight = weight;
            if (height <=0 || weight < 0) 
                throw new Exception("Поле не может быть меньше или равное 0");

        }
        
    }
}