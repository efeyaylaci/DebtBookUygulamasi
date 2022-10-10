using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeresiyeUygulması
{
    public class Storage
    {
        private Storage() { }

        private static readonly Lazy<Storage> instance = new Lazy<Storage>(() => new Storage());
        public static Storage Instance { get { return instance.Value; } }


        //LOGINS
        public int loginID { get; set; }

        //Row Data
        public string Id { get; set; }
        public string açıklama { get; set; }
        public string miktar { get; set; }
        public string işlemTürü{ get; set; }
        public string birimTipi { get; set; }
        public string alakalı { get; set; }
        public string miktarÇeşidi { get; set; }







        public string loginName { get; set; }
        public string loginPassword { get; set; }

        //DatabaseFinal
        public string isim { get; set; }
        public int toplam_tutar { get; set; }


    }
}
