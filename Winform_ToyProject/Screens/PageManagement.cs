using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Screens
{
    public class PageManagement
    {
        #region instance
        private static PageManagement? instance;
        public static PageManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new PageManagement();
                return instance;
            }
        }
        #endregion
        public event EventHandler<int>? OnPageChanged;
        public void ChangePage(int index) => OnPageChanged?.Invoke(this, index);

    }
}
