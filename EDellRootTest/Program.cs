namespace EDellRootTest
{
    using System;
    using System.Security.Principal;

    class Program
    {
        static void Main(string[] args)
        {
            var id = WindowsIdentity.GetCurrent();
            var isAdmin = id != null && id.Owner != id.User;

            Console.WriteLine(isAdmin);
        }
    }
}