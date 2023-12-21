using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using demo.Modal;
using System.Reflection;
using System.Resources;
using System.Windows.Input;

namespace demo.ViewModel
{
    public partial class BabyDetailViewModel: ObservableObject
    {
        
        string selectedText;
        public string Title { get; set; }
        public string Image { get; set; }
        public ICommand Command { get; set; }
        public Type Page { get; set; }
        public List<BabyItem> Items { get; set; }
        public string AppVersion { get; set; } = "2.0";

        public BabyDetailViewModel()
        {
            ResourceManager resourceManager = new ResourceManager("demo.Resources.Strings", Assembly.GetExecutingAssembly());
            Items = new List<BabyItem>
            {
                new BabyItem { Name = resourceManager.GetString("baby0to6months"), ImageName = "babyhome.png" },
                new BabyItem { Name = resourceManager.GetString("baby6to12months"), ImageName = "babys_from_6_12.png" },
                new BabyItem { Name = resourceManager.GetString("toys"), ImageName = "toys.png" },
                new BabyItem { Name = resourceManager.GetString("diapering"), ImageName = "diaper.png" },
                new BabyItem { Name = resourceManager.GetString("character_shop") , ImageName = "unique_dress.jpg" },
                new BabyItem { Name = resourceManager.GetString("kids_room"), ImageName = "baby_with_toy.jpg" }
            };
        }

       
    }

}
