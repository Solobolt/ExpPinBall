using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

    public AudioSource sfxSource;

    public AudioClip[] bigExplotionSound;

    public AudioClip[] bumperExplotionSound;

    public AudioClip[] ballLauncherSound;

    public AudioClip[] paddleHitSound;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    //Playes the big explotion
    public void playBigExplotion()
    {
        sfxSource.PlayOneShot(bigExplotionSound[Random.Range(0,bigExplotionSound.Length)]);
    }

    //playes the bumper explotion
    public void playBumperExplotion()
    {
        sfxSource.PlayOneShot(bumperExplotionSound[Random.Range(0, bumperExplotionSound.Length)]);
    }

    //playes the launcher sound
    public void playBallLauncherSound()
    {
        sfxSource.PlayOneShot(ballLauncherSound[Random.Range(0, ballLauncherSound.Length)]);
    }

    //playes the paddles sound
    public void playPaddleHitSound()
    {
        sfxSource.PlayOneShot(paddleHitSound[Random.Range(0, paddleHitSound.Length)]);
    }

}
