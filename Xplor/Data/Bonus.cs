namespace Xplor.Data
{
    public class Bonus
    {
        public int BonusId { get; set; }

        public int CountryId { get; set; }
        public int JobFamilyId { get; set; }

        public int CareerBandId { get; set; }

        public int JobFunctionId { get; set; }
        public int JobTitleId { get; set; }
        public int DivisonId { get; set; }
        public int BonusPlanId { get; set; }

        public int BonusFrequency{ get; set; }

        public string BonusTarget { get; set; }

        public string BonusMetric { get; set; }

        public bool AnnualLTIEligiblitly { get; set; }


    }
}
