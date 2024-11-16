using System.Text.RegularExpressions;
using static ConsoleApp1.ListGenerators;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fluent syntax
            ////fluent syntax

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> oddNumber = Enumerable.Where(list, N => N % 2 != 0).ToList();

            //foreach (int n in oddNumber)
            //{
            //    Console.WriteLine(n);
            //}

            //var EvenNumber = list.Where(N => N % 2 == 0);

            //foreach (int n in EvenNumber)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region Query Syntax

            ////Query Syntax

            //List<int> values = new List<int> { 5, 50, 500, 5000, 50000, 500000 };

            //List<int> values1 = (from v in values
            //                     where v % 2 == 1
            //                     select v).ToList();

            //var values2 = (from v in values
            //               where v % 2 == 1
            //               select v).ToList(); 
            #endregion

            #region Differed Excuation
            ////Differed Excuation

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//1 3 5 7 9

            //var OddNumbers = Numbers.Where(N => N % 2 != 0);

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });//1  3  5  7  9  11 
            //                                                                         13 15 17 19

            //foreach (var item in OddNumbers)
            //{

            //       Console.WriteLine(item);
            //}
            #endregion

            #region immediate Excuation
            ////immediate Excuation[Casting - Element - Aggreagate]

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(N => N % 2 != 0).ToList();

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Setup Data 
            //Setup Data 

            //Console.WriteLine(ProductList[0]); 
            #endregion

            #region Filtration
            ////Filtration
            ////product is out of stock
            //int num = 0;
            //var result = ProductList.Where((P, I) => I < 100 && P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.Write(num++ + " ");

            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------------");


            //result = from p in ProductList 
            //         where p.UnitsInStock == 0
            //         select p;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Transformation operators

            //var result = ProductList.Select(p => p.ProductName);

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    } 





            //var result = CustomerList.SelectMany(c => c.Orders);
            //var result2 = CustomerList.Select(c => c.Address);


            //foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //Console.WriteLine("-----------------");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = ProductList.Select(p => new { ProductID = p.ProductID, ProductName = p.ProductName });
            //  foreach (var item in result)
            //      {
            //          Console.WriteLine(item);
            //      }
            //////--------------------------------------------
            //var result = from p in ProductList
            //             select new
            //             {
            //                 Name = p.ProductName,
            //                 id = p.ProductID
            //             };

            //   foreach (var item in result)
            //       {
            //           Console.WriteLine(item);
            //       }







            //var result = ProductList.Where(p=> p.UnitsInStock > 0)
            //                         .Select (p=>new{
            //                             ID = p.ProductID,
            //                             name = p.ProductName,
            //                             Price = p.UnitPrice

            //                         });

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             select new
            //             {
            //                 ID = p.ProductID,
            //                 name = p.ProductName,
            //                 Price = p.UnitPrice
            //             };                  

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Ordering Operator

            //var result = ProductList.OrderBy(x => x.UnitPrice).ToList();
            //  foreach (var item in result)
            //      {
            //          Console.WriteLine(item);
            //      } //order by default is ascending 

            //var result = from p in ProductList
            //             orderby p.UnitPrice descending
            //             select p; //order by default is ascending 

            #endregion

            #region Element Operator
            //var first =ProductList.First();
            //var last  =ProductList.Last();

            //Console.WriteLine(first?.ProductName??"Not Found");
            //var first =ProductList.FirstOrDefault(); //to return Not Found



            #endregion

            #region Hybird Syntax
            //var result = (from p in ProductList
            //              where p.UnitsInStock == 0
            //              select new
            //              {
            //                  p.ProductID,
            //                  p.ProductName,
            //                  p.UnitsInStock
            //              }).FirstOrDefault();

            #endregion

            #region Casting Operator

            //List<Product> product01 = ProductList.Where(P=>P.UnitsInStock==0).ToList();

            //Product[] product02 = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long,string> dictionary03 = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(p=>p.ProductID,
            //                                                                                              p=>p.ProductName);

            //foreach (var product in dictionary03)
            //{
            //    Console.WriteLine(product);
            //}

            //HashSet<Product> hashset = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();
            ////// HashSet<long> hashset02 = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet(p => p.ProductID);//InValid



            #endregion

            #region Generation Operator
            //var result   = Enumerable.Range(0, 100);//0..99
            //var result02 = Enumerable.Repeat(0, 100);//هيكرر 0 100 مره
            //var result03 = Enumerable.Repeat(new Product(), 100);//هيكرر 0 100 مره

            //  foreach (var p in result03)
            //  {
            //      Console.WriteLine(p);
            //  }

            //var arrayofproduct = Enumerable.Empty<Product>().ToArray();
            //Product[]arr =new Product[0];

            //var list           =  Enumerable.Empty<Product>().ToList();
            //List<Product> listarr = new List<Product>();


            //foreach (var p in arrayofproduct)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Set Operators

            //var seq01 = Enumerable.Range(0, 100);//0..99
            //var seq02 = Enumerable.Range(50, 100);//50..149

            //var result =seq01.Union(seq02);//0..149
            //result = seq01.Except(seq02); //0..49
            //result=seq01.Concat(seq02);//0..99 + 50..149
            //result=result.Distinct();//no duplcation
            //result=seq01.Intersect(seq02);//return what duplicated




            #endregion

            #region Quentifier Operator

            //Any()
            //Any(FUNC)
            //All()
            //SequanceEqual()

            #endregion

            #region Zipping Operators

            //string[] Names = { "tareq", "Mamdouh", "Elsabagh" };
            //int[]Numbers=Enumerable.Range(0,11).ToArray();
            //char[] Chars = { 'a', 'b', 'c', 'D' };


            //var result=Names.Zip(Numbers);

            //var result02 = Names.Zip(Numbers, (N, num) => new { index = num, names = N });

            //var result03 = Names.Zip(Numbers, Chars);


            #endregion

            #region Groupping Operators

            #region basic
            ////Query Syntax

            //var Result = from P in ProductList
            //             group P by P.Category;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Key}");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine($"                         {item2.ProductName}");
            //    }

            //}

            ////Fluent Syntax

            //var Result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Key}");
            //    foreach (var item2 in item)
            //    {


            //        Console.WriteLine($"                         {item2.ProductName}");
            //    }

            //} 
            #endregion


            #region Group by Product In Stock Based On Category that have product more than 10 Query Syntax


            ////var result = from p in ProductList
            ////             where p.UnitsInStock != 0
            ////             group p by p.Category
            ////             into Category
            ////             where Category.Count() > 10
            ////             /* select Category;
            //
            //// foreach (var item in result)
            //// {
            ////     Console.WriteLine($"{item.Key}");
            ////     foreach (var item2 in item)
            ////     {
            //
            //
            ////         Console.WriteLine($"                         {item2.ProductName}");
            ////     }
            //
            //// }*/
            ////             select new
            ////             {
            ////                 CategoryName = Category.Key,
            ////                 countofProduct = Category.Count(),
            ////             };
            //
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            #endregion


            #region Group by Product In Stock Based On Category that have product more than 10 fluent Syntax

            //var Result = ProductList.Where(p => p.UnitsInStock != 0)
            //                        .GroupBy(p => p.Category)
            //                        .Where(c => c.Count() > 10)
            //                        .Select(c => new
            //                        {
            //                            CategoryName = c.Key,
            //                            countofProduct = c.Count(),
            //                        });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion



            #endregion

            #region Partition Operators

            // Take    TakeLast    TakeWhile
            // Skip    SkipLast    SkipWhile


            #endregion

            #region Let AND Into


            //List<string> list = new List<string>() { "Tareq", "Mamdouh", "Abdalla", "Elsabagh" };

            ////Into
            //var result = from l in list
            //             select Regex.Replace(l, "[AOEUIaoeui]", string.Empty)
            //             into Vowel
            //             where Vowel.Length >3
            //             select Vowel;
            ////Let
            //var result02 = from l in list
            //               let Vowel = Regex.Replace(l, "[AOEUIaoeui]", string.Empty)
            //               where Vowel.Length > 3
            //               select Vowel;



            #endregion





        }
    }
}