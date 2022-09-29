using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score: " + SplitManager.Instance.victorName + " : " + SplitManager.Instance.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
