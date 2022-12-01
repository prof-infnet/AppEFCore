namespace AppEFCore.Models
{
	public class Student
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public IList<TeacherStudent> TeacherStudent { get; set; } //collection navigation property
	}
}
