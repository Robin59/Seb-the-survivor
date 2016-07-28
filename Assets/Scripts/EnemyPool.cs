using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPool : MonoBehaviour {

    public GameObject EnemyPrefab;
    public int Max_nomber_Enemies;
    public float Enemy_Rate_Apparition;

    private readonly List<GameObject> _EnemyPool= new List<GameObject>();    

	// Use this for initialization
	void Start () {
        for (int i=0; i<Max_nomber_Enemies; i++)
        {
            GameObject instance = Instantiate(EnemyPrefab);
            instance.SetActive(false);
            _EnemyPool.Add(instance);
        }

        InvokeRepeating("EnemyPop",1, Enemy_Rate_Apparition);
	}
	
    /// <summary>
    /// Make a new enemy pop from the enemy pool
    /// </summary>
    void EnemyPop()
    {
        GameObject enemy = null;

        foreach (GameObject i_enemy in _EnemyPool)
        {
            if (!i_enemy.activeInHierarchy)
            {
                enemy = i_enemy;
                break;
            }
        }

        if(enemy!=null)
        {
            //to do : make randomize vector but maybe not totaly randomized            
            int x=Random.Range(-10, 10);           
            int y = Random.Range(-4, 4);
            while (false)
            {
                x= Random.Range(-10, 10);
                y= Random.Range(-4, 4);
                foreach (GameObject i_enemy in _EnemyPool)
                {
                    //if (i_enemy.transform.position.x trop pres x) 
                }
            }
            
            enemy.transform.position = new Vector2(x, y);
            enemy.SetActive(true);
        }
    }
}
