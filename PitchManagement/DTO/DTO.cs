using System;

namespace DTO
{
    public class DTO_User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsUser { get; set; }
        public bool CorrectPassword { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class DTO_Pitch
    {
        public string PitchName { get; set; }
        public string Category { get; set; }
        public int Time { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Booker { get; set; }
        public bool Status { get; set; }
    }
}
