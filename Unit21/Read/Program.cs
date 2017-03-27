using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData = new byte[200];
            char[] charData = new char[200];

            try
            {
                FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);
                // Seek摘要:
                //     将该流的当前位置设置为给定值。
                //
                // 参数:
                //   offset:
                //     相对于 origin 的点，从此处开始查找。
                //
                //   origin:
                //     使用 System.IO.SeekOrigin 类型的值，将开始位置、结束位置或当前位置指定为 origin 的参考点。
                //
                // 返回结果:
                //     流中的新位置。
                //public override long Seek(long offset, SeekOrigin origin);
                aFile.Seek(3, SeekOrigin.Begin);//设置开始位置
                // 参数:
                //   array:
                //     此方法返回时包含指定的字节数组，数组中 offset 和 (offset + count - 1) 之间的值被从当前源中读取的字节替换。
                //
                //   offset:
                //     array 中的字节偏移量，将在此处开始读取字节。
                //
                //   count:
                //     最多读取的字节数。
                aFile.Read(byteData, 0, 200);//0是偏移量，由于一定定义byteData[200],count最大为200
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }
             //将一个编码字节序列转换为一组字符。
            Decoder d = Encoding.UTF8.GetDecoder();
            //public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush); 
            //d.getchars摘要:
            //     在派生类中重写时，将字节序列（从指定的字节指针处开始）和任何内部缓冲区中的字节解码为从指定字符指针开始存储的一组字符。
            //一个参数，指示转换后是否要清除解码器的内部状态。
            //
            // 参数:
            //   bytes:
            //     指向第一个要解码的字节的指针。
            //
            //   byteCount:
            //     要解码的字节数。
            //
            //   chars:
            //     一个指针，指向开始写入所产生的字符集的位置。
            //
            //   charCount:
            //     要写入的最大字符数。
            //
            //   flush:
            //     如果要在转换后清除解码器的内部状态，则为 true；否则，为 false。
            //
            // 返回结果:
            //     在由 chars 参数指示的位置处写入的实际字符数。
            d.GetChars(byteData, 0, byteData.Length, charData, 0);

            Console.WriteLine(charData);
            Console.ReadKey();
        }
    }
}
