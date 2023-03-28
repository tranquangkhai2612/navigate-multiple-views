using NavigateMultiViews.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigateMultiViews.ViewModel
{
    public class UserControl2ViewModel:BaseViewModel, IPageViewModel
    {
        private ICommand? _goTo1;
        private ICommand? _goTo3;

        public event EventHandler<EventArgs<string>>? ViewChanged;
        public string PageId { get; set; }
        public string Title { get; set; } = "View 2";

        public UserControl2ViewModel(string pageIndex = "2")
        {
            PageId = pageIndex;
        }

        public ICommand GoTo1
        {
            get
            {
                return _goTo1 ??= new RelayCommand(x =>
                {
                    ViewChanged?.Raise(this, "1");
                });
            }
        }

        public ICommand GoTo3
        {
            get
            {
                return _goTo3 ??= new RelayCommand(x =>
                {
                    ViewChanged?.Raise(this, "3");
                });
            }
        }
    }
}
