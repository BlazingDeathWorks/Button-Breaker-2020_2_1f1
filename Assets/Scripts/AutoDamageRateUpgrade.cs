using UnityEngine;
using UnityEngine.UI;
public class AutoDamageRateUpgrade : MonoBehaviour
{
    private Button AutoDamageRate;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamageRate = GetComponent<Button>();
    }

    public void UpgradeAutoDamageRate()
    {
        if(BronzeItem_System.Total_Clickpoints >= AutoDamageUpgrade.AutoDamage_PointPrice && LevelSystem_P1.Total_XP >= AutoDamageUpgrade.AutoDamage_XPPrice)
        {
            BronzeItem_System.Total_Clickpoints -= AutoDamageUpgrade.AutoDamage_PointPrice;
            LevelSystem_P1.Total_XP -= AutoDamageUpgrade.AutoDamage_XPPrice;
            Edox_AutoSystem.AutoDamage_Rate -= 1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints < AutoDamageUpgrade.AutoDamage_PointPrice || LevelSystem_P1.Total_XP < AutoDamageUpgrade.AutoDamage_XPPrice || Edox_AutoSystem.AutoDamage_Rate <= 0.2)
        {
            AutoDamageRate.interactable = false;
        }
        else
        {
            AutoDamageRate.interactable = true;
        }
    }
}
