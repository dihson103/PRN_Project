using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace StudentManager
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new Schedule());
        }
    }
}