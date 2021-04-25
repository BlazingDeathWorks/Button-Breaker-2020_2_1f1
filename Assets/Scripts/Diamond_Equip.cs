using UnityEngine;

public class Diamond_Equip : MonoBehaviour
{
   public void Diamond_EquipSwitch()
    {
        if(DiamondItem_System.Diamond_Acquired == true)
        {
            DiamondItem_System.Diamond_Equipped = !DiamondItem_System.Diamond_Equipped;
        }
    }
}
