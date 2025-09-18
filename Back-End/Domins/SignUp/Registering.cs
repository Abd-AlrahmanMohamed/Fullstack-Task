namespace Domin.SignUp
{
    public class Registering
    {
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        //[StringLength(50), RegularExpression("^[a-z0-9_-]{3,15}$")]
        public string Username { get; set; } = string.Empty;

        [StringLength(128), EmailAddress]
        public string Email { get; set; } = string.Empty;

        //[ StringLength(256), RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$")]
        public string Password { get; set; } = string.Empty;
        //[Required, RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")]
        public int Contact { get; set; }
    }
}
