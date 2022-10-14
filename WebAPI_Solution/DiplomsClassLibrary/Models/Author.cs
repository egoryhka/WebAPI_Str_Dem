using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiplomsClassLibrary.Models
{
    public class Author : IItem
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public string FIO => SecondName + ' ' + FirstName + ' ' + ThirdName;

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public AcademicDegree AcademicDegree { get; set; }
    }

}
