﻿using SlcClient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlcClient.Entities
{
    /// <summary>
    /// This entity represents an educational organization that includes staff and students who participate in classes and educational activity groups.
    /// </summary>
    public class School : EducationOrganization
    {
        /// <summary>
        /// The type of education institution as classified by its funding source, for example public or private.
        /// </summary>
        public AdministrativeFundingControlType administrativeFundingControl { get; set; }

        /// <summary>
        /// A school or agency providing free public elementary or secondary education to eligible students under a specific charter 
        /// granted by the state legislature or other appropriate authority and designated by such authority to be a charter school.
        /// </summary>
        public CharterStatusType charterStatus { get; set; }

        /// <summary>
        /// The grade levels served at the school.
        /// </summary>
        public List<GradeLevelType> gradesOffered { get; set; }

        /// <summary>
        /// A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, 
        /// preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme 
        /// (e.g., science/math, performing arts, gifted/talented, or foreign language).
        /// </summary>
        public MagnetSpecialProgramEmphasisSchoolType magnetSpecialProgramEmphasisSchool { get; set; }

        /// <summary>
        /// The one or more categories of school. For example: High School, Middle School, and/or Elementary School.
        /// </summary>
        public List<SchoolCategoryItemType> schoolCategories { get; set; }

        /// <summary>
        /// The type of education institution as classified by its primary focus.
        /// </summary>
        public SchoolType schoolType { get; set; }

        /// <summary>
        /// Denotes the Title I Part A designation for the school.
        /// </summary>
        public TitleIPartASchoolDesignationType titleIPartASchoolDesignation { get; set; }
    }
}