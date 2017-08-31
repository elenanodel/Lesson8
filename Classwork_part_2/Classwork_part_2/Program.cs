using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_part_2
{
    class Program
    {
        struct Human
        {
           public string name;
           public int age;
           public char sex;
        }
        static void Main(string[] args)
        {
            /*Human person;
            person.name = "Ivan";
            person.age = 20;
            person.sex = 'M';

            Console.WriteLine(person.name + " " + person.age + " " + person.sex);*/

            Human[] persons;
            persons = new Human[5];

            persons[0].name = "Ivan";
            persons[0].age = 20;
            persons[0].sex = 'M';
            persons[1].name = "Sveta";
            persons[1].age = 25;
            persons[1].sex = 'F';
            persons[2].name = "Jan";
            persons[2].age = 10;
            persons[2].sex = 'M';
            persons[3].name = "Katja";
            persons[3].age = 23;
            persons[3].sex = 'F';
            persons[4].name = "Stas";
            persons[4].age = 29;
            persons[4].sex = 'M';

            foreach (Human h in persons)
            {
                Console.WriteLine(h.name + " " + h.age + " " + h.sex);
            }
            Console.WriteLine("-----------");
            int minAge;
            int numberMinAge;
            Human tmp;

            for (int i = 0; i < persons.Length; i++)
            {
                numberMinAge = i;
                minAge = persons[i].age;
                //new minimum
                for (int j = i; j < persons.Length; j++)
                {
                    if(minAge < persons[j].age)
                    {
                        minAge = persons[j].age;
                        numberMinAge = j;
                    }
                }
                //exchange
                tmp = persons[i];
                persons[i] = persons[numberMinAge];
                persons[numberMinAge] = tmp;
            }
            foreach (Human h in persons)
            {
                Console.WriteLine(h.name + " " + h.age + " " + h.sex);
            }
        }
    }
}
