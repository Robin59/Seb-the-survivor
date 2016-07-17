using UnityEngine;
using System.Collections;

public class MouseControle : MonoBehaviour {

    public Camera CurrentCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0) && CurrentCamera != null)
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(CurrentCamera.ScreenToWorldPoint(Input.mousePosition).x, CurrentCamera.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);
            if (hit.transform != null) 
            {
                EnemyBehaviour behaviour =hit.transform.GetComponent<EnemyBehaviour>();
                if (behaviour != null) behaviour.OnShooted();
            }
        }
	}
}
