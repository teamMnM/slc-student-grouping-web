using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamMnMGroupingWebApp.Models
{
    /// <summary>
    /// custom data to store in the SLC custom entity
    /// </summary>
    public class CohortCustom
    {
        /// <summary>
        /// the list of data elements to display for students
        /// </summary>
        public IEnumerable<DataElement> dataElements { get; set; }

        /// <summary>
        /// the base64 string lesson plan to be stored in the custom entity
        /// </summary>
        public string lessonPlan { get; set; }
    }
}