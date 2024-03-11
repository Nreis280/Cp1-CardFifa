namespace Cp1_CardFifa.Models
{
    public class Cards
    {
        public int Id { get; set; }
        public PositionClass Class { get; set; } = PositionClass.ST;
        public string Name { get; set; } = "Mbappé";
        public int Pac { get; set; } = 98;
        public int Sho { get; set; } = 91;
        public int Pas { get; set; } = 82;
        public int Dri { get; set; } = 93;
        public int Def { get; set; } = 38;
        public int Phy { get; set; } = 70;


    }
}

