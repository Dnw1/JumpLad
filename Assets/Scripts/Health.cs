using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    //Set starting health.
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    //Lower the current health by the amount of damage taken from the float given.
    public void TakeDamage(float _damage)
    {
        currentHealth = currentHealth - _damage;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    //Add health determined by the value given.
    public void AddHealth(float _value)
    {
        currentHealth = currentHealth + _value;
    }
}
