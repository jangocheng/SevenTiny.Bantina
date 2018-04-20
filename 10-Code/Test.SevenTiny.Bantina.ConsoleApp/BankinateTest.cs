﻿using SevenTiny.Bantina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.SevenTiny.Bantina.Model;
using static Newtonsoft.Json.JsonConvert;

namespace Test.SevenTiny.Bantina.ConsoleApp
{
    public class BankinateTest
    {
        public static void Test()
        {
            MySqlDbContextTest();
        }

        private static void MongoDbTest()
        {
            using (MongoTestDbContext db = new MongoTestDbContext())
            {
                //db.Add<Grade>(new Grade { Name = "Three", GradeId = 9 });

                IList<Grade> dbs = db.QueryList<Grade>(t => true);
                Console.WriteLine(SerializeObject(dbs));
            }
        }

        private static void MySqlDbContextTest()
        {
           var result1= StopwatchHelper.Caculate(100,() =>
            {
                using (MySqlTestDbContext db = new MySqlTestDbContext())
                {
                    //for (int i = 1; i < 4; i++)
                    //{
                    //    Student stu = new Student();
                    //    stu.Age = i;
                    //    stu.Name = $"monky-{i}";
                    //    stu.GradeId = i;
                    //    db.Add(stu);
                    //}

                    //var result = db.QueryOne<Student>(t => t.Name.Equals("monky-6"));
                    //result.Name = "monky-6";
                    //result.Age = 6;
                    //db.Update(t => t.Id == 109, result);

                    //var result = db.QueryCount<Student>(t => t.Name.Contains("1"));
                    //var result = db.QueryListPaging<Student>(3,3,t=>t.Age,t => t.Name.EndsWith("3"),true);

                    //var grades = db.QueryList<Grade2>(t => true);

                    var student = db.QueryOne<Student>(t => true);
                    Console.WriteLine(student.Name);
                }
            });
            Console.WriteLine();
            Console.WriteLine($"QueryOne 100 sec：{result1.TotalMilliseconds} ms");
        }
    }
}
