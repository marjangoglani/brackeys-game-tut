using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay;
    public GameObject completeLevelUI;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (gameHasEnded == true)
        {
            Invoke("restart", restartDelay);  // waits 2nd param amount before calling the function (1st param)
        }

    }

    void restart ()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
