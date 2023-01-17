using MediBook.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediBook.Services
{
    public interface IAppointmentService
    {

        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();


    }
}
