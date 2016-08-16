using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPool : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject enemyLignePrefab; 
    public int nomber_of_Lignes_in_Enemy_Army;// Number of lignes that the enemy's army contain at the begin of the stage. Once all the enemy lines are destroyed the boss come
    public float initial_X_Position_for_Enemy_Army_Lignes;
    public float initial_Y_Position_for_Enemy_Army_Lignes;
    public int Max_nomber_Enemies; // Nomber max of enemies visible in the same time on the screen
    public float Enemy_Rate_Apparition;

    private readonly List<GameObject> _EnemyPool= new List<GameObject>();
    private Stack<GameObject> _EnemyArmy = new Stack<GameObject>();

    // Use this for initialization
    void Start () {
        
        //Creation the enemy pool.
        for (int i=0; i<Max_nomber_Enemies; i++)
        {
            GameObject instance = Instantiate(enemyPrefab);
            instance.SetActive(false);
            _EnemyPool.Add(instance);
        }

        //Creation of the enemy lines
        for (int i = 0; i < nomber_of_Lignes_in_Enemy_Army; i++)
        {
            const float vertical_Spacing = 1;
            const float horizontal_Spacing = 10;
            float x = initial_X_Position_for_Enemy_Army_Lignes+(i%2)*horizontal_Spacing;
            float y = initial_Y_Position_for_Enemy_Army_Lignes-(i/2)*vertical_Spacing;

            GameObject instance = Instantiate(enemyLignePrefab);
            instance.transform.position = new Vector2(x, y);
            _EnemyArmy.Push(instance);

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
