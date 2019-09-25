using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using Normal.Realtime;

    public class RealtimeThrowable : MonoBehaviour
    {

        private RealtimeTransform bob;

        // Start is called before the first frame update
        void Start()
        {
            bob = gameObject.GetComponent<RealtimeTransform>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Grabbed()
        {
            bob.RequestOwnership();
        }
        public void Released()
        {

        }
    }

