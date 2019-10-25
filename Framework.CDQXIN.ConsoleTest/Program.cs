
using Framework.CDQXIN.Redis;
using Framework.CDQXIN.RedisHelperExt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CDQXIN.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //RedisHelper rhp=new RedisHelper();
            ICache rhb = new CacheByRedis();
            Console.WriteLine("操作开始");
            rhb.Write<Student>("u001", new Student() { Id = 100, Name = "jim", Age = 18 }, new TimeSpan(0, 0, 180));

            //Console.WriteLine(rhp.StringGet("u001"));
            Console.WriteLine("操作结束");
            Console.ReadLine();
        }
    }

    public class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
