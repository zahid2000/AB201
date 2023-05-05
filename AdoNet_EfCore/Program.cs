using AdoNet_EfCore.Constants;
using AdoNet_EfCore.DAL;
using AdoNet_EfCore.Models;
using System.Data;
using System.Data.SqlClient;

//GetName(4);
//InsertStudent("Muslum", "Misirli");
//GetAllStudents();
//Console.ReadLine();
async void GetName(int id)
{
    using (SqlConnection conn = new SqlConnection(Urls.connectionString))
    {
        conn.Open();
        string commandtext = "select name From OldStudents where id=@id";
        using (SqlCommand cmd = new SqlCommand(commandtext, conn))
        {
            cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
            //cmd.Parameters.AddWithValue("id", id);
            string name = (string)(await cmd.ExecuteScalarAsync());
            Console.WriteLine(name);
        }

    }
}
async void InsertStudent(string name, string surname)
{
    using (SqlConnection conn = new SqlConnection(Urls.connectionString))
    {
        conn.Open();
        string commandtext = "insert into OldStudents values(@name,@surname)";
        using (SqlCommand cmd = new SqlCommand(commandtext, conn))
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                CreateSqlparametr("name",SqlDbType.NVarChar,name),
                CreateSqlparametr("surname",SqlDbType.NVarChar,surname)

            };
            cmd.Parameters.AddRange(parms);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                await Console.Out.WriteLineAsync("Ok");
            }
            else
            {
                await Console.Out.WriteLineAsync("Not OK");
            }
        }

    }
}
async void GetAllStudents()
{
    using (SqlConnection conn = new SqlConnection(Urls.connectionString))
    {
        conn.Open();
        string commandtext = "Select * from OldStudents";
        using (SqlCommand cmd = new SqlCommand(commandtext, conn))
        {
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");
                        //Console.WriteLine($"{reader["Id"]} {reader["Surname"]} {reader["Name"]} ");
                        //Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)} {reader.GetString(2)}");
                        Console.WriteLine($"{reader.GetInt32("Id")} {reader.GetString("Name")} {reader.GetString("Surname")}");

                    }
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
            }
        }

    }
}
SqlParameter CreateSqlparametr(string name, SqlDbType sqlDbType, object newObj)
{
    SqlParameter sqlParameter = new SqlParameter(name,sqlDbType);
    sqlParameter.Value = newObj;
    return sqlParameter;
}


Person person = new Person
{
    Name = "Hakim",
    Surname = "Hebibli",
    Age = 20,
    FatherName = "Azer"
};
//InsertPersonWithEf(person);
//GetAllPersonWitEf();
//GetPersonByIdWitEf(1);

//void GetAllPersonWitEf()
//{
//    using (AppDbContext context = new AppDbContext())
//    {
//       List<Person> persons= context.Persons.ToList();
//        foreach (var person in persons)
//        {
//            Console.WriteLine($"{person.Name} {person.Surname} {person.FatherName} {person.Age}");
//        }
//    }
//}
//void GetPersonByIdWitEf(int id)
//{
//    using (AppDbContext context = new AppDbContext())
//    {
//        Person person = context.Persons.Find(id);
//        //Person person = context.Persons.FirstOrDefault(x => x.Name == "Eli");

//        Console.WriteLine($"{person.Name} {person.Surname} {person.FatherName} {person.Age}");
       
//    }
//}

//void InsertPersonWithEf(Person person)
//{
//    using (AppDbContext context=new AppDbContext())
//    {

//        context.Persons.Add(person);
//     context.SaveChanges();
//    }
//    Console.WriteLine("Ok");
//}


