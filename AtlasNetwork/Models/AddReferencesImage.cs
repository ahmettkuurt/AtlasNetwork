namespace AtlasNetwork.Models
{
    public class AddReferencesImage
    {
        public int ReferencesID { get; set; }
        public IFormFile ReferencesImage { get; set; }
        public string ReferencesTitle { get; set; }
        public string ReferencesDescription { get; set; }
    }
}
