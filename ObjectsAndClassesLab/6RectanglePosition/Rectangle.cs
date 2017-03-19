namespace _6RectanglePosition
{
    public class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        //read only property
        //public int Bottom => Top - Height;

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }
        // public int Area => Width * Height;
        public int Area
        {
            get
            { 
                return Width * Height;
            }
        }

        public int Right => Left + Width;

    }
}
