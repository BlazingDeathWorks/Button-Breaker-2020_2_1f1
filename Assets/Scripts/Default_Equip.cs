using UnityEngine;

public class Default_Equip : MonoBehaviour
{
   public void Default_EquipSwitch()
    {
        if(DefaultItem_System.Default_Acquired == true)
        {
            DefaultItem_System.Default_Equipped = !DefaultItem_System.Default_Equipped;
        }
    }
}
