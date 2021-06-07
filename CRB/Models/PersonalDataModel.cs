using System.ComponentModel.DataAnnotations;

namespace CRB.Models
{
    public class PersonalDataModel
    {
		[Display(Name = "CustomerCode")]
        public string CustomerCode { get; set; }

		[Display(Name = "IndividualClassification")]
		public string IndividualClassification { get; set; }

		[Display(Name = "NegativeStatusOfClient")]
		public string NegativeStatusOfClient { get; set; }

		[Display(Name = "FirstName")]
		public string FirstName { get; set; }

		[Display(Name = "MiddleName")]
		public string MiddleName { get; set; }

		[Display(Name = "LastName")]
		public string LastName { get; set; }

		[Display(Name = "MaritalStatus")]
		public string MaritalStatus { get; set; }

		[Display(Name = "Gender")]
		public string Gender { get; set; }

		[Display(Name = "Nationality")]
		public string Nationality { get; set; }

		[Display(Name = "DateOfBirth")]
		public string DateOfBirth { get; set; }

		[Display(Name = "Identification")]
		public string Identification { get; set; }

		[Display(Name = "IdentificationType")]
		public string IdentificationType { get; set; }

		[Display(Name = "IssuedBy")]
		public string IssuedBy { get; set; }

		[Display(Name = "AddressCityTownVillage")]
		public string AddressCityTownVillage { get; set; }

		[Display(Name = "AddressDistrict")]
		public string AddressDistrict { get; set; }

		[Display(Name = "AddressRegion")]
		public string AddressRegion { get; set; }

		[Display(Name = "AddressCountry")]
		public string AddressCountry { get; set; }

		[Display(Name = "CellularPhone")]
		public string CellularPhone { get; set; }

		[Display(Name = "IsClientActive")]
		public bool IsClientActive { get; set; }

	}
}