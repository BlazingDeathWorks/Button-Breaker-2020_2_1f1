using UnityEngine;
using UnityEngine.UI;

public class TotalXP_Display : MonoBehaviour
{
    private Text totalxp_display;
    private LevelSystem_P1 levelsystem_p1;

    // Start is called before the first frame update
    void Start()
    {
        totalxp_display = GetComponent<Text>();
        levelsystem_p1 = GameObject.Find("XP Slider Background").GetComponent<LevelSystem_P1>();
    }

    // Update is called once per frame
    void Update()
    {
        totalxp_display.text = ("Total XP: ") + LevelSystem_P1.Total_XP.ToString();
    }
}
