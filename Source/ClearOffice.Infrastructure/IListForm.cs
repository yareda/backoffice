using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Infrastructure
{
    public interface IListForm
    {
        void ShowList();
        void OpenSelectedItem();
        object GetSelectedItem();
        void RefreshList();
        void AuthorizeForm();
    }
}
