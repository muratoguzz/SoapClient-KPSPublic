using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{Email = "muratouz95@gmail.com", FirstName = "Murat", LastName = "Oğuz", DateOfBirth = new DateTime(1995,11,6), TcNo = "63664134924"});
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
