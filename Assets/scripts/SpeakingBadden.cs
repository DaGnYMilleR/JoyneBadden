using System.Collections;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpeakingBadden : MonoBehaviour
{
    public bool isSpeaking;
    [SerializeField] private GameObject csb;

    private Animator animator;
    private bool enterPressed;
    private StringBuilder phrase = new ();
    [SerializeField] private Text text;
    private IEnumerator enumerator;
    private int i;
    private string[] phrases = { "Добрый вечер, дорогие американцы! Особенно приветствую тех, кто забыл," +
                                       " куда он пришёл!",
        "Я сам иногда забываю... Но не волнуйтесь, я точно помню, что я здесь президент.",
        "Или это уже было...?",
        "Вы знаете, недавно я пытался использовать наш новый суперсекретный телепортационный устройство...", 
        "Или это был мой новый телефон?", 
        "Так или иначе, я всё равно оказался не там, куда хотел.", 
        "Это как в том старом анекдоте, где вы приходите за чем-то в холодильник и забываете, что именно...", 
        "Кто-то видел мои ключи от Овального кабинета?", 
        "А ещё мы работаем над улучшением образовательной системы.", 
        "Ведь образование — это важно, оно как...",
        "Эээ...",
        "Как это называется... когда вы учите детей, знаете?",
        "Я всегда говорю, что математика — это когда много чисел собираются вместе и решают уравнения.",
        "Как мы с Конгрессом, только без чисел!",
        "И помните, каждый голос важен!",
        "Выборы — это когда вы кладете бумажку в коробку и надеетесь, что всё будет хорошо.",
        "Как с заказом еды онлайн! Иногда вы получаете то, что хотели, а иногда — салат вместо пиццы.",
        "Спасибо вам за то, что пришли сегодня...",
        "Хотя куда мы все пришли?" };


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
                csb.SetActive(true);
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
