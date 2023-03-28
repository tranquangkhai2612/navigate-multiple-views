using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateMultiViews.Model
{
    public interface IDataModel
    {
        string Data { get; set; }
        string? Reserse();
    }
}
