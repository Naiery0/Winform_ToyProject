using DevExpress.XtraRichEdit.Import.Rtf;
using System;
using System.Collections.Generic;
using System.IO;
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
        private const string BASE_PATH = ".\\data\\";

        protected FileManagement()
        {
        }

        public void WriteRank(string name, int score)
        {
            string filePath = $"{BASE_PATH}rank.txt";
            bool isWritten = false;
            Dictionary<string, string> playerInfo = new Dictionary<string, string> { { name, score.ToString() } };

            // 파일 읽기
            LinkedList<Dictionary<string, string>> linkedlist = ReadRank();

            // 순위 계산
            for (int i = 0; i < linkedlist.Count; i++)
            {
                if (int.Parse(linkedlist.ElementAt(i).Values.First()) <= score)
                {
                    linkedlist.AddBefore(linkedlist.Find(linkedlist.ElementAt(i)), playerInfo);
                    isWritten = true;
                    break;
                }
            }

            // 처음 쓰면
            if (linkedlist.Count is 0)
            {
                linkedlist.AddFirst(playerInfo);
                isWritten = true;
            }

            // 랭킹 갱신 없으면
            if (!isWritten)
                return;

            if (linkedlist.Count > 10)
                linkedlist.RemoveLast();

            string fileString = string.Empty;

            foreach (var item in linkedlist)
                fileString += $"{item.Keys.First()},{item.Values.First()}\n";
            
            File.WriteAllText($"{BASE_PATH}rank.txt", fileString);
            return;
        }

        public LinkedList<Dictionary<string, string>> ReadRank()
        {
            LinkedList<Dictionary<string, string>> rankDictList = new LinkedList<Dictionary<string, string>>();

            // 파일 읽어오기
            string filePath = $"{BASE_PATH}rank.txt";
            string[] rankArr;

            if (File.Exists(filePath))
            {
                rankArr = File.ReadAllLines(filePath);
            }
            else
            {
                if (!Directory.Exists(BASE_PATH))
                    Directory.CreateDirectory(BASE_PATH);

                File.Create(filePath).Close();

                return rankDictList;
            }
            
            for (int i = 0; i < rankArr.Length; i++)
            {
                string name = rankArr[i].Split(',')[0];
                string score = rankArr[i].Split(',')[1];

                rankDictList.AddLast(new Dictionary<string, string> { { name, score } });
            }

            return rankDictList;
        }

        internal void SaveRecord(string title, string data)
        {
            string filePath = $"{BASE_PATH}{title}.txt";
            if (!Directory.Exists(BASE_PATH))
                Directory.CreateDirectory(BASE_PATH);

            File.WriteAllText(filePath, data);
        }
    }
}
