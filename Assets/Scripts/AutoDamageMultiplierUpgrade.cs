using UnityEngine;
using UnityEngine.UI;
public class AutoDamageMultiplierUpgrade : MonoBehaviour
{
    private Button AutoDamageMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamageMultiplier = GetComponent<Button>();
    }

    public void UpgradeAutoDamageMultiplier()
    {
        if(BronzeItem_System.Total_Clickpoints >= AutoDamageUpgrade.AutoDamage_PointPrice && LevelSystem_P1.Total_XP >= AutoDamageUpgrade.AutoDamage_XPPrice)
        {
            BronzeItem_System.Total_Clickpoints -= AutoDamageUpgrade.AutoDamage_PointPrice;
            LevelSystem_P1.Total_XP -= AutoDamageUpgrade.AutoDamage_XPPrice;
            Edox_AutoSystem.AutoDamage_Multiplier += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints < AutoDamageUpgrade.AutoDamage_PointPrice || LevelSystem_P1.Total_XP < AutoDamageUpgrade.AutoDamage_XPPrice)
        {
            AutoDamageMultiplier.interactable = false;
        }
        else
        {
            AutoDamageMultiplier.interactable = true;
        }
    }
}
