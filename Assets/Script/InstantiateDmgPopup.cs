using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InstantiateDmgPopup : MonoBehaviour
{

    public Transform popupTransform;
    public GameObject popupPrefab;

    public void CreateDamagePopup(int damage)
    {
        GameObject damageGameObject = (GameObject)Instantiate(popupPrefab, popupTransform.position, popupTransform.rotation);


        damageGameObject.GetComponentInChildren<Text>().text = damage.ToString();
    }
}
 