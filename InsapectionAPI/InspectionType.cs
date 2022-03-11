using System.ComponentModel.DataAnnotations;

namespace InsapectionAPI
{
    public class InspectionType
    {
        public int Id { get; set; }
        [StringLength(20)]
        public int InspectionName { get; set; } = string.Empty;
    }
}
