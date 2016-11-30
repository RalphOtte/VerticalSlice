using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int healthPoints;
    private int minHP = 0;
    private int maxHP = 100;

    public int HealthPoints
    {
        get { return healthPoints; }

        set { healthPoints = value; }
    }


    // Use this for initialization
    void Start()
    {

        healthPoints = maxHP;
    }

    public void TakeDamage(int amount)
    {
        healthPoints -= amount;
        CheckHealth();
    }

    void CheckHealth()
    {
        if (healthPoints < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
        EnemyTargeting enemyTargeting = GetComponent<EnemyTargeting>();
        enemyTargeting.RemoveTarget(transform);
    }
}
