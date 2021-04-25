using UnityEngine;
using System.Collections;

public class AutoDamageUpgrade : MonoBehaviour
{
    public static int AutoDamage_PointPrice = 2500;
    public static int AutoDamage_XPPrice = 50;
    [HideInInspector]
    public bool AutoDamageSelection_Isenabled = false;
    public GameObject AutoDamageSelection;

    public void UpgradeAutoDamage()
    {
        if(BronzeItem_System.Total_Clickpoints >= AutoDamage_PointPrice && LevelSystem_P1.Total_XP >= AutoDamage_XPPrice)
        {
            AutoDamageSelection_Isenabled = !AutoDamageSelection_Isenabled;
        }

    }

    void Update()
    {
        if(AutoDamageSelection_Isenabled == false)
        { 
            AutoDamageSelection.SetActive(false);
        }
        else if(AutoDamageSelection_Isenabled == true)
        {
            AutoDamageSelection.SetActive(true);
        }
    }

    private void OnDisable()
    {
        AutoDamageSelection_Isenabled = false;
    }

}
