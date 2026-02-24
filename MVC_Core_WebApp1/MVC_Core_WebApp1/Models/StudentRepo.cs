
namespace MVC_Core_WebApp1.Models
{
    public class StudentRepo : IRepo<Student>
    {
        public static List<Student> studList = null;

        public StudentRepo()
        {
            if(studList == null)
            {
                //Collection Initializer
                studList = new List<Student>()
{
    new Student(){RollNo=101, Name="Abhinay Gupta", Age=18, Address="Lucknow"},
    new Student(){RollNo=102, Name="Makhan Londe", Age=20, Address="Mumbai"},
    new Student(){RollNo=103, Name="Aarav Veer Malhotra", Age=21, Address="Delhi"},
    new Student(){RollNo=104, Name="Vihaan Rajput", Age=22, Address="Jaipur"},
    new Student(){RollNo=105, Name="Ishaan Dev Sharma", Age=23, Address="Chandigarh"},
    new Student(){RollNo=106, Name="Rohit Verma", Age=19, Address="Noida"},
    new Student(){RollNo=107, Name="Aditya Singh", Age=20, Address="Kanpur"},
    new Student(){RollNo=108, Name="Kunal Mehta", Age=21, Address="Ahmedabad"},
    new Student(){RollNo=109, Name="Rohit Verma", Age=22, Address="Pune"},          // same name
    new Student(){RollNo=110, Name="Aryan Kapoor", Age=18, Address="Delhi"},
    new Student(){RollNo=111, Name="Sahil Khan", Age=23, Address="Bhopal"},
    new Student(){RollNo=112, Name="Aarav Veer Malhotra", Age=24, Address="Indore"}, // same name
    new Student(){RollNo=113, Name="Harsh Patel", Age=19, Address="Surat"},
    new Student(){RollNo=114, Name="Manav Joshi", Age=20, Address="Dehradun"},
    new Student(){RollNo=115, Name="Yash Thakur", Age=22, Address="Shimla"},
    new Student(){RollNo=116, Name="Nikhil Sharma", Age=21, Address="Amritsar"},
    new Student(){RollNo=117, Name="Sahil Khan", Age=20, Address="Hyderabad"},     // same name
    new Student(){RollNo=118, Name="Devansh Rao", Age=23, Address="Nagpur"},
    new Student(){RollNo=119, Name="Ankit Yadav", Age=24, Address="Patna"},
    new Student(){RollNo=120, Name="Kunal Mehta", Age=22, Address="Vadodara"},     // same name
    new Student(){RollNo=121, Name="Rajat Malhotra", Age=21, Address="Gurgaon"},
    new Student(){RollNo=122, Name="Arjun Desai", Age=19, Address="Rajkot"},
    new Student(){RollNo=123, Name="Nikhil Sharma", Age=23, Address="Jalandhar"},  // same name
    new Student(){RollNo=124, Name="Tushar Saxena", Age=20, Address="Agra"},
    new Student(){RollNo=125, Name="Manav Joshi", Age=22, Address="Rishikesh"}     // same name
};
            }
        }
        public bool AddData(Student obj)
        {
            bool flag = false;
            if (obj != null)
            {
                studList.Add(obj);
                flag = true;
            }
            else
            {
                throw new Exception("Object is null");
            }

            return flag;
        }

        public bool DeleteData(int id)
        {
            bool flag = false;
            Student sObj = studList.Find(s => s.RollNo == id);

            if (sObj != null)
            {
                studList.Remove(sObj);
                flag = true;
            }
            else
            {
                throw new Exception("Student not found");
            }

            return flag;
        }

        public List<Student> ShowAllData()
        {
            return studList; 
        }

        public Student ShowDetailsByID(int id)
        {
            Student sObj = studList.Find(s => s.RollNo == id);

            //if (sObj == null)
            //    throw new Exception("Student not found");



            return sObj;

        }

        public bool UpdateData(int id, Student obj)
        {
            bool flag = false;
            Student sObj = studList.Find(s => s.RollNo == id);

            if (sObj != null)
            {
                sObj.Name = obj.Name;
                sObj.Address = obj.Address;
                sObj.Age = obj.Age;
                flag = true;
            }
            else
            {
                throw new Exception("Student not found");
            }

            return flag;
        }
    }
}
