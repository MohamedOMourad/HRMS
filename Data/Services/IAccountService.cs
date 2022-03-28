namespace test.Services
{
    public interface IAccountService
    {
        bool CheckHolidaysAndAleadyLogged();
        void MakeAllEmployeeAbsent();
    }
}