using UnityEngine;

public class Gold_Equip : MonoBehaviour
{
   public void Gold_EquipSwitch()
    {
        if(GoldItem_System.Gold_Acquired == true)
        {
            GoldItem_System.Gold_Equipped = !GoldItem_System.Gold_Equipped;
        }
    }
}
