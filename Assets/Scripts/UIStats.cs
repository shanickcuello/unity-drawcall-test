using TMPro;
using UnityEngine;

public class UIStats : MonoBehaviour
{
    [SerializeField] TMP_Text statsText;
    [SerializeField] ProfilerController profilerController;
    
    private void Update()
    {
        CountFPS();
    }

    private void CountFPS()
    {
        statsText.text = profilerController.statsText;
    }
}
