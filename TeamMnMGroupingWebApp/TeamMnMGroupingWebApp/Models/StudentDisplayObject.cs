﻿using SlcClient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamMnMGroupingWebApp.Models
{
    public class StudentDisplayObject
    {
        public string id { get; set; }

        /// <summary>
        /// first name + last name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// list of disability names
        /// </summary>
        public IEnumerable<string> disabilities { get; set; }

        /// <summary>
        /// GPA
        /// </summary>
        public double cumulativeGradePointAverage { get; set; }

        /// <summary>
        /// list of sectionId's the students belong to
        /// </summary>
        public IEnumerable<string> sections { get; set; }

        public LearningStyles learningStyles { get; set; }

        /// <summary>
        /// student info
        /// </summary>
        //public Student student { get; set; }

        /// <summary>
        /// sections the student in context is in
        /// </summary>
        //public IEnumerable<Section> sections { get; set; }

        /// <summary>
        /// assessments that the student in context has taken
        /// </summary>
        public IEnumerable<Assessment> assessments { get; set; }
    }
}