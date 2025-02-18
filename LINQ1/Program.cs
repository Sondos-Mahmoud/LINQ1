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
            //// 123
            //// 321
            //int x = 123;
            ////int y = IntExtension.Reverse(x);
            //long y = x.Reverse();
            //long z = 123;
            //y=z.Reverse();

            #endregion

            #region Anonymous Type
            //var employee = new { Id = 10, Name = "Ahmed", Salary = 5000 }; // Anonymous
            //                                                               // AnonymousType0^3

            ////Console.WriteLine(employee.Id);
            ////Console.WriteLine(employee);
            //int x = 2;
            //Console.WriteLine(employee.GetType().Name);
            ////Console.WriteLine(employee.Age); // invalid
            ////employee.Id = 20; // invalid

            //employee = new { Id = 20, employee.Name, employee.Salary };
            //employee = employee with { Id = 20 }; // C# 10 feature syntax sugar

            //var employee02 = new { Id = 50, Name = "hamada", Salary = 3000 };
            //var employee03 = new { Id = 50, name = "hamada", Salary = 3000 };
            //var employee04 = new { Id = 50, Salary = 3000, Name = "hamada" };

            //Console.WriteLine(employee02.GetType().Name);
            //Console.WriteLine(employee03.GetType().Name);
            //Console.WriteLine(employee04.GetType().Name);



            #endregion
            #region LINQ Syntax
            // List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            // //var oodNum=numbers.Where(x => x%2 == 1).ToList();
            //var oodNum = numbers.Where((x) => x % 2 == 1) ; 
            // oodNum=from x in numbers
            //        where x%2 == 1
            //        select x;


            // foreach (var item in oodNum)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region defared Excution
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var oddNum = Enumerable.Where(numbers, N => N % 2 == 1);

            numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            foreach (var item in oddNum)
            {
                Console.WriteLine(item);
            } 
            #endregion
        }
    }
}