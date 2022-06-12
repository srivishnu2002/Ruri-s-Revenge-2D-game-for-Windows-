using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public Button restart;

    
    
        void Start()
        {
            Button btn = restart.GetComponent<Button>();
            btn.onClick.AddListener(RESTART);
        }

        public void RESTART()
        {
            PlayerPrefs.DeleteAll();
        }
    
}
