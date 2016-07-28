using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[System.Serializable]
public class IntEvent : UnityEvent<int> {}

public class PlayerStats : MonoBehaviour {

    public int Score;
    public byte MaxLifePoints;
    private byte currentLifePoints;

    public IntEvent scoreChangeEvent = new IntEvent();
    public IntEvent currentLifeChangeEvent = new IntEvent();

    // Use this for initialization
    void Start () {
        currentLifePoints = MaxLifePoints;
        Score = 0;

        scoreChangeEvent.Invoke(Score);
        currentLifeChangeEvent.Invoke(currentLifePoints);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnEnemyDie()
    {       
        Score = Score + 1;
        scoreChangeEvent.Invoke(Score);
    }

    public void OnEnemyAttack()
    {
        Debug.Log("OnEnemyAttack");        
        currentLifeChangeEvent.Invoke(--currentLifePoints);
    }
}
