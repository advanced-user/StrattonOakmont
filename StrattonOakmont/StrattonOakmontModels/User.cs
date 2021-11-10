using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class User
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IMG { get; set; }
        public string Email { get; set; }
        public int Pasword { get; set; }
        public decimal Account { get; set; }
        public List<Security> Securities { get; set; }
        //

    }
}
