using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {

    private BattleSystemCoordinator battleSystemCoordinator;

    private List<Skill> skills = new List<Skill>();

    //Personal Stats
    private string name;
    private float health;
    private float mana;
    private float defense;
    private float magicDefense;
    private float attackPower;
    private float spellPower;
    private float criticalChance;
    private float dodgeChance;

    //BattleSystem variables
    private int selectedEnemy;
    private SkillCategories selectedSkill;
    private float remainingTimeForAction;
    private float damageTaken;

    #region getters and setters

    public float RemainingTimeForAction
    {
        get { return remainingTimeForAction; }

        set { remainingTimeForAction = value; }
    }

    public float DamageTaken
    {
        get { return damageTaken; }

        set { damageTaken = value; }
    }
    #endregion

    void Start () {

        BattleSystemCoordinator battleSystemCoordinator = GetComponent<BattleSystemCoordinator>();

        Skill normalAttack = new Skill("Normal Attack", SkillCategories.Offensive, 1f);
        AddSkill(normalAttack);
        Skill defend = new Skill("Defend", SkillCategories.Defensive, 1f);
        AddSkill(defend);

        for (int i = 0; i < skills.Count; i++)
        {
            Debug.Log(skills[i].Name + " Skills!");
        }

        //PostAction(SkillCategories.Offensive);
	}

    void Update()
    {
        //GameObject battleTimer = GameObject.FindGameObjectsWithTag("battleTimer");
        //if (!battleTimer.Wait)
       // {
         //   remainingTimeForAction -= Time.deltaTime;
        //}
    }

    //Add a skill to the available skills list. Public so external scripts can "teach" this script a new Skill
    public void AddSkill(Skill skill)
    {
        skills.Add(skill);
    }

    void SelectSkill(SkillCategories skill)
    {
        selectedSkill = skill;
    }

    //Call this function when you want to decrease the health of the character
    public void takeDamage(float damage)
    {
        DamageTaken = damage;
    }

    //Post your skill in the battletimer script
    void PostAction(SkillCategories selectedSkill )
    {

        BattleTimer battleTimer = GetComponent<BattleTimer>();

        foreach(Skill skillCategories in skills)
        {
            if(selectedSkill == skillCategories.SkillCategory )
            {
                Debug.Log("This skill is:  " + skillCategories.SkillCategory);
            }
        }

        /*
        Selectedskill comparen met de SkilldataList van deze entity
        Van die selectedskil de skilltime variable ophalen
        die skilltime doorposten in de BattleTimer
        Dan weet de battletimer WIE DOET, WELKE SKILL, OP WIE
        Battlesystem Class moet deze data daar weer uithalen
        */

        //battleTimer.CastTimers.Add(selectedSkill);
        //Posts selectedSkill and selectedEnemy to the BattleTimer
    }

}
