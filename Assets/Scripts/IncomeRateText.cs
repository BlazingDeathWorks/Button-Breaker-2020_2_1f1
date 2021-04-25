using UnityEngine;
using UnityEngine.UI;
public class IncomeRateText : MonoBehaviour
{
    private Text IncomeRate_Text;
    // Start is called before the first frame update
    void Start()
    {
        IncomeRate_Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        IncomeRate_Text.text = ("Income Rate: ") + IncomeSystem.Income_Rate;
        if(IncomeSystem.Income_Rate <= 0)
        {
            IncomeSystem.Income_Rate = 0.2f;
            IncomeRate_Text.text = ("Income Rate: ") + IncomeSystem.Income_Rate;
        }
    }
}
