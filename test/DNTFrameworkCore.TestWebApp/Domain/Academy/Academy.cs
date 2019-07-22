using DNTFrameworkCore.Domain;
using DNTFrameworkCore.TestWebApp.Domain.Identity;

namespace DNTFrameworkCore.TestWebApp.Domain.Academy
{
    public class Academy : TrackableEntity, IHasRowVersion, ICreationTracking, IModificationTracking
    {
        public const int MaxTitleLength = 50;
        public const int MaxUrlLength = 50;

        public string AcademyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }


        public string NormalizedTitle { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
