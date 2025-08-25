
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱
            //// 각 형식의 데이터를 참조 형식으로 변환하는 과정입니다.
            //int value = 100;
            //object generic = value;

            //Console.WriteLine("value : "+ value);
            //Console.WriteLine("generic : " + generic);
            #endregion
            #region 언박싱
            //// 참조 형식의 데이터를 값 형식으로 반환하는 과정입니다.
            //int box = (int)generic;
            //Console.WriteLine("box : " + box);
            #endregion
            utillity Utillity = new utillity();
            Utillity.Pause();

            int next = 10;
            int previous = 0;

            Utillity.Swap(ref next, ref previous);
            Console.WriteLine("next 변수의 값 : " + next);
            Console.WriteLine("previous 변수의 값 : " + previous);

            int num = -40;
            Utillity.Absolute(num);
            Console.WriteLine("Absolute의 값 : " + Utillity.Absolute(in num));
        }
        
    }
}
