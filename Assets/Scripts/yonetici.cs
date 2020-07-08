using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yonetici : MonoBehaviour
{


    public string[] sozluk;



    public Text puan_text;


    public GameObject questionToHide, questionToShow, questionToShow1, questionToShow2, questionToShow3, questionToShow4;



    public AudioSource source;
    public AudioClip[] kelimeYokOl;

    List<GameObject> isaretli_butonlar;
    string kelime = null;
    public bool tikladi = false;


    public int level_id;

    int puan = 0;
    int bulunan_kelime_sayisi = 0;

    // Start is called before the first frame update
    void Start()
    {
  

        isaretli_butonlar = new List<GameObject>();
        level_id = PlayerPrefs.GetInt("levelidBulmaca");

    }

    // Update is called once per frame
    public void isaretli_buton_olustur(GameObject button)
    {
        isaretli_butonlar.Add(button);
        kelime = null;

        foreach (GameObject butonlar in isaretli_butonlar)
        {
            kelime = kelime + butonlar.name;
            puan_text.text = kelime;

        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount >=1 && Input.touches[0].phase == TouchPhase.Began)
        {
            tikladi = true;
        }

        if (Input.GetMouseButtonUp(0) || Input.touchCount >= 1 && Input.touches[0].phase == TouchPhase.Ended)
        {
            tikladi = false;
            yazi_olustur();


            puan_text.text = puan.ToString();

        }


    }

    private void yazi_olustur()
    {
        foreach (string kelimeler in sozluk)
        {
            if (kelimeler == kelime)
            {
                puan += 100;
                bulunan_kelime_sayisi++;
                Debug.Log(bulunan_kelime_sayisi);


                foreach (GameObject button in isaretli_butonlar)
                {
                    button.GetComponent<ButtonKontrol>().yok_ol = true;
                    source.Play();
                }
            }
        }

        isaretli_butonlar.Clear();
        kelime = null;

        if (bulunan_kelime_sayisi == 1)
        {
            StartCoroutine(LoadNextPanel());
        }
        if (bulunan_kelime_sayisi == 3)
        {
            StartCoroutine(LoadNextPanel1());
        }
        if (bulunan_kelime_sayisi == 6)
        {
            StartCoroutine(LoadNextPanel2());
        }
        if (bulunan_kelime_sayisi == 10)
        {
            StartCoroutine(LoadNextPanel3());
        }
        if (bulunan_kelime_sayisi == 14)
        {
            StartCoroutine(LoadNextPanel4());
        }
    }




    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);

    }
    IEnumerator LoadNextPanel1()
    {
        yield return new WaitForSeconds(1f);

        questionToShow.SetActive(false);
        questionToShow1.SetActive(true);

    }
    IEnumerator LoadNextPanel2()
    {
        yield return new WaitForSeconds(1f);

        questionToShow1.SetActive(false);
        questionToShow2.SetActive(true);

    }
    IEnumerator LoadNextPanel3()
    {
        yield return new WaitForSeconds(1f);

        questionToShow2.SetActive(false);
        questionToShow3.SetActive(true);

    }
    IEnumerator LoadNextPanel4()
    {
        yield return new WaitForSeconds(1f);

        questionToShow3.SetActive(false);
        questionToShow4.SetActive(true);
        level_id++;
        PlayerPrefs.SetInt("levelidBulmaca", level_id);

    }


}

