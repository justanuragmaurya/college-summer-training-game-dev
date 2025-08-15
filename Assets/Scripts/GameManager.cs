using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    bool ended = false;
    [SerializeField] float restartDelay = 2f;
    [SerializeField] GameObject gameOverUI;
    public void EndGame()
    {
        if(!ended)
        {
            ended = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
