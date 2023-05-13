using System;

namespace User
{
    public class User
    {
        public class UserInformation
        {
            public string Name { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public int Gender { get; set; }
            public double IMT { get; set; }
            public string TextIMT { get; set; }
            public string TextCountOfWater { get; set; }
            public DateTime Date { get; set; }
            public int Activity { get; set; }
            public bool IsLoseWeight { get; set; }
            public bool IsFaster { get; set; }
        }
    }
}
