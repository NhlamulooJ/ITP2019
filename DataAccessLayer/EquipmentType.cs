using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EquipmentType
    {
        public int EquipmentCode { get; set; }
        public string equipmentTypeDesc { get; set; }

        //Constractor for Insert
        public EquipmentType(string EquipmentTypeDesc)
        {
            equipmentTypeDesc = EquipmentTypeDesc;
        }

        //Constructor for Update
        public EquipmentType(string EquipmentTypeDesc, int equipmentCode)
        {
            EquipmentCode = equipmentCode;
            equipmentTypeDesc = EquipmentTypeDesc;
        }
        public EquipmentType( int equipmentCode)
        {
            EquipmentCode = equipmentCode;
            
        }
    }
}
