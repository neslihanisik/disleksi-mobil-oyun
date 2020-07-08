using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer2 : MonoBehaviour
{

    private Touch touch;
    private float SpeedModifier;
    Vector3 touchPosition;

    public GameObject lettreOne, lettreTwo, lettreThree, lettreFor, lettreFive, lettreSix, lettreSeven,
                  lettreEight, BoxOne, BoxTwo, BoxThree, BoxFor, BoxFive,BoxSix,BoxSeven;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreForIni, lettreFiveIni, lettreSixIni, lettreSevenIni, lettreEightIni;

    string str = "";
    public string word;

    public GameObject endGame;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, forCorrect, fiveCorrect ,sixCorrect, sevenCorrect= false;

    Vector3 iniScaleLettreOne, iniScaleLettreTwo, iniScaleLettreThree, iniScaleLettreFor, iniScaleLettreFive, iniScaleLettreSix,
            iniScaleLettreSeven, iniScaleLettreEight;




    public int level_id;
    void Start()
    {
        SpeedModifier = 0.01f;


        lettreOneIni = lettreOne.transform.position;
        lettreTwoIni = lettreTwo.transform.position;
        lettreThreeIni = lettreThree.transform.position;
        lettreForIni = lettreFor.transform.position;
        lettreFiveIni = lettreFive.transform.position;
        lettreSixIni = lettreSix.transform.position;
        lettreSevenIni = lettreSeven.transform.position;
        lettreEightIni = lettreEight.transform.position;

        iniScaleLettreOne = lettreOne.transform.localScale;
        iniScaleLettreTwo = lettreTwo.transform.localScale;
        iniScaleLettreThree = lettreThree.transform.localScale;
        iniScaleLettreFor = lettreFor.transform.localScale;
        iniScaleLettreFive = lettreFive.transform.localScale;
        iniScaleLettreSix = lettreSix.transform.localScale;
        iniScaleLettreSeven = lettreSeven.transform.localScale;
        iniScaleLettreEight = lettreEight.transform.localScale;

        // blockPanel.SetActive(false);

        level_id = PlayerPrefs.GetInt("levelidCross");

   
    }
   

  

    public void DragLettreOne()
    {
        lettreOne.transform.position = Input.mousePosition;


    }
    public void DragLettreTwo()
    {
        lettreTwo.transform.position = Input.mousePosition;
    }
    public void DragLettreThree()
    {
        lettreThree.transform.position = Input.mousePosition;
    }
    public void DragLettreFor()
    {
        lettreFor.transform.position = Input.mousePosition;
    }
    public void DragLettreFive()
    {
        lettreFive.transform.position = Input.mousePosition;
    }
    public void DragLettreSix()
    {
        lettreSix.transform.position = Input.mousePosition;
    }
    public void DragLettrSeven()
    {
        lettreSeven.transform.position = Input.mousePosition;
    }
    public void DragLettreEight()
    {
        lettreEight.transform.position = Input.mousePosition;
    }









    public void DropLettreOne()
    {
        float Distance = Vector3.Distance(lettreOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreOne.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreOne.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreOne.transform.position, BoxSeven.transform.position);

        if (Distance < 50 && oneCorrect == false)
        {
            lettreOne.transform.localScale = BoxOne.transform.localScale;
            lettreOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreOne.name;



        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreOne.transform.localScale = BoxTwo.transform.localScale;
            lettreOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreOne.name;
       

        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreOne.transform.localScale = BoxThree.transform.localScale;
            lettreOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreOne.name;
          
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreOne.transform.localScale = BoxFor.transform.localScale;
            lettreOne.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreOne.name;
           
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreOne.transform.localScale = BoxFive.transform.localScale;
            lettreOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreOne.name;
         
        }

        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreOne.transform.localScale = BoxSix.transform.localScale;
            lettreOne.transform.position = BoxSix.transform.position;
            sixCorrect = true;
      
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreOne.transform.localScale = BoxSeven.transform.localScale;
            lettreOne.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreOne.name;
         
        }



        else
        {
            lettreOne.transform.position = lettreOneIni;

        }

    }



    public void DropLettreTwo()
    {
        float Distance = Vector3.Distance(lettreTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTwo.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTwo.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreTwo.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreTwo.transform.localScale = BoxOne.transform.localScale;
            lettreTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTwo.name;
         
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreTwo.transform.localScale = BoxTwo.transform.localScale;
            lettreTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTwo.name;
           
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreTwo.transform.localScale = BoxThree.transform.localScale;
            lettreTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTwo.name;
         
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFor.transform.localScale;
            lettreTwo.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreTwo.name;
        

        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreTwo.transform.localScale = BoxFive.transform.localScale;
            lettreTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTwo.name;
            
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreTwo.transform.localScale = BoxSix.transform.localScale;
            lettreTwo.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreTwo.name;
         
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreTwo.transform.localScale = BoxSeven.transform.localScale;
            lettreTwo.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreTwo.name;
        
        }


        else
        {
            lettreTwo.transform.position = lettreTwoIni;

        }

    }




    public void DropLettreThree()
    {
        float Distance = Vector3.Distance(lettreThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreThree.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreThree.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreThree.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreThree.transform.localScale = BoxOne.transform.localScale;
            lettreThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreThree.name;
           
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreThree.transform.localScale = BoxTwo.transform.localScale;
            lettreThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreThree.name;
          
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreThree.transform.localScale = BoxThree.transform.localScale;
            lettreThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreThree.name;
           
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreThree.transform.localScale = BoxFor.transform.localScale;
            lettreThree.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreThree.name;
          
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreThree.transform.localScale = BoxFive.transform.localScale;
            lettreThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreThree.name;
           
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreThree.transform.localScale = BoxSix.transform.localScale;
            lettreThree.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreThree.name;
         
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreThree.transform.localScale = BoxSeven.transform.localScale;
            lettreThree.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreThree.name;
          
        }


        else
        {
            lettreThree.transform.position = lettreThreeIni;

        }

    }


    public void DropLettreFor()
    {
        float Distance = Vector3.Distance(lettreFor.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFor.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFor.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFor.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreFor.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFor.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreFor.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreFor.transform.localScale = BoxOne.transform.localScale;
            lettreFor.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFor.name;
         
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFor.transform.localScale = BoxTwo.transform.localScale;
            lettreFor.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFor.name;
         
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFor.transform.localScale = BoxThree.transform.localScale;
            lettreFor.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFor.name;
           
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreFor.transform.localScale = BoxFor.transform.localScale;
            lettreFor.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreFor.name;
          
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFor.transform.localScale = BoxFive.transform.localScale;
            lettreFor.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFor.name;
          
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFor.transform.localScale = BoxSix.transform.localScale;
            lettreFor.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFor.name;
          
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreFor.transform.localScale = BoxSeven.transform.localScale;
            lettreFor.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreFor.name;
       
        }


        else
        {
            lettreFor.transform.position = lettreForIni;

        }

    }


    public void DropLettreFive()
    {
        float Distance = Vector3.Distance(lettreFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFive.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFive.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreFive.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreFive.transform.localScale = BoxOne.transform.localScale;
            lettreFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFive.name;
            
         
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreFive.transform.localScale = BoxTwo.transform.localScale;
            lettreFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFive.name;
            
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreFive.transform.localScale = BoxThree.transform.localScale;
            lettreFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFive.name;
       
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreFive.transform.localScale = BoxFor.transform.localScale;
            lettreFive.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreFive.name;
            
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreFive.transform.localScale = BoxFive.transform.localScale;
            lettreFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFive.name;
            
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreFive.transform.localScale = BoxSix.transform.localScale;
            lettreFive.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFive.name;
        
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreFive.transform.localScale = BoxSeven.transform.localScale;
            lettreFive.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreFive.name;
           
        }


        else
        {
            lettreFive.transform.position = lettreFiveIni;

        }

    }


    public void DropLettreSix()
    {
        float Distance = Vector3.Distance(lettreSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSix.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSix.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreSix.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreSix.transform.localScale = BoxOne.transform.localScale;
            lettreSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSix.name;
          
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSix.transform.localScale = BoxTwo.transform.localScale;
            lettreSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSix.name;
         
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSix.transform.localScale = BoxThree.transform.localScale;
            lettreSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            
            BoxThree.name = lettreSix.name;
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreSix.transform.localScale = BoxFor.transform.localScale;
            lettreSix.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreSix.name;
           
        }

        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSix.transform.localScale = BoxFive.transform.localScale;
            lettreSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSix.name;

        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSix.transform.localScale = BoxSix.transform.localScale;
            lettreSix.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSix.name;
          
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreSix.transform.localScale = BoxSeven.transform.localScale;
            lettreSix.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreSix.name;
            
        }

        else
        {
            lettreSix.transform.position = lettreSixIni;

        }

    }



    public void DropLettreSeven()
    {
        float Distance = Vector3.Distance(lettreSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSeven.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSeven.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreSeven.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreSeven.transform.localScale = BoxOne.transform.localScale;
            lettreSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSeven.name;
          
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreSeven.transform.localScale = BoxTwo.transform.localScale;
            lettreSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSeven.name;
           
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreSeven.transform.localScale = BoxThree.transform.localScale;
            lettreSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSeven.name;

        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFor.transform.localScale;
            lettreSeven.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreSeven.name;
            
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreSeven.transform.localScale = BoxFive.transform.localScale;
            lettreSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSeven.name;
          
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreSeven.transform.localScale = BoxSix.transform.localScale;
            lettreSeven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSeven.name;
           
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreSeven.transform.localScale = BoxSeven.transform.localScale;
            lettreSeven.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreSeven.name;
            
        }

        else
        {
            lettreSeven.transform.position = lettreSevenIni;

        }

    }


    public void DropLettreEight()
    {
        float Distance = Vector3.Distance(lettreEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreEight.transform.position, BoxFor.transform.position);
        float Distance5 = Vector3.Distance(lettreEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreEight.transform.position, BoxSix.transform.position);
        float Distance7 = Vector3.Distance(lettreEight.transform.position, BoxSeven.transform.position);
        if (Distance < 50 && oneCorrect == false)
        {
            lettreEight.transform.localScale = BoxOne.transform.localScale;
            lettreEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreEight.name;
          
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            lettreEight.transform.localScale = BoxTwo.transform.localScale;
            lettreEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreEight.name;
         
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            lettreEight.transform.localScale = BoxThree.transform.localScale;
            lettreEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreEight.name;
        
        }
        else if (Distance4 < 50 && forCorrect == false)
        {
            lettreEight.transform.localScale = BoxFor.transform.localScale;
            lettreEight.transform.position = BoxFor.transform.position;
            forCorrect = true;
            BoxFor.name = lettreEight.name;
         
        }
        else if (Distance5 < 50 && fiveCorrect == false)
        {
            lettreEight.transform.localScale = BoxFive.transform.localScale;
            lettreEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreEight.name;
         
        }
        else if (Distance6 < 50 && sixCorrect == false)
        {
            lettreEight.transform.localScale = BoxSix.transform.localScale;
            lettreEight.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreEight.name;
          
        }


        else if (Distance7 < 50 && sevenCorrect == false)
        {
            lettreEight.transform.localScale = BoxSeven.transform.localScale;
            lettreEight.transform.position = BoxSeven.transform.position;
            sevenCorrect = true;
            BoxSeven.name = lettreEight.name;
          
        }

        else
        {
            lettreEight.transform.position = lettreEightIni;

        }

    }







    //Button

    public void Check()
    {


        str = BoxOne.name + BoxTwo.name + BoxThree.name + BoxFor.name + BoxFive.name + BoxSix.name + BoxSeven.name;

        if (word == str)
        {


            StartCoroutine(LoadNextPanel());
         
        }


    }

    public void Reload()
    {
        str = "";

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        forCorrect = false;
        fiveCorrect = false;
        sixCorrect = false;
        sevenCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFor.name = "4";
        BoxFive.name = "5";
        BoxSix.name = "6";
        BoxSeven.name = "7";


        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFor.transform.position = lettreForIni;
        lettreFive.transform.position = lettreFiveIni;
        lettreSix.transform.position = lettreSixIni;
        lettreSeven.transform.position = lettreSevenIni;
        lettreEight.transform.position = lettreEightIni;

        lettreOne.transform.localScale = iniScaleLettreOne;
        lettreTwo.transform.localScale = iniScaleLettreTwo;
        lettreThree.transform.localScale = iniScaleLettreThree;
        lettreFor.transform.localScale = iniScaleLettreFor;
        lettreFive.transform.localScale = iniScaleLettreFive;
        lettreSix.transform.localScale = iniScaleLettreSix;
        lettreSeven.transform.localScale = iniScaleLettreSeven;
        lettreEight.transform.localScale = iniScaleLettreEight;

    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
        if(questionToShow == endGame)
        {
            level_id++;
            PlayerPrefs.SetInt("levelidCross", level_id);
        }
    }
}
