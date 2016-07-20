using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public int Score;
    public byte MaxLifePoints;
    private byte currentLifePoints;
	// Use this for initialization
	void Start () {
        currentLifePoints = MaxLifePoints;
        Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnEnemydie()
    {
        Debug.Log("OnEnemydie");
        Score++;
    }
}
