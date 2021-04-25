using UnityEngine;
using UnityEngine.UI;

public class CourseNumber_Script : MonoBehaviour
{
    private Text CourseNumber_Text;
    void Start()
    {
        CourseNumber_Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CourseNumber_Text.text = ("Course: ") + PlayerPrefs.GetInt("SavedScene").ToString();
    }
}
