namespace DiplomsClassLibrary.Models
{
    public enum AcademicDegree
    {
        Bachelor,
        Magister,
        Aspirant,
        Candidat,
        Specialist,
        Doctor,
        //sadas
    }

    public interface IItem
    {
        int Id { get; set; }
    }
}
