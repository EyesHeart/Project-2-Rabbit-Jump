using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{
  public void changeScene()
    {
        Application.LoadLevel("LoadLevel");
    }
}
