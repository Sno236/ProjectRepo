using System;
namespace Test
{
    public class PersonHelper
    {
        public static string GetPersonName(object person)
        {
            switch (person)
            {
                case StaffMember staffMember:
                    return staffMember.Name;
                case Customer customer:
                    return customer.Name;
            }
            return null;
        }

        public static object GetPersonType(object person)
        {
            switch (person)
            {
                case StaffMember staffMember:
                    return staffMember.Type;
                case Customer customer:
                    return customer.Type;
            }
            return null;
        }
    }

    public enum CustomerType
    {
        New = 1,
        Existing = 2,
        Archived = 3
    }

    public enum StaffMemberType
    {
        New = 1,
        Existing = 2,
        Archived = 3
    }

    public interface IPerson
    {
        Guid Id { get; set; }
        short Index { get; set; }
        string GetApplicationName();
    }

    public interface ISold
    {
        void AddSoldProduct(object person);
    }

    public interface IBought
    {
        void AddBoughtProduct(object person);
    }
}