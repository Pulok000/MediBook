using MediBook.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediBook.Services
{
    public class AppointmentService : IAppointmentService
    {
        public Task<int> AddUpdate(AppointmentVM model)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> ConfirmEvent(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<AppointmentVM> DoctorsEventsById(string doctorId)
        {
            throw new System.NotImplementedException();
        }

        public AppointmentVM GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<DoctorVM> GetDoctorList()
        {
            throw new System.NotImplementedException();
        }

        public List<PatientVM> GetPatientList()
        {
            throw new System.NotImplementedException();
        }

        public List<AppointmentVM> PatientsEventsById(string patientId)
        {
            throw new System.NotImplementedException();
        }
    }
}
