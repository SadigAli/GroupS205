namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Sadig", "Aliyev", "Developer", 800));
            workers.Add(new Worker("Ramin", "Emrahli", "Developer", 1500));
            workers.Add(new Worker("Ramin", "Emrahov", "Developer", 1200));
            workers.Add(new Worker("Ruslan", "Tagizade", "Developer", 1500));
            workers.Add(new Worker("Nigar", "Qurbanov", "Developer", 2500));
            #region LINQ with query
            //var query = from worker in workers
            //            where worker.Firstname.ToLower().Contains('n') ||
            //                  worker.Lastname.ToLower().Contains('n')
            //            //where worker.Salary > 1500
            //            select (worker.Firstname, worker.Lastname, worker.Salary);
            //foreach (var q in query)
            //{
            //    Console.WriteLine(q);
            //}
            #endregion

            #region LINQ with method
            var result = workers.Find(x => x.Salary > 1000);
            var result2 = workers.FindLast(x => x.Salary > 1000);
            int index = workers.FindIndex(x => x.Firstname.Contains('s'));
            var resultAll = workers.FindAll(x => x.Salary > 1000);
            //resultAll.ForEach(x =>
            //{
            //    Console.WriteLine(x);
            //});

            //var query = workers.GroupBy(x => x.Firstname);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Key} {item.Count()}");
            //}

            //Console.WriteLine(workers.Any(x => x.Salary > 1000));

            //Console.WriteLine(workers.Count(x => x.Salary >= 1500));
            //Console.WriteLine(workers.Sum(x=>x.Salary));
            //Console.WriteLine(workers.Average(x=>x.Salary));
            //Console.WriteLine(workers.Max(x=>x.Salary));

            var workerArray = workers
                .Where(x=>x.Salary > 1000)
                .OrderByDescending(x=>x.Salary)
                .Select(x => new { x.Firstname,x.Lastname,x.Salary })
                .ToList();
            //workerArray.ForEach(person =>
            //{
            //    Console.WriteLine(person);
            //});


            foreach (var worker in workerArray)
            {
                Console.WriteLine(worker);
            }
            #endregion
        }
    }
}