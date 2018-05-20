using System;

namespace lulu
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先有了lulu
            var _lulu = lulu.Getlulu();
            //之后又出来了一个直男
            IMate mate = new StraightMan();
            //直男变成了lulu的伴侣
            _lulu.mate = mate;
            //这里是直男的可爱
            _lulu.mate.Cute();
            //这里是直男的笨笨
            _lulu.mate.Clumsy();
            Console.Read();
        }
    }

    public class lulu
    {
        private static lulu _lulu;
        private static object _obj = new object();
        //这里是世界上独一无二的lulu
        public static lulu Getlulu()
        {
            if(_lulu==null)
            {
                lock(_obj)
                {
                    if(_lulu==null)
                    {
                        _lulu = new lulu();  
                    }
                }    
            }
            return _lulu;    
        }
        //这里是lulu的伴侣
        public IMate mate; 
    }

    //这是伴侣的一部分特点
    public interface IMate
    {
        void Cute();
        void Clumsy();
    }

    //这里是每个人对于特点的不同表现， 不同属性人的扩展可以通过实现Imate 接口
    public class StraightMan:IMate
    {
        public void Cute()
        {
            Console.WriteLine("here is cute straight man");
        } 

        public void Clumsy()
        {
            Console.WriteLine("here is a clumsy straight man");    
        }

    }

}
