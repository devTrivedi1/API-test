using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ClassLibrary1
{
    public class Player : MonoBehaviour
    {
        [SerializeField] int speed;

        public void Update()
        {
            Move();
        }
        public void Move()
        {
            transform.position += new Vector3(2, 0, 0) * speed * Time.deltaTime;
            if (transform.position.x > 5)
            {
                Destroy(transform.gameObject);
            }
        }

    }
}
