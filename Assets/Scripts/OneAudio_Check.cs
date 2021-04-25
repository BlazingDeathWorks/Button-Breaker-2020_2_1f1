using UnityEngine;


public class OneAudio_Check : MonoBehaviour
{
    public static OneAudio_Check audioholder;
    [HideInInspector]
    public AudioSource AudioSource;
    void Start()
    {

        AudioSource = GetComponent<AudioSource>();
        audioholder = GetComponent<OneAudio_Check>();
    }

    private void Awake()
    {
        Countdown_System.Countdown_Current_Time = 60;
        if (audioholder != null)
        {
            Destroy(gameObject);
        }
        else if (audioholder == null)
        {
            audioholder = this;
            DontDestroyOnLoad(this);
        }
    }
    private void Update()
    {
        if (Countdown_System.Countdown_Current_Time != 0)
        {
            AudioSource.enabled = true;
        }
        if (Countdown_System.Countdown_Current_Time <= 0)
        {
            AudioSource.enabled = false;
        }   
    }
}
