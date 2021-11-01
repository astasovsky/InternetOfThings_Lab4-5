using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        losePanel.SetActive(true);
    }
}
