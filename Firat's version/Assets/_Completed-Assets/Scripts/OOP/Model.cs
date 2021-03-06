﻿using System.Collections.Generic;


namespace Model
{
    class Model
    {
        //public List<IHazard> hazards;

        public bool gameOver;
        public int score;

        public Player player;
        //public Boundary boundary;
        public BlinkMonster blinkMonster;
        public List<Platform> platform;
		public List<TeleportPlatform> teleportPlatform;
		public List<MovingPlatform> movingPlatform;
		public List<MagicPlatform> magicPlatform;
        public List<Pike> pikes;
        public Model()
        {
            player = new Player();
           // boundary = new Boundary();
            platform = new List<Platform>();
			teleportPlatform = new List<TeleportPlatform> ();
			movingPlatform = new List<MovingPlatform> ();
			magicPlatform = new List<MagicPlatform> ();
            pikes = new List<Pike>();
        }

        public void AddMonster(int x, int y)
        {
            blinkMonster = new BlinkMonster(x, y);
            SetMonster();
        }

		public void AddTeleportPlatform(int length, int width, int x, int z, int destx, int desty, int camx, int camz)
		{
			teleportPlatform.Add (new TeleportPlatform(length, width, x, z, destx, desty, camx, camz));
			SetTeleportPlatform(teleportPlatform.Count - 1);
		}

		public void AddMovingPlatform(int length, int width, int x, int z, int direction, int amplitude)
		{
			movingPlatform.Add (new MovingPlatform(length, width, x, z, direction, amplitude));
			SetMovingPlatform(movingPlatform.Count - 1);
		}

		public void AddMagicPlatform(int length, int width, int x, int z, int direction, int amplitude)
		{
			magicPlatform.Add (new MagicPlatform(length, width, x, z, direction, amplitude));
			SetMagicPlatform(magicPlatform.Count - 1);
		}

        public void AddPlatform(int length, int width, int x, int z)
        {
            platform.Add( new Platform(length, width, x, z) );
            SetPlatform(platform.Count -1);
        }

        public void AddPike(int length, int width, int x, int z)
        {
            pikes.Add(new Pike(length, width, x, z));
            SetPike(pikes.Count - 1);
        }

      /*  private void Set(int i)
        {
            hazards[i].SetPosition();
            hazards[i].Instantiate();
            hazards[i].Init();
        }*/

        private void SetMonster()
        {
            blinkMonster.Instantiate();
        }
		private void SetTeleportPlatform(int i)
		{
			teleportPlatform[i].Instantiate();
			//teleportPlatform[i].SetPosition ();
			teleportPlatform[i].SetScale();
		}

		private void SetMovingPlatform(int i)
		{
			movingPlatform[i].Instantiate();
			//movingPlatform[i].SetPosition ();
			movingPlatform[i].SetScale();
		}

		private void SetMagicPlatform(int i)
		{
			magicPlatform[i].Instantiate();
			//magicPlatform[i].SetPosition ();
			magicPlatform[i].SetScale();

		}


        private void SetPlatform(int i)
        {
            platform[i].Instantiate();
			//platform [i].SetPosition ();
			platform[i].SetScale();
        }

        private void SetPike(int i)
        {
            pikes[i].Instantiate();
            //platform [i].SetPosition ();
            pikes[i].SetScale();
        }


        public void Update()
        {

        }
    }
}
