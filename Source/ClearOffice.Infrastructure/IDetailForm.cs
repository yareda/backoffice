using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Infrastructure
{
    public interface IDetailForm
    {
        void ShowObject(object keyValue);
        bool DataChanged();
        void SaveChanges();
        void DeleteObject();
        bool ValidateForm();
        void AuthorizeForm();
    }
}
