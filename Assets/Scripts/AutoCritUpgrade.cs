using UnityEngine;
using UnityEngine.UI;

public class AutoCritUpgrade : MonoBehaviour
{
    public static int AutoCritUpgradePrice = 10000;
    public static int AutoCritUpgradeBought = 0;
    public static int AutoCritEquipped = 0;
    public Text AutoCritText;
    private void Start()
    {
        AutoCritText = GetComponentInChildren<Text>();
    }

    public void UpgradeAutoCrit()
    {
        if(BronzeItem_System.Total_Clickpoints >= AutoCritUpgradePrice && AutoCritUpgradeBought == 0)
        {
            BronzeItem_System.Total_Clickpoints -= AutoCritUpgradePrice;
            AutoCritUpgradeBought = 1;
            AutoCritEquipped = 0;
        }
        else if(BronzeItem_System.Total_Clickpoints < AutoCritUpgradePrice && AutoCritUpgradeBought == 0)
        {
            Debug.Log("Not enough!!!");
        }
        if(AutoCritUpgradeBought == 1)
        {
            if(AutoCritEquipped == 0)
            {
                AutoCritEquipped = 1;
            }
            else if(AutoCritEquipped == 1)
            {
                AutoCritEquipped = 0;
            }
        }
    }

    void Update()
    {
        if (AutoCritUpgradeBought == 0)
        {
            AutoCritText.text = ("Auto Critical Upgrade P10000");
        }
        if (AutoCritEquipped == 1)
        {
            AutoCritText.text = ("Unequip");
        }
        else if(AutoCritEquipped == 0 && AutoCritUpgradeBought == 1)
        {
            AutoCritText.text = ("Equip");
        }
    }
}
