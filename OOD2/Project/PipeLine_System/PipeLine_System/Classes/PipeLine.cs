﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    public class PipeLine
    {
        /*The PipeLine is a special class, even though it is in many ways similar to the Component class and shares a few attributes with 
         * the Component class. The PipeLine class represents the pipe-lines that connect the various components in the pipe-line network.
         * The reason we distinguish the PipeLine class from the conventional Component class is because it includes a List which presents
         * the various locations that the pipe-line touches on the drawing screen. 
         */

        /*PROPERTIES:
         * The PipeLine class has several properties including a few in common with the Component class such as the currentFlow, and the id.
         * The other properties include a List of locations that the user wants the pipe-line to pass through on the drawing screen. 
         */

        //Instance variables
        private int id;
        private Point startLocation;
        private Point endLocation;
        private double currentFlow;
        private double safeLimit;
        private List<Point> clickLocation;
        private Component compStart;
        private Component compEnd;
        private bool danger;
        //Constructors
    }
}
