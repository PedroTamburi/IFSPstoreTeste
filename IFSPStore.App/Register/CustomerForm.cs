using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{
    public partial class CustomerForm : BaseForm
    {
        #region Variables
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<City> _cityService;
        private List<CustomerModel> _customers;
        private List<CityModel> _cities;

        #endregion

        #region Methods
        public CustomerForm(IBaseService<Customer> customerService, IBaseService<City> cityService)
        {
            _customerService = customerService;
            _cityService = cityService;

            InitializeComponent();

            _cities = _cityService.Get<CityModel>().ToList();
            mcbCity.Items.AddRange(_cities.Select(c => c.Name).ToArray());
        }

        private void FormToObject(Customer customer)
        {
            customer.Name = mtbName.Text;
            customer.Document = mtbDocument.Text;
            customer.Address = mtbAddress.Text;
            customer.Neighborhood = mtbNeighborhood.Text;
            customer.City = CityModelToObject(_cities.FirstOrDefault(c => c.Name == mcbCity.Text)!);
        }

        private City CityModelToObject(CityModel model)
        {
            return new City(
                model.Id,
                model.Name,
                model.State
            );
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(mtbId.Text, out int id);

                    var customer = _customerService.GetById<Customer>(id);

                    FormToObject(customer);

                    customer = _customerService.Update<Customer, Customer, CustomerValidator>(customer);
                }
                else
                {
                    var customer = new Customer();

                    FormToObject(customer);

                    _cityService.AttachObject(customer.City);

                    customer = _customerService.Add<Customer, Customer, CustomerValidator>(customer);
                }

                ClearFields();

                MessageBox.Show("Customer saved successfully", "IFSP Store",
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
                _customerService.Delete(id);
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
                _customers = _customerService.Get<CustomerModel>(["City"]).ToList();
                dataGridViewList.DataSource = _customers;
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
                mtbDocument.Text = record?.Cells["Document"].Value.ToString();
                mtbAddress.Text = record?.Cells["Address"].Value.ToString();
                mtbNeighborhood.Text = record?.Cells["Neighborhood"].Value.ToString();
                mtbNeighborhood.Text = record?.Cells["Neighborhood"].Value.ToString();
                mcbCity.Text = record?.Cells["City"].Value.ToString()!.Split("/")[0];
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
