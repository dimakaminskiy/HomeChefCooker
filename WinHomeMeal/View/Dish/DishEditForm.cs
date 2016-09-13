using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Helper;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.Controls;

namespace WinHomeMeal.View.Dish
{
    public partial class DishEditForm : Form
    {
        public WinHomeMeal.Dish Dish { get; set; }
        public UnitOfWork DataManager { get; }
        public List<WinHomeMeal.Product> Products { get; set; }
        public List<WinHomeMeal.Measure> Measures { get; set; }
        public List<Ingredient> Ingredients;
        public List<DishImage> DishImages { get; set; }
        public int? DishImageIndex { get; set; }
        IEnumerable<IngredientUserControl> IngredientUserControls { get; set; }
        private PictureBox DishPicturebox {get { return dishUserControl1.picImage; } }
        public DishEditForm( WinHomeMeal.Dish dish)
        {
            DataManager = UnitOfWork.GetInstance();
            InitializeComponent();
            Initialize();

            Dish = dish;
            DishImages = new List<DishImage>();
            Ingredients = new List<Ingredient>();

            if (Dish.DishImages != null)
            {
                DishImages.AddRange(Dish.DishImages);
            }
            
            if (dish.Ingredients != null)
            {
                Ingredients.AddRange(dish.Ingredients.ToArray());
            }
            
            dishUserControl1.btnDownload.Click += BtnDownload_Click;
            dishUserControl1.btnNext.Click += BtnNext_Click;
            dishUserControl1.btnPrev.Click += BtnPrev_Click;
        }
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            SetPrevImage();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            SetNexImage();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
            x.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            DialogResult dialogResult   =   x.ShowDialog();

            if (dialogResult!= DialogResult.OK) return;
            string[] result = x.FileNames;

            string[] extentions = {".jpg", ".jpeg", ".jpe", ".png"};

            List<DishImage> images = new List<DishImage>();

            foreach (var s in result)
            {
                if (!File.Exists(s)) continue;
                var ext = Path.GetExtension(s);
                if (extentions.Any(t => t == ext))
                {
                    try
                    {
                        var image = ImageHelper.LoadImageNoLock(s);
                        var img = ImageHelper.ResizeImage(image, 450, 250);
                        var bytes = ImageHelper.ImageToByteArray(img);
                        images.Add(new DishImage() {DishId = Dish.Id, Image = bytes});
                    }
                    catch (Exception)
                    {
                    }
                }


            }
            
            if (images.Any())
            {
                DishImages.AddRange(images);
                BtnNext_Click(null,null);
            }
        }

        void Initialize()
        {
            Products = DataManager.ProductRepository.Get().OrderBy(t => t.Name).ToList();
            Measures = DataManager.MeasureRepository.Get().OrderBy(t => t.Name).ToList();
            IngredientUserControls = dishUserControl1.groupIngredientUserControl.Controls.OfType<IngredientUserControl>().ToArray();
            FillIngredientUserControls();
        }


        void FillIngredientUserControls()
        {
            foreach (var control in IngredientUserControls)
            {
                control.comboProduct.DataSource = Products;
                control.comboProduct.ValueMember = "Id";
                control.comboProduct.DisplayMember = "Name";
                control.comboMeasure.DataSource = Measures;
                control.comboMeasure.ValueMember = "Id";
                control.comboMeasure.DisplayMember = "Name";
            }
        }


        private void SetNexImage()
        {

            if (!DishImages.Any()) return;

            if (DishImageIndex == null)
            {
                DishImageIndex = 0;
            }
            else
            {
                if (DishImageIndex != DishImages.Count-1)
                {
                    DishImageIndex ++;
                }
                else
                {
                    DishImageIndex = 0;
                }
            }

            if (DishImageIndex == null) return;
            DishPicturebox.Image = ImageHelper.ByteArrayToImage(DishImages[DishImageIndex.Value].Image);
            
        }

        void SetPrevImage()
        {
            if (!DishImages.Any()) return;

            if (DishImageIndex == null)
            {
                DishImageIndex = 0;
            }
            else
            {
                if (DishImageIndex != 0)
                {
                    DishImageIndex--;
                }
                else
                {
                    DishImageIndex = DishImages.Count;
                }
            }


            if (DishImageIndex == null) return;
            DishPicturebox.Image = ImageHelper.ByteArrayToImage(DishImages[DishImageIndex.Value].Image);
        }

       






        public void InitializeComboDishCategories(IngredientUserControl control, Ingredient ingredient)
        {
            InitializeProductCombobox(control.comboProduct, Products, ingredient.ProductId);
            InitializeMeasureCombobox(control.comboMeasure, Measures, ingredient.MeasureId);
            control.txtValue.Text = ingredient.Value.ToString();
        }

        private void InitializeProductCombobox(ComboBox control, List<WinHomeMeal.Product> products, int selected)
        {
            products.Insert(0, new WinHomeMeal.Product() {Id=0, Name ="--------------"});
            control.DataSource = products;
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            control.SelectedValue = selected;

        }

        private void InitializeMeasureCombobox(ComboBox control, List<WinHomeMeal.Measure> measures, int selected)
        {
            measures.Insert(0, new WinHomeMeal.Measure() { Id = 0, Name = "--------------" });
            control.DataSource = measures;
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            control.SelectedValue = selected;

        }



    }
}
