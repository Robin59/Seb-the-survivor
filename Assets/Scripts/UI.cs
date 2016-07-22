using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {

    public Text scoreText;
    public Text lifePointText;

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
        lifePointText.text = "Life points : " + newLifePoints.ToString();
    }
}
