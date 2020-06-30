using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public Text levelText;

    // Update is called once per frame
    void Update()
    {
        levelText.text = string.Format("LEVEL 0{0}", AppModel.level);
    }
}
