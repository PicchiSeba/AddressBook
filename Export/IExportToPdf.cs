﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Export
{
    public interface IExportToPdf
    {
        void AddRowElements(List<String> elems);
        void SaveFile();
    }
}
