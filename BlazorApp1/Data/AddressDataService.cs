using Me_MoApp;

namespace BlazorApp1.Data
{
    public class AddressDataService
    {
        public List<Me_MoApp.Address> GetAddresses()
        {
            var addresses = TestData.GetUserAddress();
            return addresses;
        }
    }
}
