using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Contracts.V1
{
    public class ApiRoutes
    {
        //Base route https://localhost:44380/api/

        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Admin
        {
            public const string Login = Base + "/admins/login";

            public const string Register = Base + "/admins/register";

            public const string NumberOfAdmin = Base + "/admins/numberofadmin";
        }

        public static class Student
        {
            public const string Login = Base + "/students/login";

            public const string Register = Base + "/students/register";

            public const string GetAll = Base + "/students";

            public const string Get = Base + "/students/{studentId}";

            public const string Update = Base + "/students/{studentId}";

            public const string Delete = Base + "/students/{studentId}";

            public const string addCourseToStudent = Base + "/students/courses/";

            public const string deleteCourseFromStudent = Base + "/students/courses/{studentId}";

            public const string getCourseFromStudent = Base + "/students/courses/{studentId}";

            public const string getAllCourseAndStudent = Base + "/students/courses";

            public const string NumberOfStudent = Base + "/admins/numberofstudent";
        }

        public static class Course
        {
            public const string GetAll = Base + "/courses";

            public const string Get  = Base + "/courses/{courseId}";

            public const string Create  = Base + "/courses";

            public const string Update = Base + "/courses/{courseId}";

            public const string Delete = Base + "/courses/{courseId}";

            public const string getSubjectFromCourse = Base + "/courses/subjects/{courseId}";

            public const string getAllSubjectAndCourse = Base + "/courses/subjects";

            public const string deleteSubjectFromCourse = Base + "/courses/subjects";

            public const string addSubjectToCourse = Base + "/courses/subjects";

            //yet to implement
            public const string getStudentFromCourse = Base + "/courses/students/{courseId}";

            public const string getAllStudentAndCourse = Base + "/courses/students";

            public const string deleteStudentFromCourse = Base + "/courses/students";

            public const string addStudentToCourse = Base + "/courses/students";

            public const string NumberOfCourse = Base + "/admins/numberofcourse";

        }

        public static class Subject
        {
            public const string GetAll = Base + "/subjects";

            public const string Get = Base + "/subjects/{subjectId}";

            public const string Create = Base + "/subjects";

            public const string Update = Base + "/subjects/{subjectId}";

            public const string Delete = Base + "/subjects/{subjectId}";

            public const string getCourseFromSubject = Base + "/subjects/courses/{subjectId}";

            public const string getAllCourseAndSubject = Base + "/subjects/courses";

            public const string deleteCourseFromSubject = Base + "/subjects/courses";

            public const string addCourseToSubject = Base + "/subjects/courses";

            public const string NumberOfSubject = Base + "/admins/numberofcourse";
        }

    }
}
