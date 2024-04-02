using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin_button : MonoBehaviour
{
    private bool running_coroutine;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && !running_coroutine)
        {
            StartCoroutine(delay());
        }          
    }

    private IEnumerator delay()
    {
        running_coroutine = true;
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("Mode_select");
    }
}
