namespace LINQActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadData();
            Console.WriteLine("=====Age Between ===============");
            foreach (string name in AgeBetween())
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("=====Group by Year===============");

            GroupedByYear();
            Console.WriteLine("========Order by age============");
            foreach (Student st in OrderByAge())
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("======== Female students in year 3 ============");
            foreach (Student st in Year3Females())
            {
                Console.WriteLine(st.ToString());
            }

            Console.WriteLine("======Number of Male students ==============");
           
                Console.WriteLine($"There are {MaleCount()} Male students");

            Console.WriteLine("========Oldest students============");

            Console.WriteLine($"Oldest student is {OldStudent().Firstname}");


        }

        static void LoadData()
        {
            Random r = new Random();
            DataStore.stList.Add(new(123, "Kabelo", "Tlhape", 20, 'M', r.Next(1,3)));
            DataStore.stList.Add(new(124, "Roger", "Federer", 25, 'M', r.Next(1, 3)));
            DataStore.stList.Add(new(125, "Bianca", "Van Royen", 21, 'F', r.Next(1, 3)));
            DataStore.stList.Add(new(125, "Serena", "Williams", 18, 'F', r.Next(1, 3)));
            DataStore.stList.Add(new(126, "Novak", "Djokovic", 29, 'M', r.Next(1, 3)));
            DataStore.stList.Add(new(127, "Teko", "Modise", 20, 'M', r.Next(1, 3)));
            DataStore.stList.Add(new(128, "Jessica", "Smith", 20, 'F', r.Next(1, 3)));
            DataStore.stList.Add(new(129, "Carol", "Van Wyk", 23, 'F', r.Next(1, 3)));
            DataStore.stList.Add(new(110, "Leo", "Du Plooy", 20, 'M', r.Next(1, 3)));
            DataStore.stList.Add(new(111, "Rene", "Van Eck", 20, 'F', r.Next(1, 3)));

        }

        

        static List<string> AgeBetween() =>
        
           (from st in DataStore.stList
                    where st.Age >= 18 && st.Age <= 21
                    select st.Lastname).ToList();
        static void GroupedByYear()
        {
            var stGroupedByYear = (from st in DataStore.stList
                                  group st by st.YearOfStudy into sg
                                  orderby sg.Key
                                  select new { sg.Key, sg });
            foreach (var group in stGroupedByYear)
            {
                Console.WriteLine($"Year {group.Key}");
                foreach (var st in group.sg)
                {
                    Console.WriteLine(st.Firstname);
                }
            }
        }

        static List<Student> OrderByAge()
        {
            return (from st in DataStore.stList
                    orderby st.Age, st.YearOfStudy
                    select st).ToList();

        }

        static List<Student> Year3Females()
        {
            return (from st in DataStore.stList
                    where st.Gender.Equals('F') && st.YearOfStudy == 3
                    select st).ToList();

        }

        static int MaleCount()
        {
            return (from st in DataStore.stList
                    where st.Gender.Equals('M') && st.YearOfStudy == 2
                    select st).Count();

        }
        static Student OldStudent()
        {
            List<int> ages = (from st in DataStore.stList
                             select st.Age).ToList();
            int maxAge = ages.Max();

            return (Student)(from st in DataStore.stList
                    where st.Age == maxAge
                    select st);
                  

        }

    }
}