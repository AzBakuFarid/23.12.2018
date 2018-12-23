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

        public static async Task<Stack<string>> readFromFileAsync(string filename)
        {
            Stack<string> list = new Stack<string>();
            await Task.Run(() =>
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Push(line);
                    }
                }
            });
            return list;



        }
        public static async Task writeToDB(Stack<string> stack)
        {
            string sb = null;
            Task task1 = Task.Run(() =>
            {
                if (stack.Count > 0)
                {
                    lock (Locker)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=CACR12\SERVER2018;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
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
                        SqlConnection conn = new SqlConnection(@"Data Source=CACR12\SERVER2018;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
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
                        SqlConnection conn = new SqlConnection(@"Data Source=CACR12\SERVER2018;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
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
                        SqlConnection conn = new SqlConnection(@"Data Source=CACR12\SERVER2018;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
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
                        SqlConnection conn = new SqlConnection(@"Data Source=CACR12\SERVER2018;User id=sa; Password=1Qaz2wsx; Initial Catalog=items_23/12/2018");
                        conn.Open();
                        sb = $"insert into items (items) values ('{stack.Pop()}'); ";
                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                        var resultI = cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }

            });

            Task.WaitAll(task1,task2,task3,task4,task5); 

        }
    }
}


