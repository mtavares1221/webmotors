namespace WebMotors.Infra.DTO
{
    public class ModelDTO
    {
        public ModelDTO()
        {
            this.Selected = false;
        }
        public int ID { get; set; }
        public string MakeID { get; set; }
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}
