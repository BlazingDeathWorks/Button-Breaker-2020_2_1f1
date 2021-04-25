using UnityEngine;
using UnityEngine.UI;

public class Bronze_Equip : MonoBehaviour
{

    public void Bronze_EquipSwitch()
    {
        if(BronzeItem_System.Bronze_Acquired == true)
        {
            BronzeItem_System.Bronze_Equipped = !BronzeItem_System.Bronze_Equipped;
        }
    }

}
