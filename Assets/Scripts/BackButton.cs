using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        SceneManager.LoadScene("Main");
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
