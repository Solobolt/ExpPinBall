using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private int health = 100;

    private EnemySpawner enemySpawner;
    

    public Material[] material;

	// Use this for initialization
	void Start () {
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<EnemySpawner>();
        enemySpawner.addEnemy();

        
        this.GetComponent<Renderer>().sharedMaterial = material[enemySpawner.rand];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //handles the damage done to the enemy
    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            enemySpawner.removeEnemy();
            Destroy(gameObject);
        }
    }
}
