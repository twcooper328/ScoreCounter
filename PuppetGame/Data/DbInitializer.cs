using PuppetGame.Data;
using PuppetGame.Models;
using System;
using System.Linq;

namespace PuppetGame.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PuppetContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Hats.
            if (context.Hats.Any())
            {
                return;   // DB has been seeded
            }

            var Hats = new Hat[]
            {
                new Hat{HatID=1,Name="Visionary's Visor",Energy=1,Pot=100,Turn=400},
                new Hat{HatID=2,Name="Motivating SweatBand",Energy=3,Pot=0,Turn=150},
                new Hat{HatID=3,Name="Cool-Down Shades",Energy=0,Pot=1200,Turn=0},
                new Hat{HatID=4,Name="Business Bluetooth",Energy=1,Pot=700,Turn=80}
            };

            context.Hats.AddRange(Hats);
            context.SaveChanges();

            var Eyes = new Eye[]
            {
                new Eye{EyeID=1,Name="Watchful Eye",Energy=1,Pot=400,Turn=0},
                new Eye{EyeID=2,Name="Bountiful Outlook",Energy=1,Pot=0,Turn=200},
                new Eye{EyeID=3,Name="Gambler's Gaze",Energy=-2,Pot=100,Turn=-350},
                new Eye{EyeID=4,Name="Optimistic Per-Spectacles",Energy=2,Pot=-200,Turn=0,}                  
            };

            context.Eyes.AddRange(Eyes);
            context.SaveChanges();

            var Arms = new Arm[]
            {
                new Arm{ArmID=1,Name="Power Sleeve",Energy=1,Pot=100,Turn=400},
                new Arm{ArmID=2,Name="Tiny T-Rex Arms",Energy=3,Pot=-1000,Turn=-150},
                new Arm{ArmID=3,Name="Martial-Arms",Energy=0,Pot=500,Turn=200},
                new Arm{ArmID=3,Name="Business-Case",Energy=-1,Pot=800,Turn=170}
      
            };

            context.Arms.AddRange(Arms);
            context.SaveChanges();

            var Legs = new Leg[]
            {
                new Leg{LegID=1,Name="Kris-Kross Jeans",Energy=0,Pot=0,Turn=0},
                new Leg{LegID=1,Name="Investor's Dress-Skirt",Energy=0,Pot=150,Turn=0},
                new Leg{LegID=1,Name="Runner's Trunks",Energy=0,Pot=600,Turn=0},
                new Leg{LegID=1,Name="Seed-money Slacks",Energy=1,Pot=0,Turn=150}
            };

            context.Arms.AddRange(Arms);
            context.SaveChanges();
        }
    }
}