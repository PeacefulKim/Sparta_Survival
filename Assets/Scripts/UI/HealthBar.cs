using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    private float fullWidth;

    void Start()
    {
        //fullWidth = healthBar.rectTransform.sizeDelta.x;
        fullWidth = 700f;
    }
    //public void Add(float amount)
    //{
    //    currentHp = Mathf.Min(currentHp + amount, maxHp);
    //}
    //public void Subtract(float amount)
    //{
    //    currentHp = Mathf.Max(currentHp - amount, 0.0f);
    //}
    //public float GetPercentage()
    //{
    //    return currentHp / maxHp;
    //}
    public void UpdateBar(float currentHp ,float maxHp)
    {
        float ratio = currentHp / maxHp;
        Vector2 size = healthBar.rectTransform.sizeDelta;
        size.x = fullWidth * ratio;
        healthBar.rectTransform.sizeDelta = size;
    }
}
