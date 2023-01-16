using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MediBook.Utility
{
    public class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Patient,Text=Helper.Patient},
                    new SelectListItem{Value=Helper.Doctor,Text=Helper.Doctor}
                };
            }
        }




    }
}
