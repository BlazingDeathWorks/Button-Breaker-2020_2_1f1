using UnityEngine;
using UnityEngine.UI;
public class IncomeEarningsText : MonoBehaviour
{
    private Text IncomeEarnings_Text;
    // Start is called before the first frame update
    void Start()
    {
        IncomeEarnings_Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        IncomeEarnings_Text.text = ("Income Earnings: ") + IncomeSystem.Income_Earnings;
    }
}
