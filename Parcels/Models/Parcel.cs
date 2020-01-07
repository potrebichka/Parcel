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
    }
}