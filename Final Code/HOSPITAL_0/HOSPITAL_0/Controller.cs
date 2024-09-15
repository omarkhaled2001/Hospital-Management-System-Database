using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace HOSPITAL_0
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int insertdocshift(int doc_id, string day, string start_End_shift, string work_kind, int maxrole)
        {

            string StoredProcedureName = StoredProcedures.insertdocshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@day", day);
            Parameters.Add("@start_End_shift", start_End_shift);
            Parameters.Add("@work_kind", work_kind);
            Parameters.Add("@maxrole", maxrole);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertdocattendence(int doc_id, int attendence, string date)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.insertdocattendence;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@attendence", attendence);
            Parameters.Add("@date", datte);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int reserveovertime(int doc_id, double extra_hours, string date)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.reserveovertime;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@extra_hours", extra_hours);
            Parameters.Add("@date", datte);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int docsetcomplains(int d_id, int n_id, string date, string doc_complains, int value)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.docsetcomplains;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@d_id", d_id);
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@date", datte);
            Parameters.Add("@doc_complains", doc_complains);
            Parameters.Add("@cd", value);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertnurseshift(int n_id, string day, string start_End_shift, string work_kind)
        {

            string StoredProcedureName = StoredProcedures.insertnurseshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@day", day);
            Parameters.Add("@start_End_shift", start_End_shift);
            Parameters.Add("@work_kind", work_kind);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertnurseattendence(int n_id, int attendence, string date)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.insertnurseattendence;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@attendence", attendence);
            Parameters.Add("@date", datte);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int reserveovertimenurse(int n_id, double extra_hours, string date)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.reserveovertimenurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@extra_hours", extra_hours);
            Parameters.Add("@date", datte);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int nursesetcomplains(int n_id, int d_id, string date, string nurse_complains, int value)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.nursesetcomplains;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
    
            Parameters.Add("@date", datte);
            Parameters.Add("@cn", value);
            Parameters.Add("@nurse_complains", nurse_complains);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertpatient(int p_id, string f_name, string m_name, string l_name, string address, string gender, int age)
        {

            string StoredProcedureName = StoredProcedures.insertpatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@f_name", f_name);
            Parameters.Add("@m_name", m_name);
            Parameters.Add("@l_name", l_name);
            Parameters.Add("@address", address);
            Parameters.Add("@gender", gender);
            Parameters.Add("@age", age);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int reservenormaldoc(int p_id, int doc_id, string date, int role)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.reservenormaldoc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@date", datte);
            Parameters.Add("@role", role);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int reserveemroom(int p_id, int em_room_id, string blood, int em_d_id, int em_n_id)
        {

            string StoredProcedureName = StoredProcedures.reserveemroom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@em_room_id", em_room_id);
            Parameters.Add("@blood", blood);
            Parameters.Add("@em_d_id", em_d_id);
            Parameters.Add("@em_n_id", em_n_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int patientdotest(int p_id, int t_id, string d)
        {
            DateTime datte = Convert.ToDateTime(d);

            string StoredProcedureName = StoredProcedures.patientdotest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@t_id", t_id);
            Parameters.Add("@d", datte);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertappointment(int p_id, int d_id, string date, int role)
        {
            DateTime datte = Convert.ToDateTime(date);


            string StoredProcedureName = StoredProcedures.insertappointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@d_id", d_id);
            Parameters.Add("@date", datte);
            Parameters.Add("@role", role);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }



        public int reservecheckuproom(int p_id, int room_id)
        {

            string StoredProcedureName = StoredProcedures.reservecheckuproom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@room_id", room_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int patientakevaccine(int p_id, int v_id)
        {
            string StoredProcedureName = StoredProcedures.patientakevaccine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@v_id", v_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int insertpatientfeedback(int p_id, int doc_id, string date, string p_feedback, int value)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.insertpatientfeedback;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@date", datte);
            Parameters.Add("@p_feedback", p_feedback);
            Parameters.Add("@fv", value);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int insertray(int ray_id, int patient_id, string date)
        {
            DateTime datte = Convert.ToDateTime(date);

            string StoredProcedureName = StoredProcedures.insertray;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ray_id", ray_id);
            Parameters.Add("@patient_id", patient_id);
            Parameters.Add("@datte", datte);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertpatientreceipt(int id, int pid, string date, float rece, string kind, int paid)
        {
            DateTime datte = Convert.ToDateTime(date);
            string StoredProcedureName = StoredProcedures.insertpatientreceipt;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pid", pid);
            Parameters.Add("@date", datte);
            Parameters.Add("@rece", rece);
            Parameters.Add("@kind", kind);
            Parameters.Add("@paid", paid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int hiredoctor(int id, string first_name, string middle_name, string last_name, string address, int department_id)
        {

            string StoredProcedureName = StoredProcedures.hiredoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@department_id", department_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int hirenurse(int id, string first_name, string middle_name, string last_name, string address, int department_id, int doctor_id)
        {

            string StoredProcedureName = StoredProcedures.hirenurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@department_id", department_id);
            Parameters.Add("@doctor_id", doctor_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int hirestuff(int id, string first_name, string middle_name, string last_name, string address, string specialization, int department_id)
        {

            string StoredProcedureName = StoredProcedures.hirestuff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@specialization", specialization);
            Parameters.Add("@department_id", department_id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int setreportfordoctor1(int doctor_id, DateTime date, string evaluation, int manager_id)
        {
            
            string StoredProcedureName = StoredProcedures.setreportfordoctor1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doctor_id", doctor_id);
            Parameters.Add("@datte", date);
            Parameters.Add("@evaluation", evaluation);
            Parameters.Add("@manager_id", manager_id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int setreportfornurse(int nurse_id, DateTime date, string evaluation, int manager_id)
        {
            
            string StoredProcedureName = StoredProcedures.setreportfornurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@nurse_id", nurse_id);
            Parameters.Add("@datte", date);
            Parameters.Add("@evaluation", evaluation);
            Parameters.Add("@manager_id", manager_id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletedoctor(int inputdoctor_id)
        {

            string StoredProcedureName = StoredProcedures.deletedoctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputdoctor_id", inputdoctor_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletenurse(int inputnurse_id)
        {

            string StoredProcedureName = StoredProcedures.deletenurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputnurse_id", inputnurse_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletestuff(int inputstuff_id)
        {

            string StoredProcedureName = StoredProcedures.deletestuff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputstuff_id", inputstuff_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int set_raise_doctor(int inputdoctor_id, int x)
        {

            string StoredProcedureName = StoredProcedures.set_raise_doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputdoctor_id", inputdoctor_id);
            Parameters.Add("@x", x);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int set_raise_nurse(int inputnurse_id, int x)
        {

            string StoredProcedureName = StoredProcedures.set_raise_nurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputnurse_id", inputnurse_id);
            Parameters.Add("@x", x);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int numberpatientstoday(int id, string date)
        {
            DateTime datte = Convert.ToDateTime(date);
            string StoredProcedureName = StoredProcedures.numberpatientstoday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doctor_id", id);
            Parameters.Add("@datte", datte);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public float getdocsalary(int id)
        {
            string StoredProcedureName = StoredProcedures.getdocsalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return (float)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int getmonthdocpermissions(int id, int month, int year)
        {
            string StoredProcedureName = StoredProcedures.getmonthdocpermissions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            Parameters.Add("@doctor_id", id);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public float getdocextrahours(int id, int month, int year)
        {
            string StoredProcedureName = StoredProcedures.getdocextrahours;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            Parameters.Add("@doc_id", id);
            return (float)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int getdocdaysperweek(int id)
        {
            string StoredProcedureName = StoredProcedures.getdocdaysperweek;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int docattendenceinthismonth(int id, int year, int month)
        {
            string StoredProcedureName = StoredProcedures.docattendenceinthismonth;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable getalldocdepid(int id)
        {
            string StoredProcedureName = StoredProcedures.getalldocdepid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dep_id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getalldepid()
        {

            string StoredProcedureName = StoredProcedures.getalldepid;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getallnursedepid(int id)
        {
            string StoredProcedureName = StoredProcedures.getalldocdepid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dep_id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        

        public int getnursesalary(int id)
        {
            string StoredProcedureName = StoredProcedures.getnursesalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int getmonthnursepermissions(int id, int year, int month)
        {
            string StoredProcedureName = StoredProcedures.getmonthnursepermissions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        public float getnurseextrahours(int id, int year, int month)
        {
            string StoredProcedureName = StoredProcedures.getnurseextrahours;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            return (float)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        public int nurseattendenceinthismonth(int id, int year, int month)
        {
            string StoredProcedureName = StoredProcedures.nurseattendenceinthismonth;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int getnursedaysperweek(int id)
        {
            string StoredProcedureName = StoredProcedures.getnursedaysperweek;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }



        public DataTable namealldepartment()
        {
            string StoredProcedureName = StoredProcedures.namealldepartment;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

    public float getclinicvseta(int id)
        {
            string StoredProcedureName = StoredProcedures.getclinicvseta;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", id);
            return (float)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }



        public DataTable getemdoc(string day)
        {
            string StoredProcedureName = StoredProcedures.getemdoc;
        Dictionary<string, object> Parameters = new Dictionary<string, object>();
        Parameters.Add("@today", day);
            return  dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getemroom()
        {
            string StoredProcedureName = StoredProcedures.getemroom;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

    public float getemergencyroomcost(int id)
        {
            string StoredProcedureName = StoredProcedures.getemergencyroomcost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return (float)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable getavliablerooms(string c)
        {
            string StoredProcedureName = StoredProcedures.getavliablerooms;
        Dictionary<string, object> Parameters = new Dictionary<string, object>();
        Parameters.Add("@c", c);
            return  dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable allvaccinenames()
        {
            string StoredProcedureName = StoredProcedures.allvaccinenames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getallvaccineids()
        {
            string StoredProcedureName = StoredProcedures.getallvaccineids;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


        public int getmarolefordoc(int id, string day)
        {
            string StoredProcedureName = StoredProcedures.getmarolefordoc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@d_id", id);
            Parameters.Add("@day", day);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int getmaxinthisday(int id, string day)
        {
            string StoredProcedureName = StoredProcedures.getmaxinthisday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@d_id", id);
            Parameters.Add("@day", day);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int updatedocshiftday(int doc_id, string day, string newday)
        {

            string StoredProcedureName = StoredProcedures.updatedocshiftday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@day", day);
            Parameters.Add("@newday", newday);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatedocshiftshift(int doc_id, string day, string start_end_shift)
        {

            string StoredProcedureName = StoredProcedures.updatedocshiftshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doc_id", doc_id);
            Parameters.Add("@day", day);
            Parameters.Add("@start_end_shift", start_end_shift);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletedocshift(int doc_id, string day)
        {

            string StoredProcedureName = StoredProcedures.deletedocshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", doc_id);
            Parameters.Add("@day", day);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int docwritepatientreport(string report, int d_id, int p_id, string today)
        {
            DateTime datte = Convert.ToDateTime(today);

            string StoredProcedureName = StoredProcedures.docwritepatientreport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@report", report);
            Parameters.Add("@d_id", d_id);
            Parameters.Add("@p_id", p_id);
            Parameters.Add("@today", datte);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int updatenurseshiftday(int n_id, string day, string newday)
        {

            string StoredProcedureName = StoredProcedures.updatenurseshiftday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@day", day);
            Parameters.Add("@newday", newday);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatenurseshiftshift(int n_id, string day, string start_end_shift)
        {

            string StoredProcedureName = StoredProcedures.updatenurseshiftshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@day", day);
            Parameters.Add("@start_end_shift", start_end_shift);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletenurseshift(int n_id, string day)
        {

            string StoredProcedureName = StoredProcedures.deletenurseshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@n_id", n_id);
            Parameters.Add("@day", day);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateemroom(int em_room)
        {

            string StoredProcedureName = StoredProcedures.updateemroom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@em_room", em_room);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int incrementbeds(int id)
        {

            string StoredProcedureName = StoredProcedures.incrementbeds;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updateroom(int room_id)
        {

            string StoredProcedureName = StoredProcedures.updateroom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@room_id", room_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int patientreceiptdone(int p_id)
        {

            string StoredProcedureName = StoredProcedures.patientreceiptdone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable infodocshift(string dep_name)
        {
            String StoredProcedureName = StoredProcedures.infodocshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dep_name", dep_name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable vaccinedetails(string v_name)
        {
            String StoredProcedureName = StoredProcedures.vaccinedetails;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@v_name", v_name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable showroomopriceandclasses()
        {
            String StoredProcedureName = StoredProcedures.showroomopriceandclasses;

            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getpatientreport(int p_id, string date)
        {
            String StoredProcedureName = StoredProcedures.getpatientreport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            DateTime datte = Convert.ToDateTime(date);
            Parameters.Add("@d date", datte);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable receive_complaints_from_doctor(int year, int month,int day)
        {
            String StoredProcedureName = StoredProcedures.receive_complaints_from_doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@year", year);
            
            Parameters.Add("@month", month);
            Parameters.Add("@day", day);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable receive_complaints_from_nurse(int year, int month, int day)
        {
            String StoredProcedureName = StoredProcedures.receive_complaints_from_nurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@year", year);

            Parameters.Add("@month", month);
            Parameters.Add("@day", day);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable receive_complaints_from_patient(int year, int month, int day)
        {
            String StoredProcedureName = StoredProcedures.receive_complaints_from_patient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@year", year);

            Parameters.Add("@month", month);
            Parameters.Add("@day", day);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable patient_recpeit(int p_id)
        {
            String StoredProcedureName = StoredProcedures.patient_recpeit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@p_id", p_id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getdocevaluation(int d_id)
        {
            String StoredProcedureName = StoredProcedures.getdocevaluation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doctor_id", d_id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable getnurseevaluation(int n_id)
        {
            String StoredProcedureName = StoredProcedures.getnurseevaluation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@nurse_id", n_id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getallpatientreports(int d_id, int p_id)
        {
            String StoredProcedureName = StoredProcedures.getallpatientreports;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doctor_id", d_id);
            Parameters.Add("@patient_id", p_id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable patientinfo2(int id,string date)
        {

            DateTime datte = Convert.ToDateTime(date);
            String StoredProcedureName = StoredProcedures.patientinfo2;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@doctor_id", id);
            Parameters.Add("@datte", datte);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable rate_doctor(int inputdoctor_id, int year, int month, int day)
        {


            string StoredProcedureName = StoredProcedures.rate_doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputdoctor_id", inputdoctor_id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            Parameters.Add("@day", day);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable rate_nurse(int inputnurse_id, int year, int month, int day)
        {


            string StoredProcedureName = StoredProcedures.rate_nurse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@inputnurse_id", inputnurse_id);
            Parameters.Add("@year", year);
            Parameters.Add("@month", month);
            Parameters.Add("@day", day);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int hiredoctor1(int id, string first_name, string middle_name, string last_name, string address, float salary, int department_id)
        {

            string StoredProcedureName = StoredProcedures.hiredoctor1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@salary", salary);
            Parameters.Add("@department_id", department_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int hirenurse1(int id, string first_name, string middle_name, string last_name, string address, float salary, int department_id)
        {

            string StoredProcedureName = StoredProcedures.hirenurse1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@salary", salary);
            Parameters.Add("@department_id", department_id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int hirestuff1(int id, string first_name, string middle_name, string last_name, string address, float salary, string specialization, int department_id)
        {

            string StoredProcedureName = StoredProcedures.hirestuff1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@first_name", first_name);
            Parameters.Add("@middle_name", middle_name);
            Parameters.Add("@last_name", last_name);
            Parameters.Add("@address", address);
            Parameters.Add("@salary", salary);
            Parameters.Add("@specialization", specialization);
            Parameters.Add("@department_id", department_id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable showdoctorshift(int id)
        {
            String StoredProcedureName = StoredProcedures.showdoctorshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable shownurseshift(int id)
        {
            String StoredProcedureName = StoredProcedures.shownurseshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable showstuffshift(int id)
        {
            String StoredProcedureName = StoredProcedures.showstuffshift;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable showdoctor()
        {
            string StoredProcedureName = StoredProcedures.showdoctor;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable shownurse()
        {
            string StoredProcedureName = StoredProcedures.shownurse;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable showstuff()
        {
            string StoredProcedureName = StoredProcedures.showstuff;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
    }
}
