using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;

            try
            {
                FileStream aFile = new FileStream("D:/Temp.txt", FileMode.Create);//创建文件
                charData = "My pink half of the drainpipe.".ToCharArray();//为文件添加数据
                //规定输入数据的长度
                byteData = new byte[charData.Length - 3];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length - 3, byteData, 0, true);

                // Move file pointer to beginning of file.
                //复位操作,重新加载xmlreader
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteData, 0, byteData.Length);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                return;
            }
        }
    }
}
