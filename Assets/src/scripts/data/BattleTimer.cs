using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleTimer : MonoBehaviour{

    private bool wait = false;
    public bool Wait { get { return wait; } }
    // [0] = [0] bij elk andere list
    [SerializeField] //Alle characters die meedoen in de battle [0] is altijd de speler
    private List<CharacterData> battleActors = new List<CharacterData>();
    [SerializeField] //Alle gekozen skills(alleen characters die al bij Cast zijn geweest)
    private List<Skill> chosenSkills = new List<Skill>();
    [SerializeField] //Alle targets die bij Cast zijn gekozen
    private List<CharacterData> chosenTargets = new List<CharacterData>();
    [SerializeField]// Alle timers van de characters
    private List<float> castTimers = new List<float>();

	public List<float> CastTimers
    {
        get { return castTimers; }

        set { if (value != null) {  } }
    }

    void Awake()
    {
        
    }


    void Update()
    {
        if (wait)
        {
            
        }
        else { }
    }

    public void Cast(CharacterData actor, Skill skill, CharacterData target)
    {

    }

    public void Act(CharacterData actor, Skill skill, CharacterData target)
    {

    }
}
