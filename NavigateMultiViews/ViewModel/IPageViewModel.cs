using NavigateMultiViews.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateMultiViews.ViewModel
{
    public interface IPageViewModel
    {
        event EventHandler<EventArgs<string>>? ViewChanged;
        string PageId { get; set; }
        string Title { get; set; }
    }
}
