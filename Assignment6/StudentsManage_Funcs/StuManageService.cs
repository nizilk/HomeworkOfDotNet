using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentsManage_Funcs
{
    public class StuManageService
    {
        public List<school> AllSchools { 
            get {
                using (StuModel db = new StuModel()) {
                    return db.school.Include(s => s.classroom.Select(c => c.student)).ToList();
                }
            } 
        }
        public List<classroom> AllClasses {
            get {
                using (StuModel db = new StuModel()) {
                    return db.classroom.Include(c => c.student).ToList();
                }
            }
        }
        public List<student> AllStudents {
            get {
                using (StuModel db = new StuModel()) {
                    return db.student.ToList();
                }
            }
        }
        public int SchoolNum {
            get {
                using (StuModel db = new StuModel()) {
                    return db.school.Count();
                }
            }
        }
        public int ClassNum {
            get {
                using (StuModel db = new StuModel()) {
                    return db.classroom.Count();
                }
            }
        }
        public int StudentNum {
            get {
                using (StuModel db = new StuModel()) {
                    return db.student.Count();
                }
            }
        }

        public string PrintStudent(student stu) => stu.student_id + " - " + 
                                                   stu.student_name + " - " + 
                                                   stu.gender + " - " + 
                                                   stu.grade.ToString();

        public string PrintSchool(school sch) => sch.school_name + " - " + sch.address;

        public StuManageService() { }
        
        public bool AddStudent(student student)
        {
            if (student == null)    return false;
            using (StuModel db = new StuModel())
            {
                if (db.student.Any(st => st.student_id == student.student_id)) return false;
                db.student.Add(student);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddClass(classroom cs)
        {
            if (cs == null) return false;
            using (StuModel db = new StuModel())
            {
                if (db.classroom.Any(c => c.id == cs.id)) return false;
                db.classroom.Add(cs);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddSchool(school sch)
        {
            if (sch == null) return false;
            using (StuModel db = new StuModel())
            {
                if (db.school.Any(s => s.id == sch.id)) return false;
                db.school.Add(sch);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteStudent(int id)
        {
            using (StuModel db = new StuModel())
            {
                var st = db.student.FirstOrDefault(s => s.id == id);
                if (st == null) return false;
                db.student.Remove(st);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteClass(int id)
        {
            using (StuModel db = new StuModel())
            {
                var cr = db.classroom.FirstOrDefault(c => c.id == id);
                if (cr == null) return false;
                db.classroom.Remove(cr);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteSchool(int id)
        {
            using (StuModel db = new StuModel())
            {
                var sc = db.school.FirstOrDefault(s => s.id == id);
                if (sc == null) return false;
                db.school.Remove(sc);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateStudent(int id, student newst)
        {
            using (StuModel db = new StuModel())
            {
                var st = db.student.FirstOrDefault(s => s.id == id);
                if (st == null) return false;
                db.student.Remove(st);
                db.student.Add(newst);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateClass(int id, classroom newcr)
        {
            using (StuModel db = new StuModel())
            {
                var cr = db.classroom.FirstOrDefault(c => c.id == id);
                if (cr == null) return false;
                db.classroom.Remove(cr);
                db.classroom.Add(newcr);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateSchool(int id, school newsc)
        {
            using (StuModel db = new StuModel())
            {
                var sc = db.school.FirstOrDefault(s => s.id == id);
                if (sc == null) return false;
                db.school.Remove(sc);
                db.school.Add(newsc);
                db.SaveChanges();
                return true;
            }
        }

        public student QueryStudent(int id)
        {
            using (StuModel db = new StuModel())
            {
                var q = db.student.SingleOrDefault(s => s.id == id);
                return q;
            }
        }

        public student QueryStudent_id(string id)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.student.SingleOrDefault(s => s.student_id == id);
                return query;
            }
        }

        public List<student> QueryStudent_name(string name)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.student.Where(s => s.student_name == name);
                return query.ToList();
            }
        }

        public List<student> QueryStudent_gender(string gender)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.student.Where(s => s.gender == gender);
                return query.ToList();
            }
        }

        public List<student> QueryStudent_grade(int grade)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.student.Where(s => s.grade == grade);
                return query.ToList();
            }
        }

        public classroom QueryClass_id(int id)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.classroom.Include(c => c.student).SingleOrDefault(s => s.id == id);
                return query;
            }
        }

        public List<classroom> QueryClass_name(string name)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.classroom.Include(c => c.student).Where(s => s.class_name == name);
                return query.ToList();
            }
        }

        public school QuerySchool_id(int id)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.school.Include(s => s.classroom.Select(c => c.student)).SingleOrDefault(s => s.id == id);
                return query;
            }
        }

        public List<school> QuerySchool_name(string name)
        {
            using (StuModel db = new StuModel())
            {
                var query = db.school.Include(s => s.classroom.Select(c => c.student)).Where(s => s.school_name == name);
                return query.ToList();
            }
        }

    }
}
