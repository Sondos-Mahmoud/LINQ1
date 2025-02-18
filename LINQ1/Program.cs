namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [var, dynamic]
            #region Var
            //var name = "Ahmed";
            //// compiler will detect the variable datatype
            //// based on its initial value at compilation time

            //var name02; // invalid
            //// must be initialized

            //var name03 = null;
            //// can't be initialized with null
            //name = null;
            #endregion
            #region Dynamic
            //dynamic name = "Ahmed"; // like var (js)
            //name = 10;
            //name = true;
            //dynamic x; // not must be initialized
            //dynamic y = null; // can be initialized with null

            //// CLR will detect the variable datatype
            //// based on its last assigned value at runtime
            #endregion
            #endregion
            #region Extension method
            // 123
            // 321
            int x = 123;
            //int y = IntExtension.Reverse(x);
            long y = x.Reverse();
            long z = 123;
            y=z.Reverse();

            #endregion
        }
    }
}