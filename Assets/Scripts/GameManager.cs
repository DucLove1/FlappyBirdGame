
using System.IO.Pipes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int Score = 0;
    public GameObject firstStart;
    public Spawner spawner;
    private void Awake()
    {

        //Pause();
        firstStart.SetActive(true);
        player.enabled = false;
        scoreText.enabled = false;
        gameOver.SetActive(false);
        playButton.SetActive(false);
        spawner.enabled = false;
     
    }
    public void Click_On_FirstStart()
    {
        firstStart.SetActive(false);
        player.enabled = true;
        scoreText.enabled = true;
        spawner.enabled = true;
    }
    public void Play()
    {
        Score = 0;
        scoreText.text = Score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Pipe_move[] pipes = FindObjectsOfType<Pipe_move>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    public void IncreaseScore()
    {
        Score++ ; 
        scoreText.text = Score.ToString();
    }

}
