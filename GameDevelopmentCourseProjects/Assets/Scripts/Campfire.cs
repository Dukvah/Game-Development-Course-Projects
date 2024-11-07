using System;
using TMPro;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    private int woodCount;
    public TextMeshProUGUI textUI;
    public GameObject fireObject;

    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        fireObject.SetActive(false);
    }

    private void Update()
    {
        textUI.transform.forward = cam.transform.forward;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Collect>();
            woodCount += player.woodCount;
            player.woodCount = 0;

            textUI.text = woodCount.ToString();
            player.UpdateUIWoodCount(player.woodCount);

            if (woodCount > 0)
            {
                fireObject.SetActive(true);
            }
        }
    }
}
