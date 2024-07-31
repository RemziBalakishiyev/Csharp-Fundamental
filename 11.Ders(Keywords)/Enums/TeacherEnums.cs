using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Enums
{

    internal class TeacherEnums
    {
        /// <summary>
        /// 1. Müəllim
        /// 2. Professor
        /// 3. Dosent
        /// 4. Dekan
        /// </summary>
        public enum Degree
        {
            Teacher = 1,
            Professor= 2,
            Dosent= 3,
            Dekan= 4,
            Tyutor=5
        }

        /// <summary>
        /// 1. Kisi
        /// 2. Qadin
        /// </summary>
        public enum Gender
        {
            Male = 1,
            Female = 2,
        }
    }
}
