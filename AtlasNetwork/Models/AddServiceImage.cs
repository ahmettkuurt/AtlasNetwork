namespace AtlasNetwork.Models
{
    public class AddServiceImage
    {
        public int ServicesID { get; set; }
        public IFormFile ServicesImage { get; set; }
        public string ServicesName { get; set; }
        public string ServicesDescription { get; set; }
    }
}
