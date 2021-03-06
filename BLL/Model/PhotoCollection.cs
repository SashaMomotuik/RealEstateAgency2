﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class PhotoCollection : ObservableCollection<Photo>
    {
        public PhotoCollection() { }

        public void AddImage(string pathFile)
        {
            Add(new Photo(pathFile));
        }

        public void AddImage(byte[] arr)
        {
            Add(new Photo(arr));
        }


    }
}
