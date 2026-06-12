using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Services
{
    // 랭킹, 악보, 세팅 파일을 관리할 클래스
    public class FileManagement
    {
        #region instance
        private static FileManagement? instance;
        public static FileManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new FileManagement();

                return instance;
            }
        }
        #endregion

        protected FileManagement()
        {
        }
    }
}
