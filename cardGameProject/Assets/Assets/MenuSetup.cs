using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuSetup : MonoBehaviour
{
    void Start()
    {
        // This script helps set up the menu
        SetupMenu();
    }
    
    void SetupMenu()
    {
        // Find canvas
        GameObject canvas = GameObject.Find("Canvas");
        if (canvas == null) return;
        
        // Create Settings Button
        GameObject settingsButton = new GameObject("SettingsButton");
        settingsButton.transform.SetParent(canvas.transform);
        
        // Add RectTransform
        RectTransform rectTransform = settingsButton.AddComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(160, 30);
        rectTransform.anchoredPosition = new Vector2(0, -50);
        
        // Add CanvasRenderer
        settingsButton.AddComponent<CanvasRenderer>();
        
        // Add Image
        Image image = settingsButton.AddComponent<Image>();
        
        // Add Button
        Button button = settingsButton.AddComponent<Button>();
        button.targetGraphic = image;
        
        // Create Text child
        GameObject textObj = new GameObject("Text (TMP)");
        textObj.transform.SetParent(settingsButton.transform);
        
        RectTransform textRect = textObj.AddComponent<RectTransform>();
        textRect.sizeDelta = new Vector2(160, 30);
        textRect.anchoredPosition = Vector2.zero;
        
        TextMeshProUGUI text = textObj.AddComponent<TextMeshProUGUI>();
        text.text = "Settings";
        text.fontSize = 36;
        text.alignment = TextAlignmentOptions.Center;
        
        // Add Title
        GameObject titleObj = new GameObject("Title");
        titleObj.transform.SetParent(canvas.transform);
        
        RectTransform titleRect = titleObj.AddComponent<RectTransform>();
        titleRect.sizeDelta = new Vector2(400, 100);
        titleRect.anchoredPosition = new Vector2(0, 200);
        
        TextMeshProUGUI titleText = titleObj.AddComponent<TextMeshProUGUI>();
        titleText.text = "Main Menu";
        titleText.fontSize = 72;
        titleText.alignment = TextAlignmentOptions.Center;
        
        // Clean up by destroying this component after setup
        Destroy(this);
    }
}