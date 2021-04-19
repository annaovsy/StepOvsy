using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterface
{
    class UnlistedPhone
    {
        private string name;
        private string phone;
        private ICipher encryption;

        public UnlistedPhone(string name, string phone, ICipher encryption)
        {
            this.encryption = encryption;
            this.name = encryption.Encode(name);
            this.phone = encryption.Encode(phone);
        }

        public override string ToString()
        {
            return $"Имя {Name} Телефон {Phone}";
        }

        public string Name
        {
            get
            {
                return encryption.Decode(name);
            }
            set
            {
                name = encryption.Encode(value);
            }
        }
        
        public string Phone
        {
            get 
            {
                return encryption.Decode(phone);
            }
            set
            {
                phone = encryption.Encode(value);
            }
        }
    }

}
