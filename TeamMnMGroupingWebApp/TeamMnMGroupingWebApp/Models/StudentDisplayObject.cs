using SlcClient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamMnMGroupingWebApp.Models
{
    public class StudentDisplayObject
    {
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