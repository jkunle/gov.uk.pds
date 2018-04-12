using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.ExternalApiRepository
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Members
    {

        private Member memberField;

        /// <remarks/>
        public Member Member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Member
    {

        private string displayAsField;

        private string listAsField;

        private string fullTitleField;

        private object layingMinisterNameField;

        private System.DateTime dateOfBirthField;

        private object dateOfDeathField;

        private string genderField;

        private Party partyField;

        private string houseField;

        private string memberFromField;

        private System.DateTime houseStartDateField;

        private object houseEndDateField;

        private CurrentStatus currentStatusField;

        private ushort member_IdField;

        private ushort dods_IdField;

        private ushort pims_IdField;

        private byte clerks_IdField;

        /// <remarks/>
        public string DisplayAs
        {
            get
            {
                return this.displayAsField;
            }
            set
            {
                this.displayAsField = value;
            }
        }

        /// <remarks/>
        public string ListAs
        {
            get
            {
                return this.listAsField;
            }
            set
            {
                this.listAsField = value;
            }
        }

        /// <remarks/>
        public string FullTitle
        {
            get
            {
                return this.fullTitleField;
            }
            set
            {
                this.fullTitleField = value;
            }
        }

        /// <remarks/>
        public object LayingMinisterName
        {
            get
            {
                return this.layingMinisterNameField;
            }
            set
            {
                this.layingMinisterNameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DateOfDeath
        {
            get
            {
                return this.dateOfDeathField;
            }
            set
            {
                this.dateOfDeathField = value;
            }
        }

        /// <remarks/>
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public Party Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        public string House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }

        /// <remarks/>
        public string MemberFrom
        {
            get
            {
                return this.memberFromField;
            }
            set
            {
                this.memberFromField = value;
            }
        }

        /// <remarks/>
        public System.DateTime HouseStartDate
        {
            get
            {
                return this.houseStartDateField;
            }
            set
            {
                this.houseStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object HouseEndDate
        {
            get
            {
                return this.houseEndDateField;
            }
            set
            {
                this.houseEndDateField = value;
            }
        }

        /// <remarks/>
        public CurrentStatus CurrentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Member_Id
        {
            get
            {
                return this.member_IdField;
            }
            set
            {
                this.member_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Dods_Id
        {
            get
            {
                return this.dods_IdField;
            }
            set
            {
                this.dods_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Pims_Id
        {
            get
            {
                return this.pims_IdField;
            }
            set
            {
                this.pims_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Clerks_Id
        {
            get
            {
                return this.clerks_IdField;
            }
            set
            {
                this.clerks_IdField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Party
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CurrentStatus
    {

        private string nameField;

        private object reasonField;

        private System.DateTime startDateField;

        private byte idField;

        private string isActiveField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }
    }
}
