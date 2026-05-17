using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Screens
{
    public class PageManagement
    {
        #region instance
        private static PageManagement? _instance;
        public static PageManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PageManagement();
                return _instance;
            }
        }
        #endregion
        public event EventHandler<int>? OnPageChanged;
        public void ChangePage(int index) => OnPageChanged?.Invoke(this, index);

    }
}
