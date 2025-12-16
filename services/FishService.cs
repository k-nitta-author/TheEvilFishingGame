using System;
using Godot;
using Models;

namespace Service
{
    public partial class FishService: Resource
    {

        Fish NullFish = new Fish();

        // get a given fish by index
        public Fish GetFishByIdx(int idx)
        {
            return NullFish;
        }

        // get a given fish by name
        public Fish GetFishByName(String name)
        {
            return NullFish;
        }
    }
}