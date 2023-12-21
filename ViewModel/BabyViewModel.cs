using demo.Modal;
//using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static demo.MauiProgram;

namespace demo.ViewModel
{

    public class BabyViewModel
    {
        //public static List<BabyItem> BabyItems { get; set; }
        public static List<BabyItem> BabyItems { get; set; } = new List<BabyItem>
            {
                new BabyItem { Name = "baby0to6months", ImageName = "babyhome.png" },
                new BabyItem { Name = "baby6to12months", ImageName = "babys_from_6_12.png" },
                new BabyItem { Name = "toys", ImageName = "toys.png" },
                new BabyItem { Name = "diapering", ImageName = "diaper.png" },
                new BabyItem { Name = "character_shop",   ImageName = "unique_dress.jpg" },
                new BabyItem { Name = "kids_room", ImageName = "baby_with_toy.jpg" }
            };
//static BabyViewModel()
//        {
            
//            BabyItems = new List<BabyItem>
//            {
//                new BabyItem { Title = resourceManager.GetString("baby0to6months"), OriginalTitle = "Baby 0 to 6 months", Image = "babyhome.png" },
//                new BabyItem { Title = resourceManager.GetString("baby6to12months"), OriginalTitle = "Baby 0 to 6 months", Image = "babys_from_6_12.png" },
//                new BabyItem { Title = resourceManager.GetString("toys"), OriginalTitle = "Baby 0 to 6 months", Image = "toys.png" },
//                new BabyItem { Title = resourceManager.GetString("diapering"), OriginalTitle = "Baby 0 to 6 months", Image = "diaper.png" },
//                new BabyItem { Title = resourceManager.GetString("character_shop"), OriginalTitle = "Baby 0 to 6 months", Image = "unique_dress.jpg" },
//                new BabyItem { Title = resourceManager.GetString("kids_room"), OriginalTitle = "Baby 0 to 6 months", Image = "baby_with_toy.jpg" }
//            };
//            Console.WriteLine("Bbay Items list in BabyViewmodel ################# " + BabyItems.Count);
//        }
        public BabyViewModel() {

            //BabyItems = new List<BabyItem>
            //{
            //    new BabyItem { Title = resourceManager.GetString("baby0to6months"), OriginalTitle = "Baby 0 to 6 months", Image = "babyhome.png" },
            //    new BabyItem { Title = resourceManager.GetString("baby6to12months"), OriginalTitle = "Baby 0 to 6 months", Image = "babys_from_6_12.png" },
            //    new BabyItem { Title = resourceManager.GetString("toys"), OriginalTitle = "Baby 0 to 6 months", Image = "toys.png" },
            //    new BabyItem { Title = resourceManager.GetString("diapering"), OriginalTitle = "Baby 0 to 6 months", Image = "diaper.png" },
            //    new BabyItem { Title = resourceManager.GetString("character_shop"), OriginalTitle = "Baby 0 to 6 months", Image = "unique_dress.jpg" },
            //    new BabyItem { Title = resourceManager.GetString("kids_room"), OriginalTitle = "Baby 0 to 6 months", Image = "baby_with_toy.jpg" }
            //};
        }
    }
}
