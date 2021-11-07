using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundAudio: MonoBehaviour
{
      private static backgroundAudio instance = null;
      private AudioSource audio;

      private void Awake()
      {
          if (instance == null)
          { 
               instance = this;
               DontDestroyOnLoad(gameObject);
               return;
          }
          if (instance == this) return; 
          Destroy(gameObject);
      }

      void Start()
      {
         audio = GetComponent<AudioSource>();
         audio.Play();
      }
}
