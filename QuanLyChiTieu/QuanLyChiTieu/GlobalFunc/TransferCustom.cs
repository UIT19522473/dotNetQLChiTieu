using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu.GlobalFunc
{
    public class TransferCustom
    {
        private decimal money;
        private int idCate;

        public decimal Money { get => money; set => money = value; }
        public int IdCate { get => idCate; set => idCate = value; }

        public TransferCustom()
        {
        }

        public TransferCustom(decimal money, int idCate)
        {
            Money = money;
            IdCate = idCate;
        }
        
    }
}
