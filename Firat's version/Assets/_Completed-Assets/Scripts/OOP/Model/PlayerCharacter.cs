﻿using UnityEngine;

namespace Model
{
    public class PlayerCharacter : GameObjectBase
    {
        public PlayerCharacter()
        {
            LoadPrefab("Done_Player");
            Instantiate();
            /*cannon = new Cannon(gameObject.transform, "Done_Bolt", 0.2f, 20);
            boundary = new Vector4(-6.9f, 6.9f, -4, 10);*/
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
        }
    }
}
 

