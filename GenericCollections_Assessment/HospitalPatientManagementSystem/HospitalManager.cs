    
public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();
    
    // Add a new patient to the system
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        // TODO: Create patient and add to dictionary
        Patient patientObj = new Patient(id,name,age,condition);
        _patients.Add(id,patientObj);
    }
    
    // Add patient to appointment queue
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
        Patient pobj = null;
        foreach(KeyValuePair<int,Patient> kvp in _patients)
        {
            if(kvp.Key ==patientId)
            {
                pobj = kvp.Value;
            }
        }
        if(pobj != null)
        {
            _appointmentQueue.Enqueue(pobj);
        }
    }
    
    // Process next appointment (remove from queue)
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
        Patient p = _appointmentQueue.Dequeue();
        return p;
    }
    
    // Find patients with specific condition using LINQ
    public List<Patient> FindPatientsByCondition(string condition)
    {
        // TODO: Use LINQ to filter patients
        // List<Patient> plist = new List<Patient>();

        // foreach(KeyValuePair<int,Patient> kvp in _patients)
        // {
        //     Patient p = kvp.Value;
        //     if(p.Condition == condition)
        //     {
        //         plist.Add(p);
        //     }
        // }

        // return plist;

        //OR

        return _patients.Where(kvp => kvp.Value.Condition == condition)
        .Select(kvp => kvp.Value).ToList();

    }
}
