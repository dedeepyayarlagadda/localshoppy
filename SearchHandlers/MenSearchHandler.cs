using demo.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.SearchHandlers
{
    public class MenSearchHandler : SearchHandler
    {
        public IList<Boy> MenList { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if(string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = MenList.Where(men => men.Description.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

        }
    }
}
