using MediBook.Models;
using MediBook.Models.ViewModels;
using MediBook.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediBook.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }


        public List<DoctorVM> GetDoctorList()
        {
            var doctors = (from user in _db.Users
                           select new DoctorVM
                           {
                               Id = Convert.ToInt32(user.Id),
                               Name = user.Name
                           }
                           ).ToList();

            return doctors;
        }

        public List<PatientVM> GetPatientList()
        {
            throw new NotImplementedException();
        }
    }
}
