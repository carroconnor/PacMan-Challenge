﻿using System.Collections.Generic;

namespace Italian
{
    public class GameObject
    {
        public string type;

        public GameObject(string type)
        {
            this.type = type;
        }

        Dictionary<string, int> livesDictionary = new Dictionary<string, int>()
        {
            {"InvincibleGhost", 1 },
            {"Dot", 0 },
            {"VulnerableGhost", 0 },
            {"Cherry", 0 },
            {"Strawberry", 0 },
            {"Orange", 0 },
            {"Apple", 0 },
            {"Melon", 0 },
            {"Galaxian", 0 },
            {"Bell", 0 },
            {"Key", 0 }

        };

        Dictionary<string, int> pointsDictionary = new Dictionary<string, int>()
        {
            {"InvincibleGhost", 0 },
            {"Dot", 10 },
            {"VulnerableGhost", 200 },
            {"Cherry", 100 },
            {"Strawberry", 300 },
            {"Orange", 500 },
            {"Apple", 200 },
            {"Melon", 1000 },
            {"Galaxian", 2000 },
            {"Bell", 3000 },
            {"Key", 5000 }

        };

        public int GetLives()
        {
            var life = this.livesDictionary[this.type];
            return life;
        }

        public int GetPoints()
        {
            var point = this.pointsDictionary[this.type];
            return point;
        }


    }
}

