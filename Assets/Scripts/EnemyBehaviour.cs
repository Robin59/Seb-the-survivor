using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

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
        Debug.Log(gameObject.name + " is shooted");
        gameObject.SetActive(false);
    }
}
