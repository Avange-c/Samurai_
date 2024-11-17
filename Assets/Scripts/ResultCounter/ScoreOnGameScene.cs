using UnityEngine;
using UnityEngine.UI;

public class ScoreOnGameScene : MonoBehaviour
{
    public Text ScoreOnDisplay;
    void Start()
    {
        ScoreOnDisplay = GetComponent<Text>();
    }
    public void Update()
    {
        ScoreOnDisplay.text = moveGamePerson.Score.ToString();       
    }
}
