namespace CRB.Models
{
    public class PersonalData
    {
        public long Id { get; set; }
        public int CustomerCode { get; set; }
		public string IndividualClassification { get; set; }
		public string NegativeStatusOfClient { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string MaritalStatus { get; set; }
		public string Gender { get; set; }
		public string Nationality { get; set; }
		public string DateOfBirth { get; set; }
		public string Identification { get; set; }
		public string IdentificationType { get; set; }
		public string IssuedBy { get; set; }
		public string AddressCityTownVillage { get; set; }
		public string AddressDistrict { get; set; }
		public string AddressRegion { get; set; }
		public string AddressCountry { get; set; }
		public string CellularPhone { get; set; }
		public bool IsClientActive { get; set; }

	}
}