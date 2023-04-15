using System.ComponentModel.DataAnnotations;

namespace CSVParserAPI
{
    public class Users
    {
        [EmailAddress]
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }

        [Phone]
        public string OfficePhone { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        public string Country { get; set; }



    }
}
