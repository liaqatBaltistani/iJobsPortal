namespace iJobPortal.entities.Common
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public int Code { get; set; }
        public Location Location { get; set; }
    }
}