using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Test
{
    public class StaffMember : IPerson, ISold
    {
        public static StaffMember DefaultStaffMember = new StaffMember(null, "Default Staff Member");

        public StaffMember(IEnumerable<StaffMember> parentCollection, string name = null, StaffMemberType type = StaffMemberType.New)
        {
            Id = Guid.NewGuid();
            Index = (short)(parentCollection?.Count() ?? 0);
            Name = name;
            Type = type;
        }

        #region Fields

        private StaffMemberType _type;

        #endregion

        #region Properties

        public string Name { get; set; }

        public StaffMemberType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnType_Changed();
            }
        }

        public Guid Id { get; set; }
        public short Index { get; set; }

        public List<object> SoldProducts { get; set; }

        public string GetApplicationName()
        {
            return "";
        }

        public void AddSoldProduct(object person)
        {
            SoldProducts.Add(person);
        }

        public void OnType_Changed()
        {
            Debug.Print($"{nameof(StaffMember)} Type changed to {Type}");
        }
        #endregion
    }
}
