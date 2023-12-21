using demo.Modal;
using demo.Views;
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
    public class MenViewModel
    {

        public static List<Boy> BoysX { get; set; } = new List<Boy>
        {
                new Boy { Name = "men_tShirts", Title = resourceManager.GetString("men_tShirts"), ImageName = "tshirts.jpg" },
                new Boy { Name = "men_formalShirts", Title = resourceManager.GetString("men_formalShirts"), ImageName = "formal_shirts.jpg" }
                //new Boy { Name = "men_formals", Description = resourceManager.GetString("men_formals"), ImageName = "boy.png" },
                //new Boy { Name = "men_jeans", Description = resourceManager.GetString("men_jeans"), ImageName = "jeans.jpg" },
                //new Boy { Name = "men_casualShoes", Description = resourceManager.GetString("men_casualShoes"), ImageName = "casual_shoes.jpg" }                
            };
        public List<Boy>  Boys { get; set; }

        public MenViewModel()
        {
            this.Boys = BoysX;            
            Console.WriteLine("Boys **********: "+this.Boys.Count);
        }

    }
}
