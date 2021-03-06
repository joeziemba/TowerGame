﻿using System;
namespace TreehouseDefense
{
    public class Game
    {
        static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    });
                Console.WriteLine(value: "Welcome!");

                // MapLocation location = new MapLocation(0, 2, map);

                // if(path.IsOnPath(location))
                // {
                //     Console.WriteLine(location + " is on the path.");
                //     return;
                // }

                IInvader[] invaders = {
                    new SpeedBot(path),
                    new ShieldBot(path),
                    new ZomBot(path),
                    new PlainBot(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new PowerTower(new MapLocation(3, 1, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            // Setting using a setter method:
                // invader.SetLocation(location);

            // Setting using a Property setter:
                // invader.Location = location; 
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}
