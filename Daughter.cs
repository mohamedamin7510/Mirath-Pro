namespace OOP_Project_Concept2
{
    internal class Daughter : Heir
    {
        public int count { get; set; }
        public bool hasBrother { get; set; }

        public Daughter(string Name, int count, bool hasBrother)
        {
            this.Name = Name;
            Relationship = "بنت";
            this.count = count;
            this.hasBrother = hasBrother;
        }

        public override double GetShareRatio(bool hasBranch, bool isDeceasedMale)
        {
            if (hasBrother) return 0;
            if (count == 1) return 0.5;
            if (count >= 2) return 2.0 / 3.0;
            return 0;
        }
    }
}
