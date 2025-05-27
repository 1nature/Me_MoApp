using Me_MoApp;

namespace BlazorApp2.Data
{
    public class VendorDataService
    {
        private List<Vendor> _vendors = new();

        public List<Me_MoApp.Vendor> GetVendors()
        {
            if (_vendors.Count == 0)
                _vendors = TestData.GetVendors();

            return _vendors;
        }

        public Vendor GetVendorByName(string vendorName)
        {
            return _vendors.Where(v => v.BusinessName == vendorName).FirstOrDefault();
        }

        public void AddVendor(Vendor vendor)
        {
            if (vendor != null)
            {
                _vendors.Add(vendor);
            }
        }
    }
}
