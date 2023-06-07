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
            public double Age { get; set; }
            public int Gender { get; set; }
            public double IMT { get; set; }
            public string TextIMT { get; set; }
            public string TextCountOfWater { get; set; }
            public DateTime Date { get; set; }
            public int Activity { get; set; }
            public bool IsLoseWeight { get; set; }
            public bool IsFaster { get; set; }
            public int Calories
            {
                get
                {
                    double coefActivity;
                    if (Activity == 0) coefActivity = 1.2;
                    else if (Activity == 1) coefActivity = 1.375;
                    else if (Activity == 2) coefActivity = 1.4625;
                    else if (Activity == 3) coefActivity = 1.55;
                    else if (Activity == 4) coefActivity = 1.6375;
                    else if (Activity == 5) coefActivity = 1.9;
                    else coefActivity = 1.725;

                    double calories;
                    if (Gender == 0)
                        calories = Math.Round((10 * Weight + 6.25 * Height - 5 * Age + 5) * coefActivity);
                    else
                        calories = Math.Round((10 * Weight + 6.25 * Height - 5 * Age - 161) * coefActivity);

                    double boost;
                    if (IsFaster)
                        boost = 0.2;
                    else
                        boost = 0.15;

                    double normalCal;
                    if (Gender == 1 && IsLoseWeight)
                        normalCal = calories - calories * boost;
                    else if (Gender == 1 && !IsLoseWeight)
                        normalCal = calories + calories * boost;
                    else if (Gender == 0 && IsLoseWeight)
                        normalCal = calories - calories * boost;
                    else
                        normalCal = calories + calories * boost;
                    var result = Math.Round(normalCal);
                    return (int)result;                
                }
            }
            public int Proteins 
            { 
                get 
                {
                    return (int)Math.Round((Calories * 0.3) / 4);
                } 
            }
            public int Fats
            {
                get
                {
                    if (Gender == 1)
                        return (int)Math.Round((Calories * 0.1) / 9);
                    else
                        return (int)Math.Round((Calories * 0.2) / 9);
                }
            }
            public int Carbo
            {
                get
                {
                    if (Gender == 1)
                        return (int)Math.Round((Calories * 0.6) / 4);
                    else
                        return (int)Math.Round((Calories * 0.5) / 4);
                }
            }
        }
    }
}
