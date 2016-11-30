using UnityEngine;
using System.Collections;

public class ActionSelection : MonoBehaviour {
    // Het plan met die script is dat hij de buttons maakt zodra de speler aan de beurt is

	void Start ()
    {
        CharacterData characterData = GetComponent<CharacterData>();
        if (characterData.RemainingTimeForAction <= 0)
        {
            CreateButtons();
        }
	}

    void CreateButtons()
    {
        if (GUI.Button(new Rect(100, 100, 100, 100), "Derp"))
        {

        }
    }

    void Update () {
	
	}
}
