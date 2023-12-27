using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject[] itemsToDrop;
    public float dropChance = 0.5f;
    public int maxHealth = 100;
    private int currentHealth;
    private Animator An;

    void Start()
    {
        currentHealth = maxHealth;
        An = GetComponent<Animator>();
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            DropItem();
            An.SetBool("h",true);
            Destroy(gameObject,0.2f);
        }
    }

    private void DropItem()
    {
        if (Random.value <= dropChance)
        {
            if (itemsToDrop.Length > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, itemsToDrop.Length);
                Instantiate(itemsToDrop[randomIndex], transform.position, Quaternion.identity);
            }
        }
    }
}
