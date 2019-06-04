using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercitiul1.Classes
{
    class ReadText
    {
        public static void ReadAllText(string path)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(File.ReadAllText(path));
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system - defined maximum length.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }

        }
    }
}
