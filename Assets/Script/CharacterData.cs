using UnityEngine;
using System.Collections;

public class CharacterData : MonoBehaviour {

    public float maxhealth;
    public float health;
    public float maxmana;
    public float mana;
    public float defense;
    public float level;
    public float damage;
    public float magdamage;
    public bool triggerAttack;
    public bool characterDeath;

    public Animation dieAnimation;


    public CharacterData()
    {
        level = 2;
        maxhealth = 10 + (level * 5);
        health = 10 + (level * 5);
        maxmana = 5 + (level * 3);
        mana = 5 + (level * 3);
        defense = 5 + (level * 2);
        damage = 5 + (level * 3);
        magdamage = 5 + (level * 2);
        characterDeath = false;
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        //dieAnimation.Play();
    }
}

