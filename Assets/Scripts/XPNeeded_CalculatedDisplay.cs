using UnityEngine;
using UnityEngine.UI;

public class XPNeeded_CalculatedDisplay : MonoBehaviour
{
    private Text xpneeded_calculatedDisplay;
    private LevelSystem_P1 levelsystem_P1;
    // Start is called before the first frame update
    void Start()
    {
        xpneeded_calculatedDisplay = GetComponent<Text>();
        levelsystem_P1 = GameObject.Find("XP Slider Background").GetComponent<LevelSystem_P1>();


    }

    // Update is called once per frame
    void Update()
    {
        xpneeded_calculatedDisplay.text = ("XP Left Until Next Level: ") + LevelSystem_P1.XP_Needed_Equation.ToString();
    }
}
