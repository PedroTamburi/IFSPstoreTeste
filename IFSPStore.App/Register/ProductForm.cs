using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

namespace IFSPStore.App.Register
{
    public partial class ProductForm : BaseForm
    {
        #region Variables
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService;
        private List<ProductModel> _products;
        private List<CategoryModel> _categories;
        #endregion

        #region Methods
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;

            InitializeComponent();

            _categories = _categoryService.Get<CategoryModel>().ToList();
            mcbGroup.Items.AddRange(_categories.Select(c => c.Name).ToArray());
        }

        private void FormToObject(Product product)
        {
            var purchaseDate = DateTime.ParseExact(
                mtbPurchaseDate.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            ).ToUniversalTime();

            product.Name = mtbName.Text;
            product.Value = Decimal.Parse(mtbValue.Text.Replace(",", "."));
            product.Quantity = int.Parse(mtbQuantity.Text);
            product.PurchaseDate = purchaseDate;
            product.SaleUnity = mcbSaleUnity.Text;
            product.Group = CategoryModelToObject(_categories.FirstOrDefault(c => c.Name == mcbGroup.Text)!);
        }

        private Category CategoryModelToObject(CategoryModel model)
        {
            return new Category(
                model.Id,
                model.Name,
                model.Description
            );
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(mtbId.Text, out int id);

                    var product = _productService.GetById<Product>(id);

                    FormToObject(product);

                    product = _productService.Update<Product, Product, ProductValidator>(product);
                }
                else
                {
                    var product = new Product();

                    FormToObject(product);

                    _categoryService.AttachObject(product.Group);

                    product = _productService.Add<Product, Product, ProductValidator>(product);
                }

                ClearFields();

                MessageBox.Show("Product saved successfully", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _productService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                _products = _productService.Get<ProductModel>(["Group"]).ToList();
                dataGridViewList.DataSource = _products;
                //dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            try
            {
                mtbId.Text = record?.Cells["Id"].Value.ToString();
                mtbName.Text = record?.Cells["Name"].Value.ToString();
                mtbValue.Text = record?.Cells["Value"].Value.ToString();
                mtbQuantity.Text = record?.Cells["Quantity"].Value.ToString();
                mtbPurchaseDate.Text = record?.Cells["PurchaseDate"].Value.ToString();
                mcbSaleUnity.Text = record?.Cells["SaleUnity"].Value.ToString();
                mcbGroup.Text = record?.Cells["Group"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
