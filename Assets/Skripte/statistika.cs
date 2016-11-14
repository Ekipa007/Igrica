using UnityEngine;
using System.Collections;

public class statistika : MonoBehaviour {

    public GameObject MainGameObject;
    public GameObject StatistikaGameObject;

    public void StatistikaMenu()
    {
        MainGameObject.SetActive(false);
        StatistikaGameObject.SetActive(true);
    }

    public void MainMenu()
    {
        MainGameObject.SetActive(true);
        StatistikaGameObject.SetActive(false);
    }
}
