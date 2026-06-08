using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   public void Quit()
   {
      Application.Quit();  
   }
   void Update()
   {
      if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
      {
         Quit();
      }
   }
}
