//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

/// <summary>
/// Clase que contiene el punto de entrada al programa.
/// </summary>
namespace WordsPhrases
{
    public class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            const string text1 = " text1 ";
            const string text2 = " text2 "; //Cuando se asignan tienen espacios al principio y al final
            const string expected = "text1 text2"; //Aca no tiene espacios al principio y final
            Phrase phrase = new Phrase();
            Word word1 = new Word(text1);
            Word word2 = new Word(text2);
            phrase.AddWord(word1);
            phrase.AddWord(word2);
            string actual = phrase.GetPhrase(); //Al asignarse queda más espacio entre las palabras
            //Assert.AreEqual(expected, actual);

            if (actual == expected)
            {
                Console.WriteLine($"Okay, '{actual}' es igual a '{expected}'");
            }
            else
            {
                Console.WriteLine($"Algo salió mal, '{actual}' es diferente de '{expected}'"); //"Diferente" estaba mal escrito
            }
        }
    }
}
