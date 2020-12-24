namespace Online_Clinic.Common.SessionOperations
{
    public class SessionContext
    {
        public string LoginID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
