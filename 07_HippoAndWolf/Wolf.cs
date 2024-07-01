﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_HippoAndWolf
{
    internal class Wolf : Canine
    {
        public Wolf(bool belongsToPack) 
        {
            BelongsToPack = belongsToPack;
        }
        public override void MakeNois()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm in a pack.");
            Console.WriteLine("Aroooooo!");
        }
        public void HuntInPack()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm going hunting with my pack!");
            else
                Console.WriteLine("I'm not in a pack.");
        }
    }
}
