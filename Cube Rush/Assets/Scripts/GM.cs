
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public bool gamehasended = false;
    public float restartDelay = 1f;
    public GameObject LevelCompleteUI;
    public void EndGame()
    {   if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }
}
