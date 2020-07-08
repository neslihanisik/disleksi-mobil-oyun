using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController1 : MonoBehaviour
{


    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;
    public List<Sprite> gamePuzzles = new List<Sprite>();

    private bool firstGuess, secondGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gaameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    public float speed = 0.01F;

    public AudioSource source;
    public AudioClip buttonDon;
    public AudioClip buttonYokOl;



    public int level_id;

    private void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/nesne/");
    }


    public List<Button> btns = new List<Button>();
    private void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        Shuffle(gamePuzzles);
        gaameGuesses = gamePuzzles.Count / 2;

        level_id = PlayerPrefs.GetInt("levelidSample");




    }
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton1");

        for (int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }

    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }
    void AddListeners()
    {
        foreach (Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());


        }

    }

    public void PickAPuzzle()
    {

        if (!firstGuess)
        {

            firstGuess = true;
            for (float i = 0f; i >= 180f; i += 10)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
            source.clip = buttonDon;
            source.Play();

        }
        else if (!secondGuess)
        {
            secondGuess = true;
            for (float i = 180f; i >= 0f; i -= 10)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
            }
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
            source.clip = buttonDon;
            source.Play();

            countGuesses++;
            StartCoroutine(CheckIfThePuzzlesMatch());


        }

    }
    IEnumerator CheckIfThePuzzlesMatch()
    {
        yield return new WaitForSeconds(1f);

        if (firstGuessPuzzle == secondGuessPuzzle)
        {

            yield return new WaitForSeconds(.5f);
            source.clip = buttonYokOl;
            source.Play();

            btns[firstGuessIndex].interactable = false;
            btns[firstGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);


            CheckIfTheGameIsFinish();
        }
        else
        {
            yield return new WaitForSeconds(0f);
            for (float i = 180f; i >= 0f; i -= 10)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z), Time.time * speed);
                yield return new WaitForSeconds(0f);

            }


            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;


        }
        yield return new WaitForSeconds(.5f);

        firstGuess = secondGuess = false;


    }
    void CheckIfTheGameIsFinish()
    {
        countCorrectGuesses++;

        if (countCorrectGuesses == gaameGuesses)
        {
            Debug.Log("Game Finish");
            Debug.Log("It took you" + countGuesses + "many gusses to finish the game");
            level_id++;
            PlayerPrefs.SetInt("levelidSample", level_id);


            SceneManager.LoadScene("GameOverScene");
           
        }

    }
    void Shuffle(List<Sprite> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(0, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

}

