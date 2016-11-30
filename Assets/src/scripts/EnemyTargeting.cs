using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyTargeting : MonoBehaviour {

    [SerializeField]
    private List<Transform> Enemies;
    [SerializeField]
    public Transform SelectedEnemy;
    private Transform myTransform;
   // EnemyHealth enemyhealth = new EnemyHealth();

    // Use this for initialization
    void Start ()
    {
        //zoek Selectedtarget object
        //Getcomponent Enemyhealth
        //enemy health = target's enemyhealth script
        //als enemy dood is, verkort de lijst en pas automatisch target weer aan
        Enemies = new List<Transform>();
        SelectedEnemy = null;
        myTransform = transform;

        AddAllEnemies();


	}

    public void AddAllEnemies()
    {
        GameObject[] go =
        GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in go)
        {
            AddTarget(enemy.transform);
        }
    }

    public void AddTarget(Transform enemy)
    {
        Enemies.Add(enemy);
    }



    private void SortTargetsByDistance()
    {
        if (SelectedEnemy != null)
        {
            Enemies.Sort(delegate (Transform t1, Transform t2)
                {
                    return Vector3.Distance(t1.position, myTransform.position).CompareTo(Vector3.Distance(t2.position, myTransform.position));
                });
        }
    }

    private void TargetEnemy()
    {
        if (SelectedEnemy == null)
        {
            SortTargetsByDistance();
            SelectedEnemy = Enemies[0];
        }
        else
        {
            int index = Enemies.IndexOf(SelectedEnemy);

            if (index < Enemies.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            SelectedEnemy = Enemies[index];
        }
        SelectEnemy();
      }

    private void SelectEnemy()
{
        //Indicator that the enemy is selected
}

	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            TargetEnemy();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DmgEnemy();
        }
        if (SelectedEnemy == null)
        {
            SortTargetsByDistance();
            SelectedEnemy = Enemies[0];
        }
    }

    void DmgEnemy()
    {
        EnemyHealth enemyHealth = SelectedEnemy.GetComponent<EnemyHealth>();
        enemyHealth.TakeDamage(50);
    }

    public void RemoveTarget(Transform enemy)
    {
        //Enemies.RemoveAll(enemy);
    }

}
