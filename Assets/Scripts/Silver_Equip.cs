using UnityEngine;
using UnityEngine.UI;

public class Silver_Equip : MonoBehaviour
{
    public void Silver_EquipSwitch()
    {
        if(SilverItem_System.Silver_Acquired == true)
        {
            SilverItem_System.Silver_Equipped = !SilverItem_System.Silver_Equipped;
        }
    }
}
