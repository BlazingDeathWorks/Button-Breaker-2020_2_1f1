using UnityEngine;
using UnityEngine.UI;
public class AutoDamageMultiplierText : MonoBehaviour
{
    private Text AutoDamageMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamageMultiplier = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        AutoDamageMultiplier.text = ("Auto-Damage Multiplier: ") + Edox_AutoSystem.AutoDamage_Multiplier;
    }
}
