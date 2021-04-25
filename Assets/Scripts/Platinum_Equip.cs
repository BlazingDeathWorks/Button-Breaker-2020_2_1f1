using UnityEngine;

public class Platinum_Equip : MonoBehaviour
{
    public void Platinum_EquipSwitch()
    {
        if(PlatinumItem_System.Platinum_Acquired == true)
        {
            PlatinumItem_System.Platinum_Equipped = !PlatinumItem_System.Platinum_Equipped;
        }
    }
}
