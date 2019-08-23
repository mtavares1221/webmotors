namespace TesteWebMotors.Domain.Entities
{
    public class Vehicles
    {
        public int ID { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public Version Version { get; set; }
        public string Image { get; set; }
        public int KM { get; set; }
        public decimal Price { get; set; }
        public int YearModel { get; set; }
        public int YearFab { get; set; }
        public string Color { get; set; }
    }
}
