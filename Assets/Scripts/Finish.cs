using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        winPanel.SetActive(true);
    }
}
