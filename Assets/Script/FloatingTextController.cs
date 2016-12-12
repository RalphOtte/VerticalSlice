using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FloatingTextController : MonoBehaviour
{
public CharacterData charData = new CharacterData();
    
    // controller for damage popup
private static Floatingtext popupText;
private static GameObject canvas;


public static void Initialize()
    {
        canvas = GameObject.Find("Canvas");
        popupText = Resources.Load<Floatingtext>("Prefabs/PopupTextParent");
    }

public static void CreateFloatingText(string text, Transform location)
    {
        Floatingtext instance = Instantiate(popupText);
        instance.transform.SetParent(canvas.transform, false);
        instance.SetText(text);
    }
}

// Still needs to be connected to  damage ( i got a vid for that so let me know when its done )
// Tyrone :D