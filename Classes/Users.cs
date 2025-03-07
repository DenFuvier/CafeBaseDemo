using System.ComponentModel;

namespace CafeBase.Classes
{
    class Users
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Job_title { get; set; }

        public string Status { get; set; }

        [Browsable(false)]
        public string Login { get; set; }

        [Browsable(false)]
        public string Password { get; set; }
    }
}
