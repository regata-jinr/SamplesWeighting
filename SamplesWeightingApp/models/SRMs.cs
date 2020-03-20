using System.ComponentModel.DataAnnotations.Schema;

namespace SamplesWeighting
{
    [Table("table_SRM")]
    public class SRM
    {
        public string SRM_Set_Name     { get; set; }
        public string SRM_Set_Number   { get; set; }
        public string SRM_Number       { get; set; }
        public decimal? SRM_SLI_Weight { get; set; }
        public decimal? SRM_LLI_Weight { get; set; }
    }

    [Table("table_SRM_Set")]
    public class SRMsSet
    {
        public string SRM_Set_Name   { get; set; }
        public string SRM_Set_Number { get; set; }
    }
}

