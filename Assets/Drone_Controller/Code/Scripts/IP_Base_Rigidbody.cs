using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndiePixel
{
    [RequireComponent(typeof(Rigidbody))]
    public class IP_Base_Rigidbody : MonoBehaviour
    {
        #region Variables
        [Header("Rigidbody Properties")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbsTokg = 0.454f;

        protected Rigidbody rb;
        protected float startDrag;
        protected float startAngularDrag;
        #endregion

        #region Main Methods
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if(rb)
            {
                rb.mass = weightInLbs * lbsTokg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }
    
        // Update is called once per frame
        void Update()
        {
            if(!rb)
            {
                return;
            }

            HandlePhysics();
        }
        #endregion


        #region  Custom Methods
        protected virtual void HandlePhysics() { }
        
        #endregion
    }
}