using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void exit() {
        Application.Quit();
        Debug.Log("Berhasil Keluar dari aplikasi ");
    }

    public void about() {
        SceneManager.LoadScene("about");
    }

     public void back() {
     SceneManager.LoadScene("mainMenu");
 }

    public void scann() {
        SceneManager.LoadScene("scann");
    }
}
