using System;
using System.IO;
namespace ExceptionS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    ConvertRead();
                }
                catch(InvalidCastException e)
                {
                    Console.WriteLine("你输入的成绩无法转换");
                    File.AppendAllText(@"C:\17bang\twoException.log", e.ToString() + "\n" + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的不是成绩");
                    File.AppendAllText(@"C:\17bang\twoException.log", e.ToString() + "\n" + "\n");
                }
                catch(Exception e)
                {
                    File.AppendAllText(@"C:\17bang\twoException.log", e.ToString() + "\n"+"\n");
                    Console.WriteLine("出现一个小小小的问题，请谅解");
                }
            }

        }
      
        static Slevel Map(int score)
        {
            if (score > 100||score<0)
            {
                throw new ArgumentOutOfRangeException($"{score}超出范围");
            }
            else if (score >= 80)
            {
                return Slevel.Excellent;
            }
            else if (score >= 60)
            {
                return Slevel.Passed;
            }
            else
                return Slevel.Failed;
        }
        static void Congratulate(int score)
        {
            Slevel level = new Slevel();
            try
            {
                level = Map(score);
                switch (level)
                {
                    case Slevel.Excellent:
                        Console.WriteLine("you got an exellent grade");
                        break;
                    case Slevel.Passed:
                        Console.WriteLine("you just passed it,please day day up");
                        break;
                    case Slevel.Failed:
                        Console.WriteLine("you failed it this time,best wished with u");
                        break;
                    default:
                        throw new NotImplementedException("你的成绩可能有问题");
                }
            }
            catch (Exception e)
            {
                File.AppendAllText(@"C:\17bang\oneException.log", $"输入的{score}未能转换"+e.ToString()+Environment.NewLine+"\n");
                throw new InvalidCastException($"{score}未能成功转换为等级",e);
            }

        }
        static void ConvertRead()
        {
            //int score = Convert.ToInt32(Console.ReadLine());
            //Congratulate(score);
            if (int.TryParse(Console.ReadLine(),out int result))
            {
                Congratulate(result);
            }
            else
            {
                Console.WriteLine("you maobing");
            }
            
        }
    }

    enum Slevel
    {
        Excellent,
        Passed,
        Failed
    }
   

}
