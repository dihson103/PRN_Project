using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PresentationLayer;
using System.Data.Common;

namespace StudentManager
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(Login.Instance);
        }
    }
}