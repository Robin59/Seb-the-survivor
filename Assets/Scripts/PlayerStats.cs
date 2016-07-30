using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[System.Serializable]
public class IntEvent : UnityEvent<int> {}

public class PlayerStats : MonoBehaviour {

    private class RageTimer
    {
        private float timerLimit = 1;
        private float timeStartEnable;

        public void resetTimer() { timeStartEnable = Time.time; }
        public bool timerLimitReached() { return (Time.time - timeStartEnable) >= timerLimit; }
        public RageTimer(float xtimerLimit){ timerLimit=xtimerLimit;}
    }

    public float timeBeforeResetRageTimer;
    private RageTimer rageTimer;
    public sbyte neededRagePointsForFuryAttack;
    private sbyte ragePoints;
    private int Score;   
    public sbyte MaxLifePoints;
    private sbyte currentLifePoints; //use of sByte instead of byte to prevent life points to go in positive value after going under 0

    public IntEvent scoreChangeEvent = new IntEvent();
    public IntEvent currentLifeChangeEvent = new IntEvent();
    public IntEvent ragePointsChangeEvent = new IntEvent();
    public UnityEvent playerDie = new UnityEvent();
    public UnityEvent furyAttack = new UnityEvent();

    // Use this for initialization
    void Start () {
        currentLifePoints = MaxLifePoints;
        Score = 0;
        ragePoints = 0;
        rageTimer= new RageTimer(timeBeforeResetRageTimer);

        scoreChangeEvent.Invoke(Score);
        currentLifeChangeEvent.Invoke(currentLifePoints);
    }
	
	// Update is called once per frame
	void Update () {
	    if (currentLifePoints <= 0)
        {
            playerDie.Invoke();
        }
        if (ragePoints>= neededRagePointsForFuryAttack)
        {
            furyAttack.Invoke();
            ragePoints = 0;
            rageTimer.resetTimer();
            ragePointsChangeEvent.Invoke(ragePoints);
            Debug.Log("Rage attack lunched");
        }
        if (rageTimer.timerLimitReached())
        {
            ragePoints=0;
            rageTimer.resetTimer();
            ragePointsChangeEvent.Invoke(ragePoints);
        }

    }

    public void OnEnemyDie()
    {
        ragePointsChangeEvent.Invoke(++ragePoints);        
        rageTimer.resetTimer();        
        scoreChangeEvent.Invoke(++Score);
    }

    public void OnEnemyAttack()
    {               
        currentLifeChangeEvent.Invoke(--currentLifePoints);
    }
}
