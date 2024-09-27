namespace ReserveWiseAppBackend.Domain.Entities
{
    public class Client
    {
        public long Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DocumentType DocumentTypeId {  get; set; } 
    }
}
