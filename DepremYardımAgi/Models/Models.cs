namespace DepremYardımAgi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<HelpRequest> HelpRequests { get; set; }
        public virtual ICollection<HelpResponse> HelpResponses { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string District { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }

    public class Apartment
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<User> Residents { get; set; }
    }

    public class HelpRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<RequestMatch> RequestMatches { get; set; }
        public DateTime RequestDate { get; set; }
    }

    public class Volunteer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<RequestMatch> RequestMatches { get; set; }
    }

    public class RequestMatch
    {
        public int Id { get; set; }
        public int VolunteerId { get; set; }
        public int HelpRequestId { get; set; }
        public virtual Volunteer Volunteer { get; set; }
        public virtual HelpRequest HelpRequest { get; set; }
    }

    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }

    public class Inventory
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public virtual Resource Resource { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class HelpResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HelpRequestId { get; set; }
        public virtual User User { get; set; }
        public virtual HelpRequest HelpRequest { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime ResponseDate { get; set; }
    }
}
