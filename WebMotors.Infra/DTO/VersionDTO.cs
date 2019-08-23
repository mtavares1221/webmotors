namespace WebMotors.Infra.DTO
{
    public class VersionDTO
    {
        public VersionDTO()
        {
            this.Selected = false;
        }
        public int ID { get; set; }
        public int ModelID { get; set; }
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}
