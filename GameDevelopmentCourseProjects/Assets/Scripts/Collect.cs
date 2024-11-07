using System;
using TMPro;
using UnityEngine;


public class Collect : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public int woodCount = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            Destroy(other.gameObject);
            woodCount = woodCount + 1;
            UpdateUIWoodCount(woodCount);
        }
    }

    public void UpdateUIWoodCount(int woodCount)
    {
        textUI.text = woodCount.ToString();
    }
    
}
