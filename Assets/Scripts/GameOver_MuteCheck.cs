using UnityEngine;

public class GameOver_MuteCheck : MonoBehaviour
{
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Countdown_System.Countdown_Current_Time == 0)
        {
            audiosource.mute = true;
        }
    }
}
