using Sporganize.Enumerations;

namespace Sporganize.Models
{
    public class SportFacilityBranch
    {
        public int Id { get; set; }
        public int? SportFacilityId { get; set; }
        public SportFacility? SportFacility { get; set; }
        public Branch Branch { get; set; }

    }

}
