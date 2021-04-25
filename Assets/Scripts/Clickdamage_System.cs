using UnityEngine;
public class Clickdamage_System : MonoBehaviour
{
    void Update()
    {
        if(DefaultItem_System.Default_Equipped == true)
        {
            BronzeItem_System.Bronze_Equipped = false;
            SilverItem_System.Silver_Equipped = false;
            GoldItem_System.Gold_Equipped = false;
            PlatinumItem_System.Platinum_Equipped = false;
            DiamondItem_System.Diamond_Equipped = false;
        }
        else if(BronzeItem_System.Bronze_Equipped == true)
        {
            SilverItem_System.Silver_Equipped = false;
            GoldItem_System.Gold_Equipped = false;
            PlatinumItem_System.Platinum_Equipped = false;
            DiamondItem_System.Diamond_Equipped = false;
            DefaultItem_System.Default_Equipped = false;
        }
        else if(SilverItem_System.Silver_Equipped == true)
        {
            BronzeItem_System.Bronze_Equipped = false;
            GoldItem_System.Gold_Equipped = false;
            PlatinumItem_System.Platinum_Equipped = false;
            DiamondItem_System.Diamond_Equipped = false;
            DefaultItem_System.Default_Equipped = false;
        }
        else if(GoldItem_System.Gold_Equipped == true)
        {
            BronzeItem_System.Bronze_Equipped = false;
            SilverItem_System.Silver_Equipped = false;
            PlatinumItem_System.Platinum_Equipped = false;
            DiamondItem_System.Diamond_Equipped = false;
            DefaultItem_System.Default_Equipped = false;
        }
        else if(PlatinumItem_System.Platinum_Equipped == true)
        {
            BronzeItem_System.Bronze_Equipped = false;
            SilverItem_System.Silver_Equipped = false;
            GoldItem_System.Gold_Equipped = false;
            DiamondItem_System.Diamond_Equipped = false;
            DefaultItem_System.Default_Equipped = false;
        }
        if(DiamondItem_System.Diamond_Equipped == true)
        {
            BronzeItem_System.Bronze_Equipped = false;
            SilverItem_System.Silver_Equipped = false;
            GoldItem_System.Gold_Equipped = false;
            PlatinumItem_System.Platinum_Equipped = false;
            DefaultItem_System.Default_Equipped = false;
        }
    }
}
