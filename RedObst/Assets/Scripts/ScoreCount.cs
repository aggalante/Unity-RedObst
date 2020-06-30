using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Transform player;

    public Text scoreText;

    public Text levelText;

    void Start()
    {
        levelText.text = string.Format("LEVEL 0{0}", AppModel.level);

    }

    // Update is called once per frame
    void Update()
    {

        if (!AppModel.levelCompleted)
            scoreText.text = player.position.z.ToString("0");
    }
}
