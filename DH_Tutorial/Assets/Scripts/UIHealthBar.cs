using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    public static UIHealthBar I;
    private void Awake() {
        I = this;
    }

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = transform.GetComponent<Slider>();

        slider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValue(float value)
    {
        slider.value = value;
    }
}
