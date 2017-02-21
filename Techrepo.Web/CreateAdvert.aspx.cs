using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Techrepo.Models;
using Techrepo.MVP.CreateAdvert;
using WebFormsMvp;
using WebFormsMvp.Web;
using Microsoft.AspNet.Identity;
using System.IO;

namespace Techrepo.Web
{
    [PresenterBinding(typeof(CreateAdvertPresenter))]
    public partial class CreateAdvert : MvpPage<CreateAdvertViewModel>, ICreateAdvertView
    {
        private const int maxAdvertPhotoSize = 2048000;

        public event EventHandler<CreateAdvertEventArgs> OnCreateAdvert;
        public event EventHandler CustomOnInit;

        //public string PhotosUrl { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CustomOnInit?.Invoke(sender, e);

            if(!IsPostBack)
            {
                this.Category.DataSource = this.Model.AdvertCategories;
                this.Category.DataBind();

                this.City.DataSource = this.Model.Cities;
                this.City.DataBind();
                
                this.ProductState.DataSource = this.Model.GetProductStates();
                this.ProductState.DataBind();

                this.Delivery.DataSource = this.Model.GetDelivery();
                this.Delivery.DataBind();
            }            
        }

        protected void CreateAdvert_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                var id = this.Page.User.Identity.GetUserId();

                var selectedCategory = this.Category.SelectedItem.Text;
                var category = this.Model.AdvertCategories.FirstOrDefault(x => x.Name == selectedCategory);

                var selectedCity = this.City.SelectedItem.Text;
                var city = this.Model.Cities.FirstOrDefault(x => x.Name == selectedCity);

                var selectedState = this.ProductState.SelectedItem.Text;

                var selectedDelivery = this.Delivery.SelectedItem.Text;

                string photosUrl = "";

                if (UploadedImages.HasFiles)
                {
                    try
                    {
                        bool meetsConditions = true;
                        foreach (var photo in UploadedImages.PostedFiles)
                        {
                            if(photo.ContentType != "image/jpeg" && photo.ContentType != "image/png")
                            {
                                StatusLabel.Text = "Upload status: Only JPEG/PNG files are accepted!";
                                meetsConditions = false;
                                break;
                            }
                            if(photo.ContentLength > maxAdvertPhotoSize)
                            {
                                StatusLabel.Text = "Upload status: The files size must be maximum 2mb!";
                                meetsConditions = false;
                                break;
                            }
                        }

                        if(meetsConditions)
                        {
                            string filename;

                            string path = "~/images/AdvertsPhotos/" + id.ToString();

                            bool exists = Directory.Exists(Server.MapPath(path));

                            if (!exists)
                            {
                                Directory.CreateDirectory(Server.MapPath(path));
                            }

                            foreach (var photo in UploadedImages.PostedFiles)
                            {
                                filename = id.ToString() + "/" + Path.GetFileName(photo.FileName);
                                string saveDirectory = Server.MapPath("/images/AdvertsPhotos/") + filename;
                                photo.SaveAs(saveDirectory);
                                StatusLabel.Text = "Upload status: File uploaded!";
                                photosUrl += ("/images/AdvertsPhotos/" + filename + ";");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = "Sorry, we could not create your event!";
                    }
                }


                var advert = new Advert()
                {                    
                    OwnerId = id,
                    Title = this.AdvertTitle.Text,
                    Description = this.AdvertDescription.Text,
                    Price = int.Parse(this.AdvertPrice.Text),
                    Category = category,
                    CategoryId = category.Id,
                    City = city,
                    CityId = city.Id,
                    OwnerPhone = this.OwnerPhone.Text,
                    OwnerEmail = this.OwnerEmail.Text,
                    Delivery = selectedDelivery,
                    ProductState = selectedState,
                    Photos = photosUrl
                };

                this.OnCreateAdvert?.Invoke(this, new CreateAdvertEventArgs(advert));

                Response.Redirect("/Adverts");
            }
        }
    }
}