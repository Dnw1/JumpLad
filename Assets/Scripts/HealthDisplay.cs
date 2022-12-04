using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private GameObject player;
    private float Hp;

    private void Update()
    {
        //Get health of the player and display it.
        Hp = player.GetComponent<Health>().currentHealth;
        healthText.text = Hp.ToString("0");
    }
}
