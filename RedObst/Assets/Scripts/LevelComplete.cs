using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        AppModel.level++;
        AppModel.forwardForce += AppModel.forceIncrement;
        AppModel.levelCompleted = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
