using Prism.Modularity;
using Prism.Regions;
using Modules.User.Views;

namespace Modules.User
{
    public class UserModule : IModule
    {
        IRegionManager _regionManager;
        public UserModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(UserView));
        }
    }
}
