using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlimUI.ModernMenu
{
    public class BTN_Exit : MonoBehaviour
    {
        public GameObject gameObject;

        // Start is called before the first frame update
        void Start()
        {
            gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SomeFunction()
        {
            Application.Quit(0);
        }
    }
}