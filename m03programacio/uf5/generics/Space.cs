using System;

namespace generics
{
    public class Space<T>
    {
        public T? MinX { get; set; }
        public T? MaxX { get; set; }
        public T? MinY { get; set; }
        public T? MaxY { get; set; }

        public Space(T? minX, T? maxX, T? minY, T? maxY)
        {
            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }

        public override string ToString()
        {
            return $"Space: ({MinX}, {MaxX}, {MinY}, {MaxY})";
        }
    }
}
