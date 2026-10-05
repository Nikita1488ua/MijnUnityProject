using UnityEngine;

public class MuziekPlayer : MonoBehaviour
{
    [Header("Player info")]
    public string songName = "Ramstein - Du hast";
    public string currentSong = "Ramstein - Du hast";
    public double volume = 0.6;
    public bool isPlaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Dit is yuow muziek player!");
        Debug.Log("Controls: P = play/stop | W = +volume | W = -volume | I = show player info");
        ShowMusicInfo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        { 
            play();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            plusvolume();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            minvolume();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            ShowMusicInfo();
        }
    }

    void plusvolume()
    {
        volume += 0.1;
        if (volume > 1) volume = 1;
        Debug.Log("Volume: " + volume);
    }

    void minvolume()
    {
        volume -= 0.1;
        if (volume < 0) volume = 0;
        Debug.Log("Volume: " + volume);
    }

    void play()
    {
        if (isPlaying == false)
        {
            isPlaying = true;
            Debug.Log("Playing song: " + songName);
        }
        else if (isPlaying == true)
        {
            isPlaying = false;
            Debug.Log("Playing stopped");
        }
    }

    void ShowMusicInfo()
    {
        Debug.Log("===== Player info =====");
        Debug.Log("Playing song: " + songName);
        Debug.Log("Current song: " +  currentSong);
        Debug.Log("Volume set to: " + volume);
        Debug.Log("Is playing: " +  isPlaying);
        Debug.Log("=======================");
    }
}