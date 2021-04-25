using UnityEngine;
using UnityEngine.UI;
public class CriticalHit_System : MonoBehaviour
{
    public Image CritImage;
    public Text CritText;
    public static int CriticalHitChance;

    // Start is called before the first frame update
    void Start()
    {
        CritImage = GameObject.Find("CritButton").GetComponent<Image>();
        CritText = GameObject.Find("CritText").GetComponent<Text>();
        CritImage.enabled = false;
        CritText.enabled = false;
    }

    public void DrawaCritical()
    {
        CriticalHitChance = Random.Range(1, 21);
    }
}
