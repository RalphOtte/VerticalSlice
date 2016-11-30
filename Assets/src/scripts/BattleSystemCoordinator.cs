using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleSystemCoordinator : MonoBehaviour {

    private Dictionary<int, string> enemyList = new Dictionary<int, string>();

    public Dictionary<int, string> EnemyList
    {
        get { return enemyList; }
    }

    private int whosTurn;
    private int maxTurn;

	void Start ()
    {
        whosTurn = 1;
        enemyList.Add(1, "Ent");
	}
	
	void Update ()
    {
	    
	}
}
