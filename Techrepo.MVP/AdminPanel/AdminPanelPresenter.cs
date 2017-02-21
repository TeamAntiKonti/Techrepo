//using Techrepo.Models;
//using Techrepo.Services;
//using WebFormsMvp;

//namespace Techrepo.MVP.AdminPanel
//{
//    public class AdminPanelPresenter : Presenter<IAdminPanelView>
//    {
//        private readonly IAdvertCategoryService advertCategoryService;
//        public AdminPanelPresenter(IAdminPanelView view, IAdvertCategoryService advertCategoryService) 
//            : base(view)
//        {
//            this.advertCategoryService = advertCategoryService;
//            this.View.OnCreateNewCategory += View_OnCreateNewCategory;
//        }

//        private void View_OnCreateNewCategory(object sender, CreateCategoryEventArgs e)
//        {
//            this.advertCategoryService.CreateNewCategory(e.Name);
//        }

//       //private void View_OnCreateNewCity(object sender,CreateCityEventArgs e)
//       // {
//       //     //this.advertCategoryService
//       // }
//    }
//}
