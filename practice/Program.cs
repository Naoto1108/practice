using System;
using System.IO;
using System.Text;
using System.Data;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //新しくファイルを作成する
        string fileName;
        Console.Write("ファイル名を入力");
        fileName = Console.ReadLine();
        using (StreamWriter f = new StreamWriter(fileName))
        {
            // CSVファイルの読み込み
            string filePath = @"C:\Users\naoto\Desktop\log_data.csv";
            // StreamReaderクラスをインスタンス化
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("UTF-8"));
            // 最後まで読み込む
            while (reader.Peek() >= 0)
            {
                // 読み込んだ文字列をカンマ区切りで配列に格納
                string[] cols = reader.ReadLine().Split(',');
                for (int n = 0; n < cols.Length; n++)
                {
                    // 表示
                    Console.Write(cols[n] + ",");
                }
                f.WriteLine(cols);

                //昇順の変更をおこなう　Array.Sort(name);
                //削除を行うname.Remove();
                //リストを作る？　var list = new List<string>();
                //list.Add(cols[cols.Length - 1]);
                //Console.Write(list + ",");
                Console.ReadLine();
            }
            Console.ReadLine();
            f.Close();
        }
    }
}