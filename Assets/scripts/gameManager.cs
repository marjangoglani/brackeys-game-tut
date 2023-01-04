using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay;

    public void endGame()
    {
        if (gameHasEnded == true)
        {
            Debug.Log("GAME OVER");
            Invoke("restart", restartDelay);  // waits 2nd param amount before calling the function (1st param)
        }

    }

    void restart ()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
