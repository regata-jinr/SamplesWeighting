/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamplesWeighting
{
    public class Irradiation
    {
        public string Country_Code      { get; set; }
        public string Client_Id         { get; set; }
        public string Year              { get; set; }
        public string Sample_Set_Id     { get; set; }
        public string Sample_Set_Index  { get; set; }
        public string Sample_ID         { get; set; }
        public float?  InitWeight        { get; set; }
        public float?  ReWeight          { get; set; }
    }

    [Table("table_LLI_Irradiation_Log")]
    public class Register
    {
        public DateTime Date_Start  { get; set; }
        public int      loadNumber  { get; set; }
    }
}

