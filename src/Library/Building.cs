//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Building
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        public string StringBuilding()
        {
            List<string> lista = new List<string>();
            lista.Add($"Edificio {this.Description}:");
            foreach (Task task in this.tasks)
            {
                lista.Add($"{task.Quantity} de '{task.Material.Description}' " +
                    $"usando '{task.Equipment.Description}' durante {task.Time}");
            }
            
            return string.Join(("\n"), lista.ToArray());
        }
        
        public double GetProductionCost()
        {
            double costoMateriales = 0;
            double costoHerramientas = 0;
            foreach (Task task in this.tasks)
            {
                costoMateriales += task.Material.UnitCost * task.Quantity;
                costoHerramientas += task.Equipment.HourlyCost * task.Time;
            }
            double totalCost = costoMateriales + costoHerramientas;
            return totalCost;
        }
        
    }
}