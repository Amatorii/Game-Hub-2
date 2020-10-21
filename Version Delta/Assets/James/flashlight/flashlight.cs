using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlight : MonoBehaviour
{
    public bool FlashLightOn = false;
    public Light flashlightAsset;
    public float batteryPower = 100;
    public float batteryUsage = 10;
    public PlayerCamera gamer;
    public Image bar;
    void Awake()
    {
        flashlightAsset.gameObject.SetActive(FlashLightOn);
    }

    void Update()
    {
        if (gamer.sleeping == true)
        {
            FlashLightOn = false;
            flashlightAsset.gameObject.SetActive(FlashLightOn);
            return;
        }
        if (Input.GetButtonUp("Fire2")&&batteryPower > 0)
        {
            FlashLightOn = !FlashLightOn;
            flashlightAsset.gameObject.SetActive(FlashLightOn);
        }

        if(FlashLightOn)
        {
            batteryPower -= batteryUsage * Time.deltaTime;
            bar.fillAmount = batteryPower / 100;
            if (batteryPower < 0)
            {
                FlashLightOn = false;
                GameManager.Instance.GameOver();
                flashlightAsset.gameObject.SetActive(false);
            }
        }
    }

    






}
