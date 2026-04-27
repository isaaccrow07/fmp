using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class RestartOnFail : MonoBehaviour
{
    public float fallThreshold = -10f; // how far down before reset
    public float restartDelay = 0.5f;
    private bool isRestarting = false;
    void Update()
    {
        // Check if player fell off map
        if (!isRestarting && transform.position.y < fallThreshold)
        {
            StartCoroutine(RestartDelay());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!isRestarting && collision.gameObject.CompareTag("Hazard"))
        {
            StartCoroutine(RestartDelay());
        }
    }
    IEnumerator RestartDelay()
    {
        isRestarting = true;
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}