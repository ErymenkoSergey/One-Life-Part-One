using UnityEngine;
using UnityEngine.UI;

public class UIGameControler : MonoBehaviour
{
    [SerializeField]
    Button fire, pause;//, jump, sitDown, nextWeapon, previousWeapon, recharge, aim, chatVoice,
                       //chat;

    [SerializeField]
    GameObject controlPanel;

    private void Start()
    {
        fire.onClick.AddListener(Fire);
        pause.onClick.AddListener(Pause);
    }

    private void Pause()
    {
        bl_GameInput.Pause(GameInputType.Down);
        controlPanel.SetActive(false);
    }

    private void Fire()
    {
        bl_MobileInput.GetButton("Fire");
        controlPanel.SetActive(true);
    }

}
