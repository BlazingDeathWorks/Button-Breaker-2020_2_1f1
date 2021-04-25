using UnityEngine;
using UnityEngine.UI;
public class AutoDamagePlusTen : MonoBehaviour
{
    private Button AutoDamage;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamage = GetComponent<Button>();
    }

    public void UpgradeAutoDamage()
    {
        if(BronzeItem_System.Total_Clickpoints >= AutoDamageUpgrade.AutoDamage_PointPrice && LevelSystem_P1.Total_XP >= AutoDamageUpgrade.AutoDamage_XPPrice)
        {
            BronzeItem_System.Total_Clickpoints -= AutoDamageUpgrade.AutoDamage_PointPrice;
            LevelSystem_P1.Total_XP -= AutoDamageUpgrade.AutoDamage_XPPrice;
            Edox_AutoSystem.AutoDamage += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints < AutoDamageUpgrade.AutoDamage_PointPrice || LevelSystem_P1.Total_XP < AutoDamageUpgrade.AutoDamage_XPPrice)
        {
            AutoDamage.interactable = false;
        }
        else
        {
            AutoDamage.interactable = true;
        }
    }
}
