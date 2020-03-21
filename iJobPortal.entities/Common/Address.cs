namespace iJobPortal.entities.Common
{
    public class Address
    {
        public int Id { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
        public string State { get; set; }
      
    }
}