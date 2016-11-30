using UnityEngine;
using System.Collections;

public enum SkillCategories
{
    Offensive,
    Defensive,
    Magic
}

public class Skill {

    private string name;
    private SkillCategories skill;
    private float skillTime;
    private float cost;

    public string Name
    {
        get {return name; }
    }

    public SkillCategories SkillCategory
    {
        get { return skill; }
    }

    public float Skilltime
    {
        get { return skillTime; }
    }

    public float Cost
    {
        get { return cost; }
    }

    public Skill(string name, SkillCategories category, float skillTime)
    {
        this.name = name;
        this.skill = skill;
        this.skillTime = skillTime;
        this.cost = cost;
    }

   
}
