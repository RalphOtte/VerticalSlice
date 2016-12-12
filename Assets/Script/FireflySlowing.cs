using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FireflySlowing : MonoBehaviour {

    public Slider StaminaSlider;
    private float SlowingStamina;
    [SerializeField]
    private float RemoveStamina = 5;
    private float MaxSlowStam = 100;
    private float RegenStamina = 2;
    private bool Slowing;

	// Use this for initialization
	void Start ()
    {
        Slowing = false;
        SlowingStamina = MaxSlowStam;
        StaminaSlider.maxValue = MaxSlowStam;
    }
	
	// Update is called once per frame
	void Update ()
    {
        StaminaSlider.value = SlowingStamina;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Slowing = true;
 
        }
        else
        {
            Slowing = false;
        }

        if (Slowing == true)
        {
            SlowingStamina -= RemoveStamina * Time.deltaTime;
            Debug.Log(SlowingStamina);
        }
        else if (Slowing == false && SlowingStamina <= MaxSlowStam)
        {
            SlowingStamina += RegenStamina * Time.deltaTime;
        }
	}
}
