using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject OliveOil = null;
    public GameObject Character = null;

    public void Start()
    {
        OliveOil.SetActive(false);
        Character.SetActive(false);

        //ShowCharacters();

        StartCoroutine(WaitBeforeShow());
    }

    private void ShowCharacters()
    {
        OliveOil.SetActive(true);

        //wait a couple of seconds

        Character.SetActive(true);
    }

    private IEnumerator WaitBeforeShow()
    {
        OliveOil.SetActive(true);

        yield return new WaitForSeconds(5);

        Character.SetActive(true);
    }

}