using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Floatingtext : MonoBehaviour {

	public Animator animator;
    private Text damageText;

    void Start()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0); // Gets the animation info
        Destroy(gameObject, clipInfo[0].clip.length);
        damageText = animator.GetComponent<Text>();                             // Gets the text animation component

    }

    public void SetText(string text)
    {
        damageText.text = text;
    }
}
