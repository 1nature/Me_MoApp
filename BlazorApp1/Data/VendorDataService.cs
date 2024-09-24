using Me_MoApp;

namespace BlazorApp1.Data
{
    public class VendorDataService
    {
        public List<Me_MoApp.Vendor>GetVendors()
        {
            var vendors = TestData.GetVendors();
            return vendors;
        }
    }
}
