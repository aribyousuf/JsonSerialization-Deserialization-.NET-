using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.ID = 1;
            std.Name = "Arib";
            std.Address = "Karachi";

            //Serialization
            JsonSerializationAndDeserialization j = new JsonSerializationAndDeserialization();
            j.Serialize(std);

            //Deserialization
            dynamic sub = @"{
                            'ID': '1',  
                            'Name': 'Arib',  
                            'Address': 'Karachi'  
                        }"; ///Created Json Data
            j.Deserialization(std, sub);

            
        }
    }


    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }


    class JsonSerializationAndDeserialization {

        public void Serialize(Student student)
        {
            string jsonData = JsonConvert.SerializeObject(student);
            Console.WriteLine(jsonData);

        }

        public void Deserialization(Student student, dynamic value)
        {
            student = JsonConvert.DeserializeObject<Student>(value);
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Address);
        }

    }


}
