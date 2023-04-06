using System.Diagnostics;
using System.Text.RegularExpressions;

 namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            const int MAX_WORD_NUM = 1000000;
            const int BUFFER_SIZE = 100000;
            const int OUTPUT_NUM = 10;

            // 读入文件
            StreamReader sr = new StreamReader(new BufferedStream(new FileStream(
                        "sdxl.txt", FileMode.Open), BUFFER_SIZE));
            string data = sr.ReadToEnd();

            // 切割出单词
            //string[] words = Regex.Split(data, "[^a-zA-Z]");
            // 切割出单词
            List<string> words = new List<string>(MAX_WORD_NUM * 10);
            int curPos = data.Length - 1, lastPos = curPos;
            while (curPos >= 0)
            {
                while (curPos >= 0 && !char.IsLetter(data[curPos]))
                    curPos--;
                lastPos = curPos;

                while (curPos >= 0 && char.IsLetter(data[curPos]))
                    curPos--;
                words.Add(data.Substring(curPos + 1, lastPos - curPos));
            }

            // 统计单词词频
            Dictionary<string, int> dict = new Dictionary<string, int>((int)(MAX_WORD_NUM * 1.5));
            foreach (var word in words)
            {
                if (word == "")
                    continue;

                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict.Add(word, 1);
            }

            List<Tuple<int, string>> list = new List<Tuple<int, string>>(MAX_WORD_NUM);
            foreach (var item in dict)
            {
                list.Add(Tuple.Create(item.Value, item.Key));
            }

            // 输出词频最高的前100个单词
            list.Sort();
            int count = 0;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i].Item2 + " " + list[i].Item1); count++;
                if (count > OUTPUT_NUM)
                    break;
            }

            sr.Close();
            Thread.Sleep(5000);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("程序的运行时间为{0}s", ts.TotalSeconds);
        }
    }

    
}



