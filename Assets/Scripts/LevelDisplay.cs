using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    private Text levdisplay;
    [SerializeField]
    private LevelSystem_P1 levelsystem_P1;


    void Start()
    {
        levdisplay = GetComponent<Text>();
        levelsystem_P1 = GameObject.Find("XP Slider Background").GetComponent<LevelSystem_P1>();
    }

    void Update()
    {
        levdisplay.text = "Level: " + LevelSystem_P1.Level.ToString();
    }
}
