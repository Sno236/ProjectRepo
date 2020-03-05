using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main()
        {
            //Here is a small project which prints out a list of customers to the Output window.
            //It's the beginning of a sales system which stores the details of customers and staff members.
            //This project will compile and run but the code is in need of refactoring because breaches the principles of Clean Code and SOLID.
            //Please read, run and experiment with it as much as you require and refactor it to the best of your ability to make it less esoteric and more maintainable.
            //You can change any of the code in this project apart from the section marked 'Code that must not change'
            
            //N.B. The output of the code must not change

            var customers = new List<Customer>();

            var defaultCustomer = Customer.DefaultCustomer;
            customers.Add(defaultCustomer);

            var c1 = new Customer(customers, "Emma", CustomerType.New);
            customers.Add(c1);

            var c2 = new Customer(customers, "James", CustomerType.Existing);
            customers.Add(c2);

            var c3 = new Customer(customers, "Ricardo", CustomerType.New);
            customers.Add(c3);

            var c4 = new Customer(customers, "Paul", CustomerType.Archived);
            customers.Add(c4);

            var staffMembers = new List<StaffMember>();

            var defaultStaffMember = StaffMember.DefaultStaffMember;
            staffMembers.Add(defaultStaffMember);

            var sm1 = new StaffMember(staffMembers, "Dave", StaffMemberType.Existing);
            staffMembers.Add(sm1);

            var sm2 = new StaffMember(staffMembers, "Penny", StaffMemberType.Archived);
            staffMembers.Add(sm2);

            var sm3 = new StaffMember(staffMembers, "Dan", StaffMemberType.New);
            staffMembers.Add(sm3);

            var sm4 = new StaffMember(staffMembers, "Mark", StaffMemberType.Existing);
            staffMembers.Add(sm4);

            Debug.Print($"\r\n{defaultCustomer.GetApplicationName()}:");
            
            /////////////////////////////
            //Code that must not change//
            /////////////////////////////
            foreach (var customer in customers)
            {
                Debug.Print($"Customer name: {PersonHelper.GetPersonName(customer)} - List Order: {customer.Index} - Customer Type: {PersonHelper.GetPersonType(customer)}");
            }

            foreach (var staffMember in staffMembers)
            {
                Debug.Print($"Staff Member name: {PersonHelper.GetPersonName(staffMember)} - List Order: {staffMember.Index} - Staff Member Type: {PersonHelper.GetPersonType(staffMember)}");
            }
            /////////////////////////////////
            //end code that must not change//
            /////////////////////////////////
        }
    }
}
