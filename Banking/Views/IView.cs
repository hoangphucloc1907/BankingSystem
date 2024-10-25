using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Views
{
    internal interface IView
    {
        void SetDataToText(object item);
        void GetDataFromText();
    }
}
