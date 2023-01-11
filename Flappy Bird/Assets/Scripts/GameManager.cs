using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public Player player;
    private Spawner spawner;
    private GameObject[] pipes;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    public int score { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();

        Pause();
    }


    public void Play()
    {
        pipes = GameObject.FindGameObjectsWithTag("Pipe");
        for (var i = 0; i < pipes.Length; i++)
            Destroy(pipes[i]);

        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);
        

        

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
