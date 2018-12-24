using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_12_2018
{
    class Methods
    {
        public static object Locker = new object();

       
        public static async Task writeToDB(Stack<string> stack)
        {
            
            Task task1 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        string sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        Console.WriteLine("inDBWriter 1 -> " + resultI);

                        conn.Close();
                    }

                }

            });
            Task task4 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        string sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        Console.WriteLine("inDBWriter 4 -> "+resultI);
                        conn.Close();
                    }

                }
                

            });
            Task task5 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        string sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        Console.WriteLine("inDBWriter 5 -> " + resultI);

                        conn.Close();
                    }

                }

            });
            Task task2 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        string sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        Console.WriteLine("inDBWriter 2 -> " + resultI);

                        conn.Close();
                    }

                }

            });
            Task task3 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        string sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        Console.WriteLine("inDBWriter 3 -> " + resultI);

                        conn.Close();
                    }

                }

            });

            Task.WaitAll(task1,task2,task3,task4,task5); 

        }
    }
}


