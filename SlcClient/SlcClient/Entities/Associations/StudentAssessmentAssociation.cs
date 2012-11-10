﻿using SlcClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SlcClient.Entities
{
    /// <summary>
    /// This entity represents the analysis or scoring of a student's response on an assessment. 
    /// The analysis results in a value that represents a student's performance on a set of items on a test.
    /// </summary>
    public class StudentAssessmentAssociation
    {
        /// <summary>
        /// The month(s), day(s), and year on which an assessment is administered or first day of administration if over multiple days.
        /// </summary>
        public DateTime administrationDate { get; set; }

        /// <summary>
        /// Assessment Administration End Date, if administered over multiple days.
        /// </summary>
        public DateTime administrationEndDate { get; set; }

        /// <summary>
        /// The environment in which the test was administered. For example: Electronic Classroom Testing Center ....
        /// </summary>
        public AdministrationEnvironmentType administrationEnvironment { get; set; }

        /// <summary>
        /// The language in which an assessment is written and/or administered.
        /// </summary>
        public LanguageItemType administrationLanguage { get; set; }

        /// <summary>
        /// The grade level of a student when assessed.
        /// </summary>
        public GradeLevelType gradeLevelWhenAssessed { get; set; }

        /// <summary>
        /// Linguistic accommodations used with the student for the test. For example: Bilingual dictionary English dictionary Reading Aloud - 
        /// Word or Phrase Reading Aloud - Entire Test Item Oral Translation - Word or phrase Clarification - Word or phrase ...
        /// </summary>
        public List<LinguisticAccommodationItemType> linguisticAccommodations { get; set; }

        /// <summary>
        /// This descriptor defines various levels or thresholds for performance on the assessment.
        /// </summary>
        public List<PerformanceLevelDescriptor> performanceLevelDescriptors { get; set; }

        /// <summary>
        /// The primary reason student is not tested. For example: Absent Refusal by parent Refusal by student Medical waiver Illness Disruptive behavior LEP Exempt ...
        /// </summary>
        public ReasonNotTestedType reasonNotTested { get; set; }

        /// <summary>
        /// Indicator if the test was retaken. For example: Primary administration First retest Second retest ...
        /// </summary>
        public RetestIndicatorType retestIndicator { get; set; }

        /// <summary>
        /// A meaningful score or statistical expression of the performance of an individual. 
        /// The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        public List<ScoreResult> scoreResults { get; set; }

        /// <summary>
        /// The unique number for the assessment form or answer document.
        /// </summary>
        [StringLength(60)]
        public string serialNumber { get; set; }

        /// <summary>
        /// The specific type of special variation used in how an examination is presented, how it is administered, 
        /// or how the test taker is allowed to respond. This generally refers to changes that do not substantially 
        /// alter what the examination measures. The proper use of accommodations does not substantially change 
        /// academic level or performance criteria. For example: Braille Enlarged monitor view Extra time Large Print Setting Oral Administration ...
        /// </summary>
        public List<SpecialAccommodationItemType> specialAccommodations { get; set; }

        /// <summary>
        /// This entity represents the student's responses to assessment items.
        /// </summary>
        public List<StudentAssessmentItem> studentAssessmentItems { get; set; }

        /// <summary>
        /// The score and or performance level(s) earned for each objective assessment by the student.
        /// </summary>
        public List<StudentObjectiveAssessment> studentObjectiveAssessments { get; set; }

        ///// <summary>
        ///// Reference to the assessment taken by the student.
        ///// </summary>
        //public Assessment assessment { get; set; }

        ///// <summary>
        ///// Reference to the student associated with the assessment.
        ///// </summary>
        //public Student student { get; set; }

        public string studentId { get; set; }

        public string assessmentId { get; set; }
    }
}