using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiplomsClassLibrary.Models
{
	public class Diplom : IItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		[DataType(DataType.Date)] public DateTime Release { get; set; }

		/* [Required]*/
		public string HeadName { get; set; }

		public int? DirectionId { get; set; }
		public virtual Direction Direction { get; set; }

		/*[Required]*/
		public AcademicDegree AcademicDegree { get; set; }

		public int? AuthorId { get; set; }
		public virtual Author Author { get; set; }

	}
}
