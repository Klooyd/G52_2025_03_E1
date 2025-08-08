using UnityEngine;
using System;
using UnityEditor.Animations;

namespace packagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        public string codeE;
        public string nameCarreraE;

        public Estudiante() { }
        public Estudiante(string codeE, string nameCarreraE, string nameP, string mailP, string dirP)
            : base(nameP, mailP, dirP)
        {
            this.codeE = codeE; this.nameCarreraE = nameCarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }
    }
}