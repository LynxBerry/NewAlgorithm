﻿// See https://aka.ms/new-console-template for more information
using PlayBacktrack.App;

var instance = new PlayBacktrackBruteForce();
instance.Test([1,2,3,4], 10);
Console.WriteLine("separator");
instance.Test([1,3,1,4,2], 5);