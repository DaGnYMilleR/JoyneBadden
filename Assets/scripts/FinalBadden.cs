using System.Collections;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalBadden : MonoBehaviour
{
    public bool isSpeaking;

    private Animator animator;
    private bool enterPressed;
    private StringBuilder phrase = new ();
    [SerializeField] private Text text;
    private IEnumerator enumerator;
    private int i;
    private string[] phrases = { "Вспомнил..." };


    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        enumerator = TextCoroutine(phrases[0]);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
        animator.SetBool("isSpeaking", isSpeaking);
        if (isSpeaking)
        {
            if (enumerator.MoveNext())
            {
                if (Input.GetKeyDown(KeyCode.Return) || enterPressed)
                {
                    phrase.Append(enumerator.Current);
                    while (enumerator.MoveNext())
                    {
                        phrase.Append(enumerator.Current);
                    }

                    text.text = phrase.ToString();
                }
                else
                {
                    phrase.Append(enumerator.Current);
                    text.text = phrase.ToString();
                    Thread.Sleep(100);
                }
            }
            else
            {
                isSpeaking = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) || enterPressed)
        {
            if (i + 1 == phrases.Length)
            {
                Application.Quit();
            }
            else
            {
                i++;
                isSpeaking = true;
                enumerator = TextCoroutine(phrases[i]);
                phrase = new StringBuilder();
            }
        }

        enterPressed = false;
    }
    
    private IEnumerator TextCoroutine(string text)
    {
        var sb = new StringBuilder();
        foreach(var c in text)
        {
            yield return c;
        }
    }

    public void PressEnter()
    {
        enterPressed = true;
    }
}
