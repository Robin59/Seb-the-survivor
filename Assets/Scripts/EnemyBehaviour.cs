using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
    // time the enemie will idle before attacking
    public float timeBeforeAttack;
    private float timeStartEnable;

    public UnityEvent enemyDieEvent=new UnityEvent();
    public UnityEvent enemyAttackEvent = new UnityEvent();    
    
    // Use this for initialization
    void Start () {        
        PlayerStats playerStats = GameObject.Find("Player").GetComponent(typeof(PlayerStats) ) as PlayerStats;
        if (playerStats != null) {
            enemyDieEvent.AddListener(playerStats.OnEnemyDie);
            enemyAttackEvent.AddListener(playerStats.OnEnemyAttack);
        }
        

    }
	
	// Update is called once per frame
	void Update () {
	    if ((Time.time- timeStartEnable) > timeBeforeAttack)
        {
            enemyAttackEvent.Invoke();
            gameObject.SetActive(false);
        }
	}

    private void OnEnable()
    {
        timeStartEnable = Time.time;
    }

    public void OnShooted()
    {        
        enemyDieEvent.Invoke();
        gameObject.SetActive(false);
    }
}
