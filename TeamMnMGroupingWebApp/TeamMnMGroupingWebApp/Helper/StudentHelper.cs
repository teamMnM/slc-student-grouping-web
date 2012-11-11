﻿using Newtonsoft.Json;
using SlcClient.Entities;
using SlcClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TeamMnMGroupingWebApp.Models;

namespace TeamMnMGroupingWebApp.Helper
{
    public class StudentHelper
    {
        public static async Task<StudentDisplayObject> GetStudentDisplayObject(StudentService cs, Student student)
        {
            var sections = GetSectionsByStudentId(cs, student.id);
            var assessments = GetStudentAssessmentsByStudentId(cs, student.id);

            await Task.WhenAll(sections, assessments);

            var result = MapStudentToStudentDisplayObject(student, sections.Result, assessments.Result);

            return result;
        }

        private static async Task<IEnumerable<Section>> GetSectionsByStudentId(StudentService cs, string studentId)
        {
            var result = await cs.GetStudentSectionsByStudentId(studentId);
            return result;
        }

        private static async Task<IEnumerable<Assessment>> GetStudentAssessmentsByStudentId(StudentService cs, string studentId)
        {
            var result = await cs.GetStudentAssessmentsByStudentId(studentId);
            return result;            
        }

        public static StudentDisplayObject MapStudentToStudentDisplayObject(Student student, IEnumerable<Section> sections, IEnumerable<Assessment> assessments)
        {
            
            var newStudent = new StudentDisplayObject();
            newStudent.id = student.id;
            newStudent.name = string.Format("{0} {1}", student.name.firstName, student.name.lastSurName);
            newStudent.sections = from s in sections select s.id;
            newStudent.disabilities = from d in student.disabilities select FilterHelper.GetEnumDescription(d.disability).title;
            newStudent.learningStyles = student.learningStyles;
            newStudent.assessments = assessments;

            return newStudent;
        }

        private static IEnumerable<SectionDisplayObject> MapSectionToSectionDisplayObject(IEnumerable<Section> sections)
        {
            var newSections = new List<SectionDisplayObject>();
            foreach (var s in sections)
            {
                var newSection = new SectionDisplayObject();
                newSection.courseTitle = s.course.courseTitle;
                newSection.courseDescription = s.course.courseDescription;
                newSection.courseLevel = s.course.courseLevel;
                newSection.subjectArea = s.course.subjectArea;
                newSections.Add(newSection);
            }
            return newSections;
        }
    }
}