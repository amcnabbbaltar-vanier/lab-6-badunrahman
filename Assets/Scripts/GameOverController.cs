using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score:" + GameManager.Instance.score.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
