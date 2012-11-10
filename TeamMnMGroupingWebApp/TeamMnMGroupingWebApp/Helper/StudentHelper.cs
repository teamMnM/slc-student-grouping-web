using Newtonsoft.Json;
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

            var displayObject = new StudentDisplayObject();
            displayObject.student = student;
            displayObject.sections = sections.Result;
            displayObject.assessments = assessments.Result;

            return displayObject;
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
    }
}