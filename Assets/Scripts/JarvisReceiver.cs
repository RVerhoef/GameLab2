using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class JarvisReceiver : MonoBehaviour
{

    private AudioSource[] songs;
    private Text currentSong;
    private Text currentTime;

	[SerializeField] private GameObject songLabel;
	[SerializeField] private GameObject timeLabel;
	[SerializeField] private GameObject HUD;

    void Start()
    {
        songs = this.GetComponents<AudioSource>();
        currentSong = songLabel.GetComponent<Text>();
        currentTime = timeLabel.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) // Begin musical commands.
        {
            MusicPlayer("stop");
            MusicPlayer("one");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MusicPlayer("stop");
            MusicPlayer("two");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MusicPlayer("stop");
            MusicPlayer("three");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MusicPlayer("stop");
            MusicPlayer("four");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MusicPlayer("stop");
            MusicPlayer("five");
        }
        else if(Input.GetKeyDown(KeyCode.P)) // End musical commands.
        {
            MusicPlayer("stop");
        }
        else if(Input.GetKeyDown(KeyCode.T)) // Time command.
        {
            DateTime now = System.DateTime.Now;
            TimeSpan cTime = now.TimeOfDay;
            string timeString = now.ToString("T");
            string[] properTime = timeString.Split(':', ' ');

            currentTime.text = properTime[0] + ":" + properTime[1] + " " + properTime[3];
        }
        else if(Input.GetKeyDown(KeyCode.Plus)) // Turn on hud.
        {
            hudOn();
			HUD.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Minus))
        {
            hudOff();
			HUD.SetActive(false);
        }
    }

    void MusicPlayer(string command)
    {
        switch(command)
        {
            case "one":
                if (songs[0] != null)
                {
                    songs[0].PlayDelayed(1.75f);
                    currentSong.text = "Current song: Hey brother.";
                }
                break;
            case "two":
                if (songs[1] != null)
                {
                    songs[1].PlayDelayed(1.75f);
                    //currentSong.text = "Current song: Primo Victoria.";
                }
                break;
            case "three":
                if (songs[2] != null)
                {
                    songs[2].PlayDelayed(1.75f);
                }
                break;
            case "four":
                if (songs[3] != null)
                {
                    songs[3].PlayDelayed(1.75f);
                }
                break;
            case "five":
                if (songs[4] != null)
                {
                    songs[4].PlayDelayed(1.75f);
                }
                break;
            case "stop":
                for (int i = songs.Length - 1; i >= 0; i--)
                {
                    songs[i].Stop();
                }
                break;
        }
    }

    void hudOn()
    {

    }

    void hudOff()
    {

    }
}
