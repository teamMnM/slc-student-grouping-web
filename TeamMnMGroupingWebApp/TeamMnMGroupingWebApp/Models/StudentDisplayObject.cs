using SlcClient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamMnMGroupingWebApp.Models
{
    public class StudentDisplayObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<string> disabilities { get; set; }
        public double cumulativeGradePointAverage { get; set; }
        
//        -id:string
//-name:string
//-gradeLevel:string
//-disabilities:List<string>
//-sections
//-courseTitle:string
//-courseDescription:string
//-subjectArea:string
//-courseLevel:string
//-cumulativeGradePointAverage
        /// <summary>
        /// student info
        /// </summary>
        public Student student { get; set; }

        /// <summary>
        /// sections the student in context is in
        /// </summary>
        public IEnumerable<Section> sections { get; set; }

        /// <summary>
        /// assessments that the student in context has taken
        /// </summary>
        public IEnumerable<Assessment> assessments { get; set; }
    }
}