namespace OOP_Project_Concept2
{
    internal class Husband : Heir
    {
        public Husband(string Name) 
        { 
            this.Name = Name;
            Relationship = "زوج";
        }

        public override double GetShareRatio(bool hasBranch, bool isDeceasedMale)
        {
            if (hasBranch)
            {
                return 1.0 / 4.0; //  في حالة وجود فرع وارث يرث الزوج الربع
            }
            else
            {
                return 1.0 / 2.0;// و يرث النصف في حالة عدم وجود فرع وارث
            }
        }
    }
}
