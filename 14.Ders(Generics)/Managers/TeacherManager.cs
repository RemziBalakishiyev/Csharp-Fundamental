using _14.Ders_Generics_.Classes;
using _14.Ders_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Managers
{
    internal class TeacherManager : GenericManager<Teacher>
    {
        public TeacherManager() :
            base(new List<Teacher>
            {
                new Teacher{Id = 1, FirstName= "Tyrion", LastName = "Lannister", Subject = "Backend"},
                new Teacher{Id = 2, FirstName= "Erling", LastName = "Halland", Subject = "Backend"},
            })
        {

        }

    }
}
