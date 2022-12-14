/* 
Optional & Named Arguments


You are making your own social network application. 
The users are able to set their names, their ages, and their preferred language.
If user doesn't set the language, English will be set as default.

Complete the method with name, age and language parameters and take into account the default English option
for language in order to correctly output the information about the provided 2 users.
You need to make the language parameter optional and specify the required default value for it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class optNamedArgs
    {
        static void Main(string[] args)
        {
            Settings("James", 25, "Spanish");
            Settings("Tom", 36);
        }
        //complete the method
        static void Settings(string name, int age, string lang= "English")
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Language: " + lang);
        }
    }
}
