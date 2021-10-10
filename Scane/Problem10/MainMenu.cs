using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
     public void problem1()
    {
        SceneManager.LoadScene(1);
    }
     public void problem2()
    {
        SceneManager.LoadScene(2);
    } public void problem3()
    {
        SceneManager.LoadScene(3);
    } public void problem4()
    {
        SceneManager.LoadScene(4);
    } public void problem5()
    {
        SceneManager.LoadScene(5);
    } public void problem6()
    {
        SceneManager.LoadScene(6);
    } public void problem7()
    {
        SceneManager.LoadScene(7);
    } public void problem8()
    {
        SceneManager.LoadScene(8);
    }
     public void problem9()
    {
        SceneManager.LoadScene(9);
    }
    public void keluarGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
         SceneManager.LoadScene(9);
         
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}