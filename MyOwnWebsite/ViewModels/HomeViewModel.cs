using Core.Entities;
using System.Collections.Generic;

namespace MyOwnWebsite.ViewModels
{
    public class HomeViewModel
    {
        public Owner owner { get; set; }
        public IEnumerable<PortofolioItems> portofolioItems { get; set; }
    }
}
