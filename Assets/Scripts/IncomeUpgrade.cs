using UnityEngine;
using System.Collections;

public class IncomeUpgrade : MonoBehaviour
{
    public static int IncomeUpgrade_PointsPrice = 2500;
    public static int IncomeUpgrade_XPPrice = 10;
    public GameObject IncomeSelection;
    [HideInInspector]
    public bool IncomeSelection_Isenabled = false;

    public void UpgradeIncome()
    {
        if (BronzeItem_System.Total_Clickpoints >= IncomeUpgrade_PointsPrice && LevelSystem_P1.Total_XP >= IncomeUpgrade_XPPrice)
        {
            IncomeSelection_Isenabled = !IncomeSelection_Isenabled;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(IncomeSelection_Isenabled == false)
        {
            IncomeSelection.SetActive(false);
        }
        else if(IncomeSelection_Isenabled == true)
        {
            IncomeSelection.SetActive(true);
        }
    }

    private void OnDisable()
    {
        IncomeSelection_Isenabled = false;
    }

}
