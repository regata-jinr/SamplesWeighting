using System.ComponentModel.DataAnnotations.Schema;

namespace SamplesWeighting
{
    [Table("table_Sample")]
    public class Sample
    {
        public string F_Country_Code     { get; set; }
        public string F_Client_Id        { get; set; }
        public string F_Year             { get; set; }
        public string F_Sample_Set_Id    { get; set; }
        public string F_Sample_Set_Index { get; set; }
        public string A_Sample_ID        { get; set; }
        public string A_Client_Sample_ID { get; set; }
        public decimal? P_Weighting_LLI  { get; set; }
        public decimal? P_Weighting_SLI  { get; set; }
    }

    [Table("table_Sample_Set")]
    public class SamplesSet
    {
        public string Country_Code     { get; set; }
        public string Client_ID        { get; set; }
        public string Year             { get; set; }
        public string Sample_Set_ID    { get; set; }
        public string Sample_Set_Index { get; set; }
        public string Sample_ID        { get; set; }
    }
}


