using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    public int s;
    public int n;
    public int a;
    PlayerMovement playerMovement;                              // Reference to the player's movement.
    PlayerShooting playerShooting;
    //GameObject win;
    void Awake()
    {
    }
    public void _Playbutton()
    {
        Application.LoadLevel(s);
    }
    public void _exit()
    {
        Application.Quit();
    }
    public void _next()
    {
        Application.LoadLevel(n);
        Time.timeScale = 1;
    }
   public void _re()
    {
        Application.LoadLevel(a);
        Time.timeScale = 1;
    }
    public void _re2()
    {
        Application.LoadLevel(a);
        Time.timeScale = 1;
    }
}
