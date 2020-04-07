using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using Caliburn.Micro;

namespace CaliburnExperimental
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public ShellViewModel()
        {
            Items.Add(new Page1ViewModel());
            Items.Add(new Page2ViewModel());
            Items.Add(new Page3ViewModel());
            Items.Add(new Page4ViewModel());
            Items.Add(new Page5ViewModel());
            ActivateItem(Items.FirstOrDefault());
        }
    }

    public class PageViewModel : Conductor<IScreen>.Collection.AllActive
    {
        
    }
    public class Page1ViewModel : PageViewModel
    {
        public Page1ViewModel()
        {
            DisplayName = "Page 1";
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
    public class Page2ViewModel : PageViewModel
    {
        public Page2ViewModel()
        {
            DisplayName = "Page 2";
        }
        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
    public class Page3ViewModel : PageViewModel
    {
        public Page3ViewModel()
        {
            DisplayName = "Page 3";
        }
        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
    public class Page4ViewModel : PageViewModel
    {
        public Page4ViewModel()
        {
            DisplayName = "Page 4";
        }
        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
    public class Page5ViewModel : PageViewModel
    {
        public Page5ViewModel()
        {
            DisplayName = "Page 5";
        }
        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
}
