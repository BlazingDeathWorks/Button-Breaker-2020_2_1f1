using UnityEngine;
using UnityEngine.UI;

public class AutoDamageRateText : MonoBehaviour
{
    private Text AutoDamageRate;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamageRate = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        AutoDamageRate.text = ("Auto-Damage Rate: ") + Edox_AutoSystem.AutoDamage_Rate;
        if(Edox_AutoSystem.AutoDamage_Rate <= 0)
        {
            Edox_AutoSystem.AutoDamage_Rate = 0.2f;
            AutoDamageRate.text = ("Auto-Damage Rate: ") + Edox_AutoSystem.AutoDamage_Rate;
        }
    }
}
