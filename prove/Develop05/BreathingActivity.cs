using System;
using System.Collections;
using System.Collections.Generic;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Focus on your breathing.")
    { }

    public void Run()
    {
        // Muestra el mensaje inicial y define la duración
        DisplayStartingMessage();
        int duration = GetDuration();  // Obtiene la duración de la actividad en segundos
        DateTime endTime = DateTime.Now.AddSeconds(duration);  // Calcula el tiempo de finalización

        // Mientras no se haya alcanzado el tiempo de finalización, realiza la actividad de respiración
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);  // Cuenta regresiva de 4 segundos para inhalar
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);  // Cuenta regresiva de 6 segundos para exhalar
        }

        // Muestra el mensaje final una vez terminada la actividad
        DisplayEndingMessage();
    }
}
