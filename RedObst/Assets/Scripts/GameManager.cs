
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;

    public GameObject tryAgainUI;

    public void CompleteLevel()
    {
        AppModel.levelCompleted = true;
        completeLevelUI.SetActive(true);
    }

    public void TryAgain()
    {
        if (!AppModel.tryAgain && !AppModel.levelCompleted)
        {
            AppModel.tryAgain = true;
            tryAgainUI.SetActive(true);
            Invoke("Restart", AppModel.restartDelay);
        }
    }

    void Restart()
    {
        AppModel.Reset();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
