using TTTRazorDivCheckRadioDrpDown24.Models;

namespace TTTRazorDivCheckRadioDrpDown24.MockData
{
    public interface ITeacherService
    {
        List<Teacher> Teachers { get; }
        void Add(Teacher item);
        void Clear();
        Teacher Find(Predicate<Teacher> match);
        bool Remove(Teacher item);
    }
}
