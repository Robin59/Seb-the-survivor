using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    public UnityEvent enemyDieEvent=new UnityEvent();
    public UnityEvent enemyAttackEvent = new UnityEvent();
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnEnable()
    {   
        //to do
        //lunch a timer before attacking
    }

    public void OnShooted()
    {
        // to do : Add points to the player stats        
        enemyDieEvent.Invoke();
        gameObject.SetActive(false);
    }
}
