using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public bool triggerAttack = false;
    public bool TriggerAttack
    {
        get { return triggerAttack; }
        set { triggerAttack = value; }
    }

    private float attackTimer;
    public float AttackTimer
    {
        get { return attackTimer; }
    }
    public float enemyDamage;

    private bool continueTimer;
    private bool chooseSkill;
    private bool chosen;
    private bool defendChosen;
    private bool attackChosen;
    private bool magicChosen;

    //public Transform startMarker;
    //public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    public CharacterData charData = new CharacterData();

    //Only the player needs these
    [SerializeField]
    private Button defendButton;
    [SerializeField]
    private Button attackButton;
    [SerializeField]
    private Button magicButton;

    void Start()
    {
        enemyDamage = this.charData.damage;
        attackTimer = 5;
        triggerAttack = false;
        continueTimer = true;
        startTime = Time.time;
        //journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        UpdateTimeBarPos();
        if (continueTimer == true)
        {
            attackTimer -= Time.deltaTime;
            Debug.Log(Mathf.Floor(attackTimer) + " Attack timer");
        }

        if (attackTimer <= 2 && attackTimer >= 0)
        {
            continueTimer = false;
            ChooseSkill();
        }
        if (attackTimer <= 0)
        {
            continueTimer = false;
            Action();
        }
    }

    void UpdateTimeBarPos()
    {
        //float distCovered = (Time.time - startTime) * speed;
        //float fracJourney = distCovered / journeyLength;
        //transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
    }

    void ResetAttackTimer(int time)
    {
        attackTimer = time;
    }

    void ChooseSkill()
    {
        Debug.Log("Chooseskill:");
        if (this.gameObject.tag != "Player")
        {
            //Attack is normal attack
            //continueTimer = true;
        }
        if (this.gameObject.tag == "Player")
        {
            //Bring up menu
            defendButton.gameObject.SetActive(true);
            attackButton.gameObject.SetActive(true);
            magicButton.gameObject.SetActive(true);
            if (chosen)
            {
                continueTimer = true;
                defendButton.gameObject.SetActive(false);
                attackButton.gameObject.SetActive(false);
                magicButton.gameObject.SetActive(false);
            }
        }
    }

    public void ChooseDefend()
    {
        chooseSkill = false;
        chosen = true;
        defendChosen = true;
    }

    public void ChooseAttack()
    {
        chooseSkill = false;
        chosen = true;
        attackChosen = true;
    }

    public void ChooseMagic()
    {
        chooseSkill = false;
        chosen = true;
        magicChosen = true;
    }

    void Action()
    {
        Debug.Log("Attack!");
        if (defendChosen)
        {
            attackTimer = 3;
        }
        if (attackChosen)
        {
            Debug.Log(charData.health + " Before on: " + this.gameObject.name);
            charData.health -= enemyDamage;
            Debug.Log(charData.health + " After on:" + this.gameObject.name);
            //playerhitanim.play();
            attackTimer = 5;
        }
        if (magicChosen)
        {
            attackTimer = 5;
        }

        Cleanup();  //Resets all variables


    }

    void Cleanup()
    {
        chooseSkill = false;
        triggerAttack = false;
        defendChosen = false;
        attackChosen = false;
        magicChosen = false;

        continueTimer = true;
    }
}