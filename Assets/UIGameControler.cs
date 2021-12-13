using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameControler : MonoBehaviour
{
    [SerializeField]
    Button fire, pause;//, jump, sitDown, nextWeapon, previousWeapon, recharge, aim, chatVoice,
        //chat;

    private void Start()
    {
        fire.onClick.AddListener(Fire);
        pause.onClick.AddListener(Pause);
    }

    private void Pause()
    {
        bl_GameInput.Pause(GameInputType.Down);
    }

    private void Fire()
    {
        bl_GameInput.Fire(GameInputType.Up);
        bl_MobileInput.GetButton("Fire");
    }

}
