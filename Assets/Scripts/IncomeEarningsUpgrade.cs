using UnityEngine;
using UnityEngine.UI;
public class IncomeEarningsUpgrade : MonoBehaviour
{
    private Button IncomeEarningsButton;
    // Start is called before the first frame update
    void Start()
    {
        IncomeEarningsButton = GetComponent<Button>();
    }

    private void Update()
    {
        if (BronzeItem_System.Total_Clickpoints < IncomeUpgrade.IncomeUpgrade_PointsPrice || LevelSystem_P1.Total_XP < IncomeUpgrade.IncomeUpgrade_XPPrice)
        {
            IncomeEarningsButton.interactable = false;
        }
        else
        {
            IncomeEarningsButton.interactable = true;
        }
    }

    public void UpgradeIncomeEarnings()
    {
        if(BronzeItem_System.Total_Clickpoints >= IncomeUpgrade.IncomeUpgrade_PointsPrice && LevelSystem_P1.Total_XP >= IncomeUpgrade.IncomeUpgrade_XPPrice)
        {
            BronzeItem_System.Total_Clickpoints -= IncomeUpgrade.IncomeUpgrade_PointsPrice;
            LevelSystem_P1.Total_XP -= IncomeUpgrade.IncomeUpgrade_XPPrice;
            IncomeSystem.Income_Earnings += 5;
        }
    }
}
