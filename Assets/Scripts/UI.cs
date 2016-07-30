using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {

    public Text scoreText;
    public Text lifePointsText;
    public Text rageLevelText;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void tes() { }

    public void OnPlayerScoreChange(int newScore)
    {    
        scoreText.text = "Score : "+newScore.ToString();
    }

    public void OnPlayerLifeChange(int newLifePoints)
    {
        lifePointsText.text = "Life points : " + newLifePoints.ToString();
    }

    public void OnRageLevelChange(int newRageLevel)
    {
        rageLevelText.text = "Rage level : " + newRageLevel.ToString();
    }
}
