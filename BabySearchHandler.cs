using demo.Modal;
using demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class BabySearchHandler : SearchHandler
    {
        public IList<BabyItem> baby;
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
        }
    }
}
