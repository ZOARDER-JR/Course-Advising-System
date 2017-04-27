using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public static class Admin
    {
        #region C_taken
        public static void Add(C_taken temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                conn.C_takens.InsertOnSubmit(temp);
                conn.SubmitChanges();
            }
        }


        public static void Drop(C_taken temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                var toDelete = from su in conn.C_takens
                              where su.cid == temp.cid
                              where su.sid == temp.sid
                              select su;
                conn.C_takens.DeleteAllOnSubmit(toDelete);
                conn.SubmitChanges();
            }
        }

        public static void Withdraw(C_taken temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                var toDelete = from su in conn.C_takens
                               where su.sid == temp.sid
                               select su;
                conn.C_takens.DeleteAllOnSubmit(toDelete);
                conn.SubmitChanges();
            }
        }

        #endregion

        #region Course
        public static void AddCourse(Course temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                conn.Courses.InsertOnSubmit(temp);
                conn.SubmitChanges();
            }
        }

        public static void DeleteCourse(Course temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                var toDelete = from su in conn.Courses
                               where su.cid == temp.cid
                               select su;
                conn.Courses.DeleteAllOnSubmit(toDelete);
                conn.SubmitChanges();
            }
        }
        #endregion

        #region Instructor
        public static void AddInstructor(Instructor temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                conn.Instructors.InsertOnSubmit(temp);
                conn.SubmitChanges();
            }
        }

        public static void DeleteInstructor(Instructor temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                var toDelete = from su in conn.Instructors
                               where su.insid == temp.insid
                               select su;
                conn.Instructors.DeleteAllOnSubmit(toDelete);
                conn.SubmitChanges();
            }
        }
        #endregion

        #region Student
        public static void AddStudent(Student temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                conn.Students.InsertOnSubmit(temp);
                conn.SubmitChanges();
            }
        }

        public static void DeleteStudent(Student temp)
        {
            using (UniversityDataDataContext conn = new UniversityDataDataContext())
            {
                var toDelete = from su in conn.Students
                               where su.sid == temp.sid
                               select su;
                conn.Students.DeleteAllOnSubmit(toDelete);
                conn.SubmitChanges();
            }
        }
        #endregion
    }
}
