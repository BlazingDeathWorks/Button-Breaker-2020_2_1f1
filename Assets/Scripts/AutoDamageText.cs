using UnityEngine;
using UnityEngine.UI;
public class AutoDamageText : MonoBehaviour
{
    private Text AutoDamage;
    // Start is called before the first frame update
    void Start()
    {
        AutoDamage = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        AutoDamage.text = ("Auto-Damage: ") + Edox_AutoSystem.AutoDamage;
    }
}
