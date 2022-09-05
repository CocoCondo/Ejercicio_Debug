//-------------------------------------------------------------------------
// <copyright file="Word.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace WordsPhrases
{
    public class Word
    {
        // Para uso interno de la propiedad Text.
        private string text;

        /// <summary>
        /// Crea una nueva palabra con el texto recibido como argumento.
        /// </summary>
        /// <param name="text">El texto de la palabra.</param>
        public Word(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Obtiene o establece el texto de la palabra. El texto no tiene espacios al comienzo ni al final -los espacios
        /// son removidos al asignar el texto-.
        /// </summary>
        /// <value>El texto de la palabra</value>
        public string Text
        {
            get
            {
                return this.text.Trim(); //Si bien dice que no obtiene espacios, al trimear devuelve sin espacios. Trimeo lo que retorna para sacar los espacios innecesarios
            }

            set
            {
                this.text = value;
            }
        }
    }
}
