using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    class Class_ReadFile
    {
        ArrayList lftext = new ArrayList();

        public ArrayList listfiletext {
            get { return lftext; }
            set { lftext = value; }
        }

        //ファイルを1行ずつ読み込み配列に格納
        public int readListFile(string filePath)
        {
            string line = "";


            using (StreamReader sr = new StreamReader(
                filePath, Encoding.GetEncoding("Shift_JIS")))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    //1文字目が#ではなく空白でもない
                      if (!line.StartsWith("#") && line != "")
                    {
                        //１文字目がコメントじゃなかったら文字列を取得する。
                        lftext.Add(line);
                    }
                }
            }

            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            return 0;
        }

    }
}
