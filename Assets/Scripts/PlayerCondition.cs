using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public float maxHp = 100f;
    public float currentHp;
    public float decreaseRate = 3f;

    public HealthBar healthBar;

    void Start()
    {
        currentHp = maxHp;
        healthBar.UpdateBar(currentHp, maxHp);
    }
    void Update()
    {
        currentHp -= decreaseRate * Time.deltaTime;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);
        healthBar.UpdateBar(currentHp, maxHp);
    }
    public void Heal(float amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        healthBar.UpdateBar(currentHp, maxHp);
    }
}
