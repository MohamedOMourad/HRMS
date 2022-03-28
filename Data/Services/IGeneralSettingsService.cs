using test.Data.ViewModels;

namespace test.Services
{
    public interface IGeneralSettingsService
    {
        GeneralSettingsViewModel Index();
        void Update(GeneralSettingsViewModel generalSettingVM);
    }
}