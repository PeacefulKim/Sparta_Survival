using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float currentHp;
    public float maxHp;
    public float passiveDmg;
    private float width;

    void Start()
    {
        currentHp = maxHp;
        width = healthBar.rectTransform.sizeDelta.x;
    }
    void Update()
    {
        UpdateBar();
    }
    public void Add(float amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
    }
    public void Subtract(float amount)
    {
        currentHp = Mathf.Max(currentHp - amount, 0.0f);
    }
    public float GetPercentage()
    {
        return currentHp / maxHp;
    }
    private void UpdateBar()
    {
        float curHp = GetPercentage();
        Vector2 size = healthBar.rectTransform.sizeDelta;
        size.x = width * curHp;
        healthBar.rectTransform.sizeDelta = size;
    }
}
