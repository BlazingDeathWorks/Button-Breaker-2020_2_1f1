using UnityEngine;
using UnityEngine.UI;
public class IncomeRateUpgrade : MonoBehaviour
{
    private Button IncomeRate;
    // Start is called before the first frame update
    void Start()
    {
        IncomeRate = GetComponent<Button>();
    }

    public void UpgradeIncomeRate()
    {
        if(BronzeItem_System.Total_Clickpoints >= IncomeUpgrade.IncomeUpgrade_PointsPrice && LevelSystem_P1.Total_XP >= IncomeUpgrade.IncomeUpgrade_XPPrice)
        {
            BronzeItem_System.Total_Clickpoints -= IncomeUpgrade.IncomeUpgrade_PointsPrice;
            LevelSystem_P1.Total_XP -= IncomeUpgrade.IncomeUpgrade_XPPrice;
            IncomeSystem.Income_Rate -= 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints < IncomeUpgrade.IncomeUpgrade_PointsPrice || LevelSystem_P1.Total_XP < IncomeUpgrade.IncomeUpgrade_XPPrice || IncomeSystem.Income_Rate <= 0)
        {
            IncomeRate.interactable = false;
        }
        else
        {
            IncomeRate.interactable = true;
        }
    }
}
