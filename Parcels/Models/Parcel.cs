namespace Parcels.Models
{
    public class Parcel
    {        
        public int Length {get; set;}
        public int Height {get; set;}
        public int Width {get;set;}
        public int Weight {get;set;}
        public Parcel(int length, int height, int width, int weight)
        {
            Length = length;
            Height = height;
            Width = width;
            Weight = weight;
        }
        public int Volume()
        {
            return Length * Height * Width;
        }
        public double CostToShip()
        {
            return this.Volume()*Weight*0.1 + 5;
        }
    }
}