using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using Normal.Realtime;

    public class RealtimeThrowable : MonoBehaviour
    {

        private RealtimeTransform bob;
        private RealtimeView bill;

        // Start is called before the first frame update
        void Start()
        {
            bob = gameObject.GetComponent<RealtimeTransform>();
            bill = gameObject.GetComponent<RealtimeView>();
        }

        public void Grabbed()
        {
            bob.RequestOwnership();
            bill.RequestOwnership();
        }

    }

