using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHealthBar : MonoBehaviour
{
    [Header("Health Bar Components")]
    public Image healthBarFill;
    public TextMeshProUGUI healthText;
    
    [Header("Health Bar Settings")]
    public Color fullHealthColor = Color.green;
    public Color lowHealthColor = Color.red;
    public float lowHealthThreshold = 0.3f;
    
    private int maxHealth;
    private int currentHealth;
    
    public void Initialize(int maxHP)
    {
        maxHealth = maxHP;
        currentHealth = maxHP;
        UpdateHealthBar();
    }
    
    public void UpdateHealth(int newHealth)
    {
        currentHealth = Mathf.Clamp(newHealth, 0, maxHealth);
        UpdateHealthBar();
    }
    
    private void UpdateHealthBar()
    {
        if (healthBarFill != null)
        {
            float healthPercent = (float)currentHealth / maxHealth;
            healthBarFill.fillAmount = healthPercent;
            
            // Change color based on health percentage
            if (healthPercent <= lowHealthThreshold)
                healthBarFill.color = lowHealthColor;
            else
                healthBarFill.color = Color.Lerp(lowHealthColor, fullHealthColor, 
                    (healthPercent - lowHealthThreshold) / (1f - lowHealthThreshold));
        }
        
        if (healthText != null)
        {
            healthText.text = $"{currentHealth}/{maxHealth}";
        }
    }
    
    public float GetHealthPercent()
    {
        return (float)currentHealth / maxHealth;
    }
}