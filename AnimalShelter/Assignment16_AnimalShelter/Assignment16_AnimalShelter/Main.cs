﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment16_AnimalShelter.Classes;

namespace Assignment16_AnimalShelter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Shelter animalShelter = new Shelter("Eindhoven Animal Shelter", 999000999, "Fontys, Eindhoven", "example@example.com");
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Form addform = new AddAnimal();
            //addform
            addform.Show();
        }

        private void btnAssignAnimal_Click(object sender, EventArgs e)
        {
            Form assignForm = new AssignAnimalToOwner();
            assignForm.Show();
        }
    }
}
